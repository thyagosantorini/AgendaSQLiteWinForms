using AgendaWinFormsSQLite.Models;
using AgendaWinFormsSQLite.Presenters;
using AgendaWinFormsSQLite.Views;
using System.Data;
using System.Windows.Forms;

namespace AgendaWinFormsSQLite
{
    /// <summary>
    /// Classe concreta da View (Interface Gráfica). 
    /// Esta classe é "passiva", ou seja, ela não possui regras de negócio ou lógica de banco de dados,
    /// ela apenas repassa as interações do usuário para o Presenter.
    /// </summary>
    public partial class Form1 : Form, IContatoView
    {
        private ContatoPresenter _presenter;

        public Form1()
        {
            InitializeComponent();

            // 1. Garante que o banco e as tabelas existam antes de qualquer operação
            DALAgenda.CriarBancoSQLite();
            DALAgenda.CriarTabelaSQLite();

            // 2. Instancia o Presenter e passa esta própria tela (this) para ele controlar
            _presenter = new ContatoPresenter(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ao iniciar o formulário, garante que o banco de dados e a tabela existam.
            // Em seguida, carrega os dados salvos no DataGridView.
            DALAgenda.CriarBancoSQLite();
            DALAgenda.CriarTabelaSQLite();
            // Exibe o caminho físico do banco de dados na label de status
            lbDados.Text = DALAgenda.path;
        }

        #region Implementação da Interface IContatoView

        // O Presenter acessa estas propriedades, e elas modificam os TextBoxes correspondentes
        public string IdTexto
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        public string NomeTexto
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }

        public string EmailTexto
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        public string TelefoneTexto
        {
            get { return txtTel.Text; }
            set { txtTel.Text = value; }
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTel.Clear();
        }

        public void AtualizarGrid(object dados)
        {
            dgvDados.DataSource = dados;
        }

        #endregion

        // Eventos de Clique (Delegados ao Presenter

        private void btInserir_Click(object sender, EventArgs e)
        {
            _presenter.InserirContato();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            _presenter.AlterarContato();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            _presenter.ExcluirContato();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            _presenter.LocalizarContato();
        }
    }
}
