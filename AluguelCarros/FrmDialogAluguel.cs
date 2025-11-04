using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelCarros
{
    public partial class FrmDialogAluguel : Form
    {
        private string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ302752XPR2;User ID=aluno;Password=aluno;TrustServerCertificate=True;";

        private int idVeiculo;
        private decimal valorDiaria;

        public FrmDialogAluguel(int idVeiculo, string marca, string modelo, decimal valorDiaria)
        {
            InitializeComponent();

            this.idVeiculo = idVeiculo;
            this.valorDiaria = valorDiaria;

            // Preenche dados do veículo
            lblVeiculo.Text = $"{marca} {modelo}";
            lblValorDiaria.Text = $"R$ {valorDiaria:F2} / dia";

            // Preenche dados do cliente logado
            CarregarDadosCliente();

            // Define data mínima como hoje
            dtpRetirada.MinDate = DateTime.Today;
            dtpDevolucao.MinDate = DateTime.Today.AddDays(1);

            // Define datas padrão
            dtpRetirada.Value = DateTime.Today;
            dtpDevolucao.Value = DateTime.Today.AddDays(1);

            // Calcula valor inicial
            CalcularValorTotal();
        }

        private void CarregarDadosCliente()
        {
            // Preenche com dados do cliente logado (classe estática)
            lblNome.Text = UsuarioLogado.Nome;
            lblCPF.Text = UsuarioLogado.CPF;
            lblCNH.Text = UsuarioLogado.CNH;
            lblTelefone.Text = UsuarioLogado.Telefone;
        }

        private void dtpRetirada_ValueChanged(object sender, EventArgs e)
        {
            // Garante que devolução seja sempre depois da retirada
            if (dtpDevolucao.Value <= dtpRetirada.Value)
            {
                dtpDevolucao.Value = dtpRetirada.Value.AddDays(1);
            }

            dtpDevolucao.MinDate = dtpRetirada.Value.AddDays(1);
            CalcularValorTotal();
        }

        private void dtpDevolucao_ValueChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {
            // Calcula quantidade de dias
            TimeSpan diferenca = dtpDevolucao.Value.Date - dtpRetirada.Value.Date;
            int dias = diferenca.Days;

            // Calcula valor total
            decimal valorTotal = dias * valorDiaria;

            // Atualiza labels
            lblDias.Text = $"{dias} dia(s)";
            lblValorTotal.Text = $"R$ {valorTotal:F2}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações
                if (dtpDevolucao.Value <= dtpRetirada.Value)
                {
                    MessageBox.Show("A data de devolução deve ser posterior à data de retirada!",
                        "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirma com o usuário
                TimeSpan diferenca = dtpDevolucao.Value.Date - dtpRetirada.Value.Date;
                int dias = diferenca.Days;
                decimal valorTotal = dias * valorDiaria;

                DialogResult result = MessageBox.Show(
                    $"Confirmar aluguel?\n\n" +
                    $"Veículo: {lblVeiculo.Text}\n" +
                    $"Período: {dtpRetirada.Value:dd/MM/yyyy} até {dtpDevolucao.Value:dd/MM/yyyy}\n" +
                    $"Total de dias: {dias}\n" +
                    $"Valor Total: R$ {valorTotal:F2}",
                    "Confirmar Aluguel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    RealizarAluguel(dias, valorTotal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar aluguel: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RealizarAluguel(int dias, decimal valorTotal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Inserir o aluguel na tabela Alugueis
                    string queryAluguel = @"INSERT INTO Alugueis 
                                          (ID_Cliente, ID_Veiculo, DataRetirada, DataDevolucao, ValorTotal, Status, DataCadastro)
                                          VALUES 
                                          (@ID_Cliente, @ID_Veiculo, @DataRetirada, @DataDevolucao, @ValorTotal, 'Ativo', GETDATE())";

                    SqlCommand cmdAluguel = new SqlCommand(queryAluguel, conn, transaction);
                    cmdAluguel.Parameters.AddWithValue("@ID_Cliente", UsuarioLogado.ID_Cliente);
                    cmdAluguel.Parameters.AddWithValue("@ID_Veiculo", idVeiculo);
                    cmdAluguel.Parameters.AddWithValue("@DataRetirada", dtpRetirada.Value.Date);
                    cmdAluguel.Parameters.AddWithValue("@DataDevolucao", dtpDevolucao.Value.Date);
                    cmdAluguel.Parameters.AddWithValue("@ValorTotal", valorTotal);
                    cmdAluguel.ExecuteNonQuery();

                    // 2. Atualizar status do veículo para "Alugado"
                    string queryVeiculo = @"UPDATE Veiculos 
                                          SET Status = 'Alugado' 
                                          WHERE ID_Veiculo = @ID_Veiculo";

                    SqlCommand cmdVeiculo = new SqlCommand(queryVeiculo, conn, transaction);
                    cmdVeiculo.Parameters.AddWithValue("@ID_Veiculo", idVeiculo);
                    cmdVeiculo.ExecuteNonQuery();

                    // Confirma a transação
                    transaction.Commit();

                    MessageBox.Show(
                        "Aluguel realizado com sucesso!\n\n" +
                        $"Retirada: {dtpRetirada.Value:dd/MM/yyyy}\n" +
                        $"Devolução: {dtpDevolucao.Value:dd/MM/yyyy}\n" +
                        $"Total: R$ {valorTotal:F2}\n\n" +
                        "Boa viagem!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro ao salvar aluguel: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }
    }

    // Classe estática para armazenar dados do usuário logado
    public static class UsuarioLogado
    {
        public static int ID_Cliente { get; set; }
        public static string Nome { get; set; }
        public static string CPF { get; set; }
        public static string Email { get; set; }
        public static string CNH { get; set; }
        public static string Telefone { get; set; }
    }
}
