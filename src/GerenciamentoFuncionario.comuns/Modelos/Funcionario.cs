using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.comuns.Modelos
{
    class Funcionario
    {
        public int Id { get; protected set; }
        private string _nomecompleto;

        public int NomeCompleto { get; protected set; }

        public int CargoId { get; protected set; }
        public int EBeberdorCafe { get; protected set; }
        public int PrimeiroNome { get; protected set; }
        public int UltimoNome { get; protected set; }
        public DateTimeOffset DataEntrada { get; protected set; }        

    }
}
