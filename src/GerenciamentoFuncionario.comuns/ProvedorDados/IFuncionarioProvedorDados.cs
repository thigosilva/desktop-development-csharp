using GerenciamentoFuncionario.comuns.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.comuns.ProvedorDados
{
    public interface IFuncionarioProvedorDados
    {
        IEnumerable<Funcionario> CarregaFuncionarios();
        void SalvaFuncionario(Funcionario funcionario);
        IEnumerable<Cargo> CarregaCargos();
    }
}
