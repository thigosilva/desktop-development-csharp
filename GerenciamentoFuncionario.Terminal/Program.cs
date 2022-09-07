using GerenciamentoFuncionario.AcessoDados;
using GerenciamentoFuncionario.Comuns.Modelos;
using System;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Terminal
{
    class Program
    {
        static void Main()
        {
            var provedorFuncionario = new FuncionarioProvedorDados();

            var funcionarios = provedorFuncionario.CarregaFuncionarios();
            ApresentaFuncionarios(funcionarios);
            //Console.WriteLine("Hello World!");

            //Criar Funcionarios.

            provedorFuncionario.SalvaFuncionario(new Funcionario("Fulano de Tal", 1, false));
            provedorFuncionario.SalvaFuncionario(new Funcionario("Ciclano de Tal", 2, false));
            provedorFuncionario.SalvaFuncionario(new Funcionario("Beltrano de Tal", 3, false));
            
            ApresentaFuncionarios(funcionarios);
            //BUSCA POR ID
            var funcionarioSelecionado = provedorFuncionario.RecuperaFuncionarioPorId(3);

            //EXCLUIR FUNCIONARIO
            provedorFuncionario.ExcluiFuncionario(funcionarioSelecionado);

            ApresentaFunciorios(funcionarios);
            //BUSCA POR ID
            funcionarioSelecionado = provedorFuncionario.RecuperaFuncionarioPorId(2);

            funcionarioSelecionado.NomeCompleto = "bla bla bla";
            funcionarioSelecionado.NaoEBebedordeCafe();
            funcionarioSelecionado.SetCargoId(2);
            provedorFuncionario.AtualizaFuncionario(funcionarioSelecionado);

            ApresentaFunciorios(funcionarios);

        }

        private static void ApresentaFunciorios(IEnumerable<Comuns.Modelos.Funcionario> funcionarios)
        {
            throw new NotImplementedException();
        }

        private static void ApresentaFuncionarios(IEnumerable<Comuns.Modelos.Funcionario> funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Id} {funcionario.NomeCompleto}");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("\n\n");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
