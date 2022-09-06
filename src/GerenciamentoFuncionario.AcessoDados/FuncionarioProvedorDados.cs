using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        private readonly Contexto _Contexto;

        public FuncionarioProvedorDados()
        {
            _Contexto = new Contexto();
        }
        

        public void AtualizaFuncionario(Funcionario funcionario)
        {
            _Contexto.Funcionarios.ForEach(f =>
            {
                if(f.Id == funcionario.Id)
                {
                    f.NomeCompleto = funcionario.NomeCompleto;
                }
            });
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            _Contexto.Funcionarios.Remove(funcionario);
        }

        public Funcionario RecuperaFuncionarioPorId(int id)
        {

            //pesquisa na lista inteira.
            //return _Contexto.Funcionarios.Find(x => x.Id == id);
            
            //pesquisa mais expecifica.
            //return _Contexto.Funcionarios.FirstOrDefault(X => x.Id == id);
            
            //pesquisa do jeito que quer.
            return _Contexto.Funcionarios.Where(x => x.Id == id).FirstOrDefault();
        }

        public void SalvaFuncionario(Funcionario funcionario)
        {
            Debug.WriteLine($"Funcionário salvo: {funcionario.PrimeiroNome}");
        }

        public IEnumerable<Funcionario> CarregaFuncionarios()
        {
            return _Contexto.Funcionarios;
        }
    }
}
