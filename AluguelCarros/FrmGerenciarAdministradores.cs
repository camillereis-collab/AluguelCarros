using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using AluguelCarros;

namespace SistemaVeiculos
{
    public partial class FrmGerenciarAdministradores : Form
    {
        private DataGridView dgvUsuarios;
        private Button btnPromover;
        private Button btnRebaixar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnFechar;
        private Label lblTitulo;
        private Label lblInfo;
        private Panel panelTopo;
        private Panel panelBotoes;
        private ComboBox cmbFiltro;

        public FrmGerenciarAdministradores()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CarregarUsuarios();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Configurações do Form
            this.ClientSize = new Size(900, 600);
            this.Text = "Gerenciar Administradores";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 240, 240);

            // Panel Topo
            panelTopo = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(900, 100),
                BackColor = Color.FromArgb(0, 122, 204)
            };
            this.Controls.Add(panelTopo);

            // Label Título
            lblTitulo = new Label
            {
                Text = "Gerenciamento de Administradores",
                Location = new Point(20, 25),
                Size = new Size(860, 30),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White
            };
            panelTopo.Controls.Add(lblTitulo);

            // Label Info
            lblInfo = new Label
            {
                Text = "Gerencie os usuários e suas permissões de administrador",
                Location = new Point(20, 60),
                Size = new Size(860, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White
            };
            panelTopo.Controls.Add(lblInfo);

            // ComboBox Filtro
            Label lblFiltro = new Label
            {
                Text = "Filtrar por tipo:",
                Location = new Point(20, 120),
                Size = new Size(100, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            this.Controls.Add(lblFiltro);

            cmbFiltro = new ComboBox
            {
                Location = new Point(130, 118),
                Size = new Size(150, 25),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFiltro.Items.AddRange(new string[] { "Todos", "Administradores", "Usuários" });
            cmbFiltro.SelectedIndex = 0;
            cmbFiltro.SelectedIndexChanged += CmbFiltro_SelectedIndexChanged;
            this.Controls.Add(cmbFiltro);

            // DataGridView
            dgvUsuarios = new DataGridView
            {
                Location = new Point(20, 155),
                Size = new Size(860, 330),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                Font = new Font("Segoe UI", 9)
            };

            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersHeight = 35;
            dgvUsuarios.EnableHeadersVisualStyles = false;

            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;

            this.Controls.Add(dgvUsuarios);

            // Panel Botões
            panelBotoes = new Panel
            {
                Location = new Point(20, 500),
                Size = new Size(860, 80),
                BackColor = Color.White
            };
            this.Controls.Add(panelBotoes);

            // Botão Promover
            btnPromover = new Button
            {
                Text = "Promover para Admin",
                Location = new Point(20, 20),
                Size = new Size(165, 40),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnPromover.FlatAppearance.BorderSize = 0;
            btnPromover.Click += BtnPromover_Click;
            panelBotoes.Controls.Add(btnPromover);

            // Botão Rebaixar
            btnRebaixar = new Button
            {
                Text = "Rebaixar para Usuário",
                Location = new Point(200, 20),
                Size = new Size(165, 40),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 193, 7),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnRebaixar.FlatAppearance.BorderSize = 0;
            btnRebaixar.Click += BtnRebaixar_Click;
            panelBotoes.Controls.Add(btnRebaixar);

            // Botão Excluir
            btnExcluir = new Button
            {
                Text = "Excluir Usuário",
                Location = new Point(380, 20),
                Size = new Size(140, 40),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.Click += BtnExcluir_Click;
            panelBotoes.Controls.Add(btnExcluir);

            // Botão Atualizar
            btnAtualizar = new Button
            {
                Text = "Atualizar",
                Location = new Point(535, 20),
                Size = new Size(120, 40),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.Click += BtnAtualizar_Click;
            panelBotoes.Controls.Add(btnAtualizar);

            // Botão Fechar
            btnFechar = new Button
            {
                Text = "Fechar",
                Location = new Point(670, 20),
                Size = new Size(120, 40),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.Click += BtnFechar_Click;
            panelBotoes.Controls.Add(btnFechar);

            this.ResumeLayout(false);
        }

        private void ConfigurarFormulario()
        {
            // Efeitos hover nos botões
            btnPromover.MouseEnter += (s, e) => btnPromover.BackColor = Color.FromArgb(33, 136, 56);
            btnPromover.MouseLeave += (s, e) => btnPromover.BackColor = Color.FromArgb(40, 167, 69);

            btnRebaixar.MouseEnter += (s, e) => btnRebaixar.BackColor = Color.FromArgb(222, 170, 12);
            btnRebaixar.MouseLeave += (s, e) => btnRebaixar.BackColor = Color.FromArgb(255, 193, 7);

            btnExcluir.MouseEnter += (s, e) => btnExcluir.BackColor = Color.FromArgb(200, 35, 51);
            btnExcluir.MouseLeave += (s, e) => btnExcluir.BackColor = Color.FromArgb(220, 53, 69);

            btnAtualizar.MouseEnter += (s, e) => btnAtualizar.BackColor = Color.FromArgb(0, 102, 184);
            btnAtualizar.MouseLeave += (s, e) => btnAtualizar.BackColor = Color.FromArgb(0, 122, 204);

            btnFechar.MouseEnter += (s, e) => btnFechar.BackColor = Color.FromArgb(90, 98, 104);
            btnFechar.MouseLeave += (s, e) => btnFechar.BackColor = Color.FromArgb(108, 117, 125);
        }

        private void CarregarUsuarios(string filtro = "Todos")
        {
            try
            {
                using (SqlConnection conn = Utilitarios.ObterConexao())
                {
                    string query = @"SELECT 
                                        IdUsuario as 'ID',
                                        Usuario as 'Usuário',
                                        Email as 'E-mail',
                                        TipoUsuario as 'Tipo',
                                        CONVERT(VARCHAR, DataCriacao, 103) as 'Data Criação'
                                    FROM Usuarios";

                    if (filtro == "Administradores")
                        query += " WHERE TipoUsuario = 'Administrador'";
                    else if (filtro == "Usuários")
                        query += " WHERE TipoUsuario = 'Usuario'";

                    query += " ORDER BY TipoUsuario DESC, Usuario";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsuarios.DataSource = dt;

                    // Ajustar largura das colunas
                    if (dgvUsuarios.Columns.Count > 0)
                    {
                        dgvUsuarios.Columns["ID"].Width = 60;
                        dgvUsuarios.Columns["Usuário"].Width = 180;
                        dgvUsuarios.Columns["E-mail"].Width = 250;
                        dgvUsuarios.Columns["Tipo"].Width = 130;
                        dgvUsuarios.Columns["Data Criação"].Width = 120;
                    }

                    // Colorir linhas de administradores
                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (row.Cells["Tipo"].Value.ToString() == "Administrador")
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(133, 100, 4);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarUsuarios(cmbFiltro.SelectedItem.ToString());
        }

        private void BtnPromover_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para promover.",
                    "Nenhum Usuário Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvUsuarios.SelectedRows[0];
            int idUsuario = Convert.ToInt32(row.Cells["ID"].Value);
            string usuario = row.Cells["Usuário"].Value.ToString();
            string tipoAtual = row.Cells["Tipo"].Value.ToString();

            if (tipoAtual == "Administrador")
            {
                MessageBox.Show("Este usuário já é um administrador.",
                    "Já é Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show($"Deseja promover '{usuario}' para Administrador?",
                "Confirmar Promoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AlterarTipoUsuario(idUsuario, "Administrador");
                CarregarUsuarios(cmbFiltro.SelectedItem.ToString());
            }
        }

        private void BtnRebaixar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um administrador para rebaixar.",
                    "Nenhum Admin Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvUsuarios.SelectedRows[0];
            int idUsuario = Convert.ToInt32(row.Cells["ID"].Value);
            string usuario = row.Cells["Usuário"].Value.ToString();
            string tipoAtual = row.Cells["Tipo"].Value.ToString();

            if (tipoAtual == "Usuario")
            {
                MessageBox.Show("Este usuário não é um administrador.",
                    "Não é Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Impedir que o próprio admin se rebaixe
            if (usuario == UsuarioLogado.Nome)
            {
                MessageBox.Show("Você não pode rebaixar a si mesmo!",
                    "Ação Não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Deseja rebaixar '{usuario}' para Usuário comum?",
                "Confirmar Rebaixamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AlterarTipoUsuario(idUsuario, "Usuario");
                CarregarUsuarios(cmbFiltro.SelectedItem.ToString());
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para excluir.",
                    "Nenhum Usuário Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvUsuarios.SelectedRows[0];
            int idUsuario = Convert.ToInt32(row.Cells["ID"].Value);
            string usuario = row.Cells["Usuário"].Value.ToString();

            // Impedir que o próprio admin se exclua
            if (usuario == UsuarioLogado.Nome)
            {
                MessageBox.Show("Você não pode excluir sua própria conta!",
                    "Ação Não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Tem certeza que deseja excluir o usuário '{usuario}'?\n\nEsta ação não pode ser desfeita!",
                "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ExcluirUsuario(idUsuario);
                CarregarUsuarios(cmbFiltro.SelectedItem.ToString());
            }
        }

        private void AlterarTipoUsuario(int idUsuario, string novoTipo)
        {
            try
            {
                using (SqlConnection conn = Utilitarios.ObterConexao())
                {
                    string query = "UPDATE Usuarios SET TipoUsuario = @TipoUsuario WHERE IdUsuario = @IdUsuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TipoUsuario", novoTipo);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    cmd.ExecuteNonQuery();

                    string acao = novoTipo == "Administrador" ? "promovido" : "rebaixado";
                    MessageBox.Show($"Usuário {acao} com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar tipo de usuário: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection conn = Utilitarios.ObterConexao())
                {
                    string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário excluído com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir usuário: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarUsuarios(cmbFiltro.SelectedItem.ToString());
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}