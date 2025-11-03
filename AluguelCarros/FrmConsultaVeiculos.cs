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
    public partial class FrmConsultaVeiculos : Form
        {
            // ALTERE com sua connection string
            private string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ302752XPR2;User ID=aluno;Password=aluno;TrustServerCertificate=True;";

            public FrmConsultaVeiculos()
            {
                InitializeComponent();
                CarregarCategorias();
                CarregarVeiculos();
            }

            private void CarregarCategorias()
            {
                // Adiciona opção "Todas" para mostrar todos os carros
                cmbFiltroCategoria.Items.Clear();
                cmbFiltroCategoria.Items.Add("Todas");
                cmbFiltroCategoria.Items.Add("Econômico");
                cmbFiltroCategoria.Items.Add("Compacto");
                cmbFiltroCategoria.Items.Add("Sedan");
                cmbFiltroCategoria.Items.Add("Premium");
                cmbFiltroCategoria.SelectedIndex = 0; // Padrão: Todas
            }

            private void CarregarVeiculos()
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // Query mostra apenas carros DISPONÍVEIS
                        string query = @"SELECT 
                                        ID_Veiculo AS 'ID',
                                        Marca AS 'Marca',
                                        Modelo AS 'Modelo',
                                        Ano AS 'Ano',
                                        Cor AS 'Cor',
                                        Combustivel AS 'Combustível',
                                        Categoria AS 'Categoria',
                                        ValorDiaria AS 'Valor Diária (R$)'
                                    FROM Veiculos
                                    WHERE Status = 'Disponível'
                                    ORDER BY Categoria, ValorDiaria";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvVeiculos.DataSource = dt;

                        // Formatar a grade
                        FormatarGrid();

                        // Atualizar contador
                        lblTotal.Text = $"Total de veículos disponíveis: {dt.Rows.Count}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar veículos: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void FormatarGrid()
            {
                if (dgvVeiculos.Columns.Count > 0)
                {
                    // Ocultar a coluna ID
                    dgvVeiculos.Columns["ID"].Visible = false;

                    // Ajustar largura das colunas
                    dgvVeiculos.Columns["Marca"].Width = 120;
                    dgvVeiculos.Columns["Modelo"].Width = 150;
                    dgvVeiculos.Columns["Ano"].Width = 70;
                    dgvVeiculos.Columns["Cor"].Width = 100;
                    dgvVeiculos.Columns["Combustível"].Width = 100;
                    dgvVeiculos.Columns["Categoria"].Width = 120;
                    dgvVeiculos.Columns["Valor Diária (R$)"].Width = 120;

                    // Formatar coluna de valor como moeda
                    dgvVeiculos.Columns["Valor Diária (R$)"].DefaultCellStyle.Format = "C2";
                    dgvVeiculos.Columns["Valor Diária (R$)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // Centralizar algumas colunas
                    dgvVeiculos.Columns["Ano"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvVeiculos.Columns["Cor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    // Não permitir edição
                    dgvVeiculos.ReadOnly = true;
                    dgvVeiculos.AllowUserToAddRows = false;
                    dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Cores alternadas nas linhas
                    dgvVeiculos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                }
            }

            private void btnPesquisar_Click(object sender, EventArgs e)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = @"SELECT 
                                        ID_Veiculo AS 'ID',
                                        Marca AS 'Marca',
                                        Modelo AS 'Modelo',
                                        Ano AS 'Ano',
                                        Cor AS 'Cor',
                                        Combustivel AS 'Combustível',
                                        Categoria AS 'Categoria',
                                        ValorDiaria AS 'Valor Diária (R$)'
                                    FROM Veiculos
                                    WHERE Status = 'Disponível'";

                        // Filtro por categoria
                        if (cmbFiltroCategoria.SelectedIndex > 0) // Se não for "Todas"
                        {
                            query += " AND Categoria = @Categoria";
                        }

                        // Filtro por pesquisa (marca ou modelo)
                        if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                        {
                            query += " AND (Marca LIKE @Pesquisa OR Modelo LIKE @Pesquisa)";
                        }

                        query += " ORDER BY Categoria, ValorDiaria";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        if (cmbFiltroCategoria.SelectedIndex > 0)
                        {
                            cmd.Parameters.AddWithValue("@Categoria", cmbFiltroCategoria.SelectedItem.ToString());
                        }

                        if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                        {
                            cmd.Parameters.AddWithValue("@Pesquisa", "%" + txtPesquisa.Text.Trim() + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvVeiculos.DataSource = dt;
                        FormatarGrid();

                        lblTotal.Text = $"Total de veículos encontrados: {dt.Rows.Count}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnLimparFiltros_Click(object sender, EventArgs e)
            {
                txtPesquisa.Clear();
                cmbFiltroCategoria.SelectedIndex = 0;
                CarregarVeiculos();
            }

            private void btnVerDetalhes_Click(object sender, EventArgs e)
            {
                if (dgvVeiculos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um veículo para ver os detalhes!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pega os dados da linha selecionada
                DataGridViewRow row = dgvVeiculos.SelectedRows[0];

                string detalhes = $"=== DETALHES DO VEÍCULO ===\n\n" +
                                $"Marca: {row.Cells["Marca"].Value}\n" +
                                $"Modelo: {row.Cells["Modelo"].Value}\n" +
                                $"Ano: {row.Cells["Ano"].Value}\n" +
                                $"Cor: {row.Cells["Cor"].Value}\n" +
                                $"Combustível: {row.Cells["Combustível"].Value}\n" +
                                $"Categoria: {row.Cells["Categoria"].Value}\n" +
                                $"Valor da Diária: {Convert.ToDecimal(row.Cells["Valor Diária (R$)"].Value):C2}\n\n" +
                                $"Status: DISPONÍVEL PARA ALUGUEL";

                MessageBox.Show(detalhes, "Detalhes do Veículo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void btnAlugar_Click(object sender, EventArgs e)
            {
                if (dgvVeiculos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um veículo para alugar!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dgvVeiculos.SelectedRows[0];
                int idVeiculo = Convert.ToInt32(row.Cells["ID"].Value);
                string modelo = row.Cells["Modelo"].Value.ToString();
                string marca = row.Cells["Marca"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Deseja alugar o veículo:\n\n{marca} {modelo}?",
                    "Confirmar Aluguel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Aqui você pode abrir um formulário de aluguel
                    // Por enquanto, vamos apenas mostrar uma mensagem
                    MessageBox.Show(
                        "Funcionalidade de aluguel será implementada em breve!\n\n" +
                        "Próximos passos:\n" +
                        "- Cadastrar dados do cliente\n" +
                        "- Definir período de aluguel\n" +
                        "- Calcular valor total\n" +
                        "- Gerar contrato",
                        "Em Desenvolvimento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            private void dgvVeiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                // Ao dar duplo clique, mostra os detalhes
                if (e.RowIndex >= 0)
                {
                    btnVerDetalhes_Click(sender, e);
                }
            }

            private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
            {
                // Pesquisa ao pressionar Enter
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnPesquisar_Click(sender, e);
                    e.Handled = true;
                }
            }
        }
    }
