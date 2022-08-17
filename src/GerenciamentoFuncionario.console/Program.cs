using GerenciamentoFuncionario.AcessoDados;
//using System;

namespace GerenciamentoFuncionario.console
{
    class Program
    {
        static void Main()
        {
            var provedor = new FuncionarioProvedorDados();
            var cargos = provedor.CarregaCargos();
            var funciona = provedor.CarregaFuncionarios();

            //System.Console.WriteLine("Hello World!");
        }
    }
}
