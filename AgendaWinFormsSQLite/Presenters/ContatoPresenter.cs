using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AgendaWinFormsSQLite.Models;
using AgendaWinFormsSQLite.Views;

namespace AgendaWinFormsSQLite.Presenters
{
    /// <summary>
    /// Classe Presenter do padrão MVP. 
    /// Atua como intermediária, contendo toda a regra de negócio. Ela lê os dados da View (IContatoView), 
    /// processa e envia para o Model (DALAgenda) salvar, e vice-versa.
    /// </summary>
    public class ContatoPresenter
    {
        private IContatoView _view; // Referência para a tela

        /// <summary>
        /// Construtor que injeta a dependência da View e inicializa o carregamento dos dados.
        /// </summary>
        public ContatoPresenter(IContatoView view)
        {
            _view = view;
            CarregarDados();
        }

        /// <summary>
        /// Busca todos os contatos no banco de dados e solicita que a View os exiba no grid.
        /// </summary>
        public void CarregarDados()
        {
            try
            {
                DataTable dt = DALAgenda.GetContatos();
                _view.AtualizarGrid(dt); // Manda a View mostrar os dados
            }
            catch (Exception ex)
            {
                _view.ExibirMensagem("Erro ao carregar dados: " + ex.Message);
            }
        }

        /// <summary>
        /// Coleta os dados digitados na View, cria um novo modelo de Contato e envia para persistência.
        /// </summary>
        public void InserirContato()
        {
            try
            {
                // O Presenter lê as propriedades da View, não os TextBoxes!
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(_view.IdTexto);
                contato.Nome = _view.NomeTexto;
                contato.Email = _view.EmailTexto;
                contato.Telefone = _view.TelefoneTexto;

                DALAgenda.Add(contato); // Manda pro Model salvar

                CarregarDados(); // Recarrega o grid
                _view.LimparCampos(); // Manda a View se limpar
                _view.ExibirMensagem("Contato inserido com sucesso!");
            }
            catch (Exception ex)
            {
                _view.ExibirMensagem("Erro ao inserir: " + ex.Message);
            }
        }

        /// <summary>
        /// Atualiza um contato existente no banco de dados usando o ID fornecido pela View.
        /// </summary>
        public void AlterarContato()
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(_view.IdTexto);
                contato.Nome = _view.NomeTexto;
                contato.Email = _view.EmailTexto;
                contato.Telefone = _view.TelefoneTexto;

                DALAgenda.Update(contato);

                CarregarDados();
                _view.LimparCampos();
                _view.ExibirMensagem("Contato alterado com sucesso!");
            }
            catch (Exception ex)
            {
                _view.ExibirMensagem("Erro ao alterar: " + ex.Message);
            }
        }

        /// <summary>
        /// Remove um contato do banco de dados com base no ID fornecido pela View.
        /// </summary>
        public void ExcluirContato()
        {
            try
            {
                int id = Convert.ToInt32(_view.IdTexto);
                DALAgenda.Delete(id);

                CarregarDados();
                _view.LimparCampos();
                _view.ExibirMensagem("Contato excluído com sucesso!");
            }
            catch (Exception ex)
            {
                _view.ExibirMensagem("Erro ao excluir: " + ex.Message);
            }
        }

        /// <summary>
        /// Realiza a busca de um contato específico. Se o ID for informado, busca por ID.
        /// Caso contrário, realiza uma busca parcial pelo Nome.
        /// </summary>
        public void LocalizarContato()
        {
            try
            {
                DataTable dt = new DataTable();

                if (!string.IsNullOrEmpty(_view.IdTexto))
                {
                    int id = Convert.ToInt32(_view.IdTexto);
                    dt = DALAgenda.GetContato(id);
                }
                else
                {
                    string nome = _view.NomeTexto;
                    dt = DALAgenda.GetContatos(nome);
                }

                _view.AtualizarGrid(dt);
                _view.LimparCampos();
            }
            catch (Exception ex)
            {
                _view.ExibirMensagem("Erro ao localizar: " + ex.Message);
            }
        }
    }
}
