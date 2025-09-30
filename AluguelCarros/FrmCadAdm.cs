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
    public partial class FrmCadAdm : Form
    {
        public FrmCadAdm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicial telaAnterior = new FrmInicial();
            telaAnterior.Show();
        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
                // 1️⃣ Verificação de campos obrigatórios
                if (string.IsNullOrWhiteSpace(txbNomeADM.Text) ||
                    string.IsNullOrWhiteSpace(txbEmailADM.Text) ||
                    string.IsNullOrWhiteSpace(txbSENHAADM.Text) ||
                    string.IsNullOrWhiteSpace(txbCONFIGADM.Text) ||
                    string.IsNullOrWhiteSpace(txbADM.Text) ||
                    string.IsNullOrWhiteSpace(txbCPFADM.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios!");
                    return;
                }

                // 2️⃣ Verificação de senha
                if (txbSENHAADM.Text.Length < 6)
                {
                    MessageBox.Show("A senha deve ter pelo menos 6 caracteres!");
                    return;
                }

                if (txbSENHAADM.Text != txbCONFIGADM.Text)
                {
                    MessageBox.Show("As senhas não coincidem!");
                    return;
                }

                // 3️⃣ Inserção no banco de dados
                string conexao = "Data Source=SERVIDOR;Initial Catalog=SeuBanco;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    try
                    {
                        conn.Open();

                        string query = @"INSERT INTO Administradores
                                     (Nome, Email, Senha, Telefone, CPF, DataNascimento, DataCadastro, Status)
                                     VALUES (@Nome, @Email, @Senha, @Telefone, @CPF, @DataNascimento, GETDATE(), 'Ativo')";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Senha", txtSenha.Text); // ideal usar hash
                            cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                            cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                            cmd.Parameters.AddWithValue("@DataNascimento", dtpNascimento.Value.Date);

                            cmd.ExecuteNonQuery();
                        }

                        // 4️⃣ Mensagem de sucesso
                        MessageBox.Show("Administrador cadastrado com sucesso!");

                        // Limpar campos após cadastro
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtConfirmarSenha.Clear();
                        txtTelefone.Clear();
                        txtCPF.Clear();
                        dtpNascimento.Value = DateTime.Today;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                    }
                }
            }
        }
    }



