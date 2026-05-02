using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWinFormsSQLite.Views
{
    /// <summary>
    /// Contrato da View no padrão MVP. 
    /// Define todas as propriedades e ações que qualquer interface gráfica (formulário) 
    /// precisa ter para interagir com o ContatoPresenter.
    /// </summary>
    public interface IContatoView
    {
        // Propriedades expostas para o Presenter ler ou alterar os dados da tela
        string IdTexto { get; set; }
        string NomeTexto { get; set; }
        string EmailTexto { get; set; }
        string TelefoneTexto { get; set; }

        // Exibe uma notificação ou alerta para o usuário.
        void ExibirMensagem(string mensagem);

        // Limpa todos os campos de entrada de dados da tela.
        void LimparCampos();

        // Atualiza o componente visual de tabela (Grid) com os dados fornecidos.
        void AtualizarGrid(object dados);
    }
}
