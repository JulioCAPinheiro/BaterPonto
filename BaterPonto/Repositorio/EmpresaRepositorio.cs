using BaterPonto.DB;
using BaterPonto.Models;

namespace BaterPonto.Repositorio
{
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public EmpresaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public EmpresModel Adicioar(EmpresModel Empresa)
        {
            _bancoContext.Empresa.Add(Empresa);
            _bancoContext.SaveChanges();
            return Empresa;
        }
    }
}
