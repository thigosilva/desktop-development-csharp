using GerenciamentoFuncionario.comuns.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.comuns.ProvedorDados
{
    public interface IFuncionarioProvedorDados
    {
        IEnumerable<Funcionario> CarregaFuncionarios();
        IEnumerable<Cargo> CarregaCargos();

        Cargo RecuperaCargoPorId(int id);
        Funcionario RecuperaFuncionarioPorId(int id);

        void SalvaFuncionario(Funcionario funcionario);
        void SalvaCargo(Cargo cargo);

        void AtualizaCargo(Cargo cargo);
        void AtualizaFuncionario(Funcionario funcionario);

        void ExcluirCargo(Funcionario funcionario);
        void ExcluiFuncionario(Funcionario funcionario);


        
    }
}
