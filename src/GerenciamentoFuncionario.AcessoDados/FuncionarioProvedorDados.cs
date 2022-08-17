using GerenciamentoFuncionario.comuns.Modelos;
using GerenciamentoFuncionario.comuns.ProvedorDados;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        public void AtualizaCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void AtualizaFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cargo> CarregaCargos()
        {
            return new List<Cargo>
            {
                new Cargo(1, "Desenvolvedor"),
                new Cargo(2, "Engenheiro"),
                new Cargo(2, "Arquiteto"),
                new Cargo(2, "Gerente de Projeto"),
            };
        }

        public IEnumerable<Funcionario> CarregaFuncionarios()
        {
            return new List<Funcionario> { 
                new Funcionario(1, "Thiago de tal", 1, false),
                new Funcionario(2, "Renne de tal", 2, true),
                new Funcionario(3, "Paroma de tal", 3, true),
            };
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public void ExcluirCargo(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Cargo RecuperaCargoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Funcionario RecuperaFuncionarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void SalvaCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void SalvaFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

    }
}
