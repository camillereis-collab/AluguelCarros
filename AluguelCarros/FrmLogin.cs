using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AluguelCarros
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Verificar se há credenciais salvas
            CarregarCredenciaisSalvas();
        }

        /// <summary>
        /// Botão de Login
        /// </summary>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text.Trim();
            string senha = txbSenha.Text;

            // Validações básicas
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, informe o email!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, informe a senha!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSenha.Focus();
                return;
            }

            // Validar formato de email
            if (!Utilitarios.ValidarEmail(email))
            {
                MessageBox.Show("Por favor, informe um email válido!",
                    "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return;
            }

            // Realizar login
            RealizarLogin(email, senha);
        }

        /// <summary>
        /// Realiza o login verificando email e senha no banco
        /// </summary>
        private void RealizarLogin(string email, string senha)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Utilitarios.ConnectionString))
                {
                    conn.Open();

                    // Criptografa a senha para comparar com o banco
                    string senhaHash = Utilitarios.CriptografarSenha(senha);

                    string query = @"SELECT ID_Usuario, Nome, Email, TipoUsuario, CPF, CNH, Telefone, Status 
                                    FROM Usuarios 
                                    WHERE Email = @Email AND Senha = @Senha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.ToLower());
                        cmd.Parameters.AddWithValue("@Senha", senhaHash);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Verificar status do usuário
                                string status = reader["Status"].ToString();

                                if (status == "Inativo" || status == "Bloqueado")
                                {
                                    MessageBox.Show("Sua conta está " + status.ToLower() + ". Entre em contato com o suporte.",
                                        "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                // Preencher dados do usuário logado
                                UsuarioLogado.ID_Usuario = Convert.ToInt32(reader["ID_Usuario"]);
                                UsuarioLogado.Nome = reader["Nome"].ToString();
                                UsuarioLogado.Email = reader["Email"].ToString();
                                UsuarioLogado.TipoUsuario = reader["TipoUsuario"].ToString();
                                UsuarioLogado.CPF = reader["CPF"].ToString();
                                UsuarioLogado.CNH = reader["CNH"] != DBNull.Value ? reader["CNH"].ToString() : "";
                                UsuarioLogado.Telefone = reader["Telefone"].ToString();

                                // Salvar credenciais se checkbox marcado
                                if (chkLembrarSenha.Checked)
                                {
                                    SalvarCredenciais(email, senha);
                                }
                                else
                                {
                                    LimparCredenciaisSalvas();
                                }

                                // Redirecionar baseado no tipo de usuário
                                RedirecionarUsuario();
                            }
                            else
                            {
                                MessageBox.Show("Email ou senha incorretos!",
                                    "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txbSenha.Clear();
                                txbSenha.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Redireciona o usuário para a tela apropriada baseado no tipo
        /// </summary>
        private void RedirecionarUsuario()
        {
            this.Hide();

            if (UsuarioLogado.TipoUsuario == "Cliente")
            {
                // Cliente vai para consulta de veículos
                MessageBox.Show($"Bem-vindo(a), {UsuarioLogado.Nome}!",
                    "Login Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmConsultaVeiculos frmConsulta = new FrmConsultaVeiculos();
                frmConsulta.ShowDialog();
            }
            else if (UsuarioLogado.IsAdministrador())
            {
                // Administrador vai para cadastro de veículos
                MessageBox.Show($"Bem-vindo(a), {UsuarioLogado.Nome}!\n\nÁrea Administrativa",
                    "Login Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmCadVeículos frmCadVeiculos = new FrmCadVeículos();
                frmCadVeiculos.ShowDialog();
            }

            // Limpar sessão ao fechar
            UsuarioLogado.Limpar();
            this.Close();
        }

        /// <summary>
        /// Salva credenciais em Properties.Settings
        /// </summary>
        private void SalvarCredenciais(string email, string senha)
        {
            Properties.Settings.Default.EmailSalvo = email;
            Properties.Settings.Default.SenhaSalva = Utilitarios.CriptografarSenha(senha);
            Properties.Settings.Default.LembrarSenha = true;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Carrega credenciais salvas
        /// </summary>
        private void CarregarCredenciaisSalvas()
        {
            if (Properties.Settings.Default.LembrarSenha)
            {
                txbEmail.Text = Properties.Settings.Default.EmailSalvo;
                chkLembrarSenha.Checked = true;
                txbSenha.Focus();
            }
        }

        /// <summary>
        /// Limpa credenciais salvas
        /// </summary>
        private void LimparCredenciaisSalvas()
        {
            Properties.Settings.Default.EmailSalvo = "";
            Properties.Settings.Default.SenhaSalva = "";
            Properties.Settings.Default.LembrarSenha = false;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Botão para cadastro (apenas clientes)
        /// </summary>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCad frmCadastro = new FrmCad();
            frmCadastro.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Link para recuperação de senha
        /// </summary>
        private void lnkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperarSenha frmRecuperar = new FrmRecuperarSenha();
            frmRecuperar.ShowDialog();
        }

        /// <summary>
        /// Checkbox para mostrar/ocultar senha
        /// </summary>
        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txbSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        /// <summary>
        /// Botão Voltar
        /// </summary>
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Enter no campo de senha realiza login
        /// </summary>
        private void txbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}