using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using AluguelCarros;

namespace SistemaVeiculos
{
    public partial class FrmRecuperarSenha : Form
    {
        private TextBox txtUsuario;
        private TextBox txtEmail;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmarSenha;
        private Button btnRecuperar;
        private Button btnVoltar;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblUsuario;
        private Label lblEmail;
        private Label lblNovaSenha;
        private Label lblConfirmarSenha;
        private PictureBox pbIcone;
        private Panel panelCentral;

        public FrmRecuperarSenha()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Configurações do Form
            this.ClientSize = new Size(450, 650);
            this.Text = "Recuperar Senha";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(240, 240, 240);

            // Panel Central
            panelCentral = new Panel
            {
                Location = new Point(40, 30),
                Size = new Size(370, 580),
                BackColor = Color.White
            };
            this.Controls.Add(panelCentral);

            // PictureBox Ícone
            pbIcone = new PictureBox
            {
                Location = new Point(135, 20),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(220, 53, 69)
            };
            panelCentral.Controls.Add(pbIcone);

            // Label Título
            lblTitulo = new Label
            {
                Text = "Recuperar Senha",
                Location = new Point(85, 130),
                Size = new Size(200, 30),
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(220, 53, 69),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelCentral.Controls.Add(lblTitulo);

            // Label Subtítulo
            lblSubtitulo = new Label
            {
                Text = "Informe seus dados para redefinir a senha",
                Location = new Point(30, 165),
                Size = new Size(310, 40),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(100, 100, 100),
                TextAlign = ContentAlignment.TopCenter
            };
            panelCentral.Controls.Add(lblSubtitulo);

            // Label Usuário
            lblUsuario = new Label
            {
                Text = "Nome de Usuário:",
                Location = new Point(30, 220),
                Size = new Size(310, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64)
            };
            panelCentral.Controls.Add(lblUsuario);

            // TextBox Usuário
            txtUsuario = new TextBox
            {
                Location = new Point(30, 245),
                Size = new Size(310, 30),
                Font = new Font("Segoe UI", 11),
                MaxLength = 50
            };
            panelCentral.Controls.Add(txtUsuario);

            // Label Email
            lblEmail = new Label
            {
                Text = "E-mail Cadastrado:",
                Location = new Point(30, 285),
                Size = new Size(310, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64)
            };
            panelCentral.Controls.Add(lblEmail);

            // TextBox Email
            txtEmail = new TextBox
            {
                Location = new Point(30, 310),
                Size = new Size(310, 30),
                Font = new Font("Segoe UI", 11),
                MaxLength = 100
            };
            panelCentral.Controls.Add(txtEmail);

            // Label Nova Senha
            lblNovaSenha = new Label
            {
                Text = "Nova Senha:",
                Location = new Point(30, 350),
                Size = new Size(310, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64)
            };
            panelCentral.Controls.Add(lblNovaSenha);

            // TextBox Nova Senha
            txtNovaSenha = new TextBox
            {
                Location = new Point(30, 375),
                Size = new Size(310, 30),
                Font = new Font("Segoe UI", 11),
                PasswordChar = '●',
                MaxLength = 100
            };
            panelCentral.Controls.Add(txtNovaSenha);

            // Label Confirmar Senha
            lblConfirmarSenha = new Label
            {
                Text = "Confirmar Nova Senha:",
                Location = new Point(30, 415),
                Size = new Size(310, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64)
            };
            panelCentral.Controls.Add(lblConfirmarSenha);

            // TextBox Confirmar Senha
            txtConfirmarSenha = new TextBox
            {
                Location = new Point(30, 440),
                Size = new Size(310, 30),
                Font = new Font("Segoe UI", 11),
                PasswordChar = '●',
                MaxLength = 100
            };
            panelCentral.Controls.Add(txtConfirmarSenha);

            // Botão Recuperar
            btnRecuperar = new Button
            {
                Text = "REDEFINIR SENHA",
                Location = new Point(30, 490),
                Size = new Size(310, 40),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnRecuperar.FlatAppearance.BorderSize = 0;
            btnRecuperar.Click += BtnRecuperar_Click;
            panelCentral.Controls.Add(btnRecuperar);

            // Botão Voltar
            btnVoltar = new Button
            {
                Text = "Voltar ao Login",
                Location = new Point(105, 535),
                Size = new Size(160, 30),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(220, 53, 69),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Click += BtnVoltar_Click;
            panelCentral.Controls.Add(btnVoltar);

            this.ResumeLayout(false);
        }

        private void ConfigurarFormulario()
        {
            // Adicionar evento KeyPress para Enter
            txtUsuario.KeyPress += Txt_KeyPress;
            txtEmail.KeyPress += Txt_KeyPress;
            txtNovaSenha.KeyPress += Txt_KeyPress;
            txtConfirmarSenha.KeyPress += Txt_KeyPress;

            // Efeitos hover nos botões
            btnRecuperar.MouseEnter += (s, e) => btnRecuperar.BackColor = Color.FromArgb(200, 35, 51);
            btnRecuperar.MouseLeave += (s, e) => btnRecuperar.BackColor = Color.FromArgb(220, 53, 69);

            btnVoltar.MouseEnter += (s, e) => btnVoltar.ForeColor = Color.FromArgb(200, 35, 51);
            btnVoltar.MouseLeave += (s, e) => btnVoltar.ForeColor = Color.FromArgb(220, 53, 69);
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnRecuperar_Click(sender, e);
            }
        }

        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Por favor, informe o nome de usuário.",
                        "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, informe o e-mail.",
                        "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNovaSenha.Text))
                {
                    MessageBox.Show("Por favor, informe a nova senha.",
                        "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNovaSenha.Focus();
                    return;
                }

                if (txtNovaSenha.Text.Length < 6)
                {
                    MessageBox.Show("A senha deve ter no mínimo 6 caracteres.",
                        "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNovaSenha.Focus();
                    return;
                }

                if (txtNovaSenha.Text != txtConfirmarSenha.Text)
                {
                    MessageBox.Show("As senhas não coincidem.",
                        "Erro de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmarSenha.Focus();
                    return;
                }

                // Verificar se usuário e e-mail correspondem
                if (!VerificarUsuarioEmail())
                {
                    MessageBox.Show("Usuário e e-mail não correspondem aos dados cadastrados.",
                        "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Redefinir senha
                RedefinirSenha();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao recuperar senha: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarUsuarioEmail()
        {
            using (SqlConnection conn = Utilitarios.ObterConexao())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void RedefinirSenha()
        {
            using (SqlConnection conn = Utilitarios.ObterConexao())
            {
                string query = @"UPDATE Usuarios 
                                SET Senha = @NovaSenha 
                                WHERE Usuario = @Usuario AND Email = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NovaSenha", Utilitarios.CriptografarSenha(txtNovaSenha.Text));
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Senha redefinida com sucesso!\n\nVocê já pode fazer login com a nova senha.",
                        "Senha Alterada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Voltar para o login
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao redefinir senha. Tente novamente.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}