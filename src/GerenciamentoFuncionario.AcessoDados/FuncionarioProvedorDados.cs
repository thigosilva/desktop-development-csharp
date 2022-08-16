using GerenciamentoFuncionario.comuns.Modelos;
using GerenciamentoFuncionario.comuns.ProvedorDados;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        public IEnumerable<Cargo> CarregaCargos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Funcionario> CarregaFuncionarios()
        {
            throw new NotImplementedException();
        }

        public void SalvaFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
