using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System;
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
                    f.SetCargoId(funcionario.CargoId);
                    f.SetBebedorCafe(funcionario.EBebedorCafe);
                    

                }
            });
        }

        public void ExcluiFuncionarioPorId(int v)
        {
            throw new NotImplementedException();
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
            //Debug.WriteLine($"Funcionário salvo: {funcionario.PrimeiroNome}");
            var id = GeradorDeId();
            _Contexto.Funcionarios.Add(funcionario);
        }

        private object GeradorDeId()
        {
            var maiorId = _Contexto.Funcionarios.Max(x => x.Id);                                                                                           //max devolve so a maior.
            
            bool temId;
            do
            {
                maiorId++;
                temId = _Contexto.Funcionarios.Any(x => x.Id.Equals(maiorId));
                //temId = _Contexto.Funcionarios.Any(x => x.Id.Equals(maiorId));
            } while (temId);

            return maiorId;
        }

        public IEnumerable<Funcionario> CarregaFuncionarios()
        {
            return _Contexto.Funcionarios;
        }
    }
}
