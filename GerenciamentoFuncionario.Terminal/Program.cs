using GerenciamentoFuncionario.AcessoDados;
using System;

namespace GerenciamentoFuncionario.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var provedorFuncionario = new FuncionarioProvedorDados();
            // É uma lista
            var funcionarios = provedorFuncionario.CarregaFuncionarios();

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Id} {funcionario.NomeCompleto}");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
            Console.Clear();
            //Console.WriteLine("Hello World!");

            var funcionarioSelecionado = provedorFuncionario.RecuperaFuncionarioPorId(3);
        }
    }
}
