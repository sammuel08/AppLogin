using AppLogin.Models;
using X.PagedList;

namespace AppLogin.Repository.Contract
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string Email, string Senha);

        //CRUD

        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        void AtualizarSenha(Colaborador colaborador);
        void Excluir(int id);

        Colaborador ObterColaborardor(int id);

        List<Colaborador> ObterTodosColaboradorPorEmail(string email);
        IEnumerable<Colaborador> ObterTodosColaboradores();
       IPagedList<Colaborador> ObterTodosColaboradores(int? pagina);
    }
}
