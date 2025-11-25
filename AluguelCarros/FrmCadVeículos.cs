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
    public partial class FrmCadVeículos : Form
    {
        private string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ302752XPR2;User ID=aluno;Password=aluno;TrustServerCertificate=True;";
        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuAdmin;
        private ToolStripMenuItem menuUsuarios;
        private ToolStripMenuItem menuSair;
        private Label lblUsuarioLogado;
        public FrmCadVeículos()
        {
            InitializeComponent();
            }
        private void CriarMenuAdmin()
        {
            // MenuStrip
            menuPrincipal = new MenuStrip
            {
                BackColor = Color.FromArgb(0, 122, 204),
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            // Menu Administração (só aparece para admins)
            menuAdmin = new ToolStripMenuItem
            {
                Text = "Administração",
                ForeColor = Color.White,
                Visible = Usuarioconectado.EhAdministrador()
            };

            // Submenu Gerenciar Usuários
            menuUsuarios = new ToolStripMenuItem
            {
                Text = "Gerenciar Usuários",
                Image = null // Você pode adicionar um ícone aqui
            };
            menuUsuarios.Click += MenuUsuarios_Click;
            menuAdmin.DropDownItems.Add(menuUsuarios);

            // Menu Sair
            menuSair = new ToolStripMenuItem
            {
                Text = "Sair",
                ForeColor = Color.White
            };
            menuSair.Click += MenuSair_Click;

            // Adicionar menus ao MenuStrip
            menuPrincipal.Items.Add(menuAdmin);
            menuPrincipal.Items.Add(menuSair);

            // Label do usuário logado (à direita)
            lblUsuarioLogado = new Label
            {
                Text = $"👤 {UsuarioLogado.Nome}",
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Padding = new Padding(0, 3, 10, 0)
            };

            ToolStripControlHost labelHost = new ToolStripControlHost(lblUsuarioLogado)
            {
                Alignment = ToolStripItemAlignment.Right
            };
            menuPrincipal.Items.Add(labelHost);

            // Adicionar MenuStrip ao formulário
            this.MainMenuStrip = menuPrincipal;
            this.Controls.Add(menuPrincipal);

            // Ajustar posição dos outros controles (se necessário)
            // Todos os controles devem ficar abaixo do menu
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != menuPrincipal)
                {
                    ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + menuPrincipal.Height);
                }
            }
        }

        // 3. Adicione estes métodos de evento:
        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            FrmGerenciarAdministradores frmGerenciar = new FrmGerenciarAdministradores();
            frmGerenciar.ShowDialog();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Confirmar Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Limpar dados do usuário logado
                UsuarioLogado.Id = 0;
                UsuarioLogado.Nome = null;
                UsuarioLogado.Email = null;
                UsuarioLogado.TipoUsuario = null;

                // Voltar para o login
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
        }

        // 4. No construtor do FrmCadVeiculos, adicione após InitializeComponent():
        public FrmCadVeiculos()
        {
            InitializeComponent();
            CriarMenuAdmin(); // ADICIONE ESTA LINHA
                              // ... resto do código do construtor
        }

        // 5. IMPORTANTE: Ajuste o tamanho do formulário para acomodar o menu
        // No InitializeComponent() do seu FrmCadVeiculos, ajuste o ClientSize:
        // this.ClientSize = new Size(larguraAtual, alturaAtual + 24); // +24 para o menu

        // ===================================================================
        // ALTERNATIVA MAIS SIMPLES - SE PREFERIR UM PAINEL NO TOPO
        // ===================================================================

        private void CriarBarraSuperior()
        {
            // Painel Superior
            Panel panelTopo = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(this.ClientSize.Width, 50),
                BackColor = Color.FromArgb(0, 122, 204),
                Dock = DockStyle.Top
            };

            // Label Usuário
            Label lblUsuario = new Label
            {
                Text = $"👤 Usuário: {UsuarioLogado.Nome}",
                Location = new Point(20, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White
            };
            panelTopo.Controls.Add(lblUsuario);

            // Botão Admin (só aparece para administradores)
            if (UsuarioLogado.EhAdministrador)
            {
                Button btnAdmin = new Button
                {
                    Text = "⚙ Gerenciar Usuários",
                    Location = new Point(this.ClientSize.Width - 220, 10),
                    Size = new Size(180, 30),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    BackColor = Color.FromArgb(255, 193, 7),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnAdmin.FlatAppearance.BorderSize = 0;
                btnAdmin.Click += (s, e) =>
                {
                    FrmGerenciarAdministradores frmGerenciar = new FrmGerenciarAdministradores();
                    frmGerenciar.ShowDialog();
                };
                panelTopo.Controls.Add(btnAdmin);
            }

            // Botão Sair
            Button btnSair = new Button
            {
                Text = "🚪 Sair",
                Location = new Point(this.ClientSize.Width - 100, 10),
                Size = new Size(80, 30),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.Click += MenuSair_Click;
            panelTopo.Controls.Add(btnSair);

            this.Controls.Add(panelTopo);
        }

        // Use CriarBarraSuperior() no lugar de CriarMenuAdmin() se preferir esta abordagem

        private void FrmCadVeículos_Load(object sender, EventArgs e)
        {
            cmbCombustivel.Items.Clear();
            cmbCombustivel.Items.Add("Flex");
            cmbCombustivel.Items.Add("Gasolina");
            cmbCombustivel.Items.Add("Etanol");
            cmbCombustivel.Items.Add("Híbrido");

            // Categoria (por tamanho/econômico)
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Econômico");
            cmbCategoria.Items.Add("Compacto");
            cmbCategoria.Items.Add("Sedan");
            cmbCategoria.Items.Add("Premium");

            // Cor
            cmbCor.Items.Clear();
            cmbCor.Items.Add("Branco");
            cmbCor.Items.Add("Preto");
            cmbCor.Items.Add("Prata");
            cmbCor.Items.Add("Cinza");
            cmbCor.Items.Add("Vermelho");
            cmbCor.Items.Add("Azul");
            cmbCor.Items.Add("Outro");

            // Status
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Disponível");
            cmbStatus.Items.Add("Alugado");
            cmbStatus.Items.Add("Manutenção");
            cmbStatus.SelectedIndex = 0; // Padrão: Disponível
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obrigatórios
                if (!ValidarCampos())
                    return;

                // Validar formato da placa
                if (!ValidarPlaca(txtPlaca.Text.Trim()))
                {
                    MessageBox.Show("Formato de placa inválido! Use AAA-9999 ou AAA9A99",
                        "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPlaca.Focus();
                    return;
                }

                // Verificar se placa já existe
                if (PlacaJaExiste(txtPlaca.Text.Trim()))
                {
                    MessageBox.Show("Esta placa já está cadastrada no sistema!",
                        "Placa Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPlaca.Focus();
                    return;
                }

                // Validar ano
                int ano = Convert.ToInt32(txtAno.Text);
                if (ano < 1900 || ano > DateTime.Now.Year + 1)
                {
                    MessageBox.Show($"Ano inválido! Deve estar entre 1900 e {DateTime.Now.Year + 1}",
                        "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAno.Focus();
                    return;
                }

                // Validar valor da diária
                decimal valorDiaria = Convert.ToDecimal(txtValorDiaria.Text);
                if (valorDiaria <= 0)
                {
                    MessageBox.Show("O valor da diária deve ser maior que zero!",
                        "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValorDiaria.Focus();
                    return;
                }

                // Cadastrar veículo
                CadastrarVeiculo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, verifique se os valores numéricos estão corretos!",
                    "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar veículo: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("O campo Modelo é obrigatório!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("O campo Marca é obrigatório!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("O campo Placa é obrigatório!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlaca.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("O campo Ano é obrigatório!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAno.Focus();
                return false;
            }

            if (cmbCombustivel.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo de combustível!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCombustivel.Focus();
                return false;
            }

            if (cmbCor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a cor do veículo!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCor.Focus();
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a categoria do veículo!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtValorDiaria.Text))
            {
                MessageBox.Show("O campo Valor da Diária é obrigatório!",
                    "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorDiaria.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarPlaca(string placa)
        {
            // Remove hífen se existir
            placa = placa.Replace("-", "").ToUpper();

            // Formato antigo: AAA9999 (3 letras + 4 números)
            bool formatoAntigo = placa.Length == 7 &&
                                 char.IsLetter(placa[0]) &&
                                 char.IsLetter(placa[1]) &&
                                 char.IsLetter(placa[2]) &&
                                 char.IsDigit(placa[3]) &&
                                 char.IsDigit(placa[4]) &&
                                 char.IsDigit(placa[5]) &&
                                 char.IsDigit(placa[6]);

            // Formato Mercosul: AAA9A99 (3 letras + 1 número + 1 letra + 2 números)
            bool formatoMercosul = placa.Length == 7 &&
                                   char.IsLetter(placa[0]) &&
                                   char.IsLetter(placa[1]) &&
                                   char.IsLetter(placa[2]) &&
                                   char.IsDigit(placa[3]) &&
                                   char.IsLetter(placa[4]) &&
                                   char.IsDigit(placa[5]) &&
                                   char.IsDigit(placa[6]);

            return formatoAntigo || formatoMercosul;
        }

        private bool PlacaJaExiste(string placa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Veiculos WHERE Placa = @Placa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Placa", placa.ToUpper());

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void CadastrarVeiculo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Cadastra com todos os campos incluindo Cor e Categoria
                string query = @"INSERT INTO Veiculos 
                                (Modelo, Marca, Placa, Ano, Combustivel, Cor, Categoria, ValorDiaria, Status) 
                                VALUES 
                                (@Modelo, @Marca, @Placa, @Ano, @Combustivel, @Cor, @Categoria, @ValorDiaria, @Status)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Modelo", txtModelo.Text.Trim());
                cmd.Parameters.AddWithValue("@Marca", txtMarca.Text.Trim());
                cmd.Parameters.AddWithValue("@Placa", txtPlaca.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Ano", Convert.ToInt32(txtAno.Text));
                cmd.Parameters.AddWithValue("@Combustivel", cmbCombustivel.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Cor", cmbCor.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Categoria", cmbCategoria.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ValorDiaria", Convert.ToDecimal(txtValorDiaria.Text));
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Carro de passeio cadastrado com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtModelo.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtAno.Clear();
            txtValorDiaria.Clear();
            cmbCombustivel.SelectedIndex = -1;
            cmbCor.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;
            txtModelo.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Formatação automática da placa
        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtPlaca.SelectionStart;
            txtPlaca.Text = txtPlaca.Text.ToUpper();
            txtPlaca.SelectionStart = cursorPosition;
        }

        // Permitir apenas números no campo Ano
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Formatação do campo ValorDiaria
        private void txtValorDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txtValorDiaria.Text.Contains(",") || txtValorDiaria.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
