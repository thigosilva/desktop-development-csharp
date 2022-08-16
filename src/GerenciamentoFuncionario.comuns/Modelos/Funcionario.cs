using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GerenciamentoFuncionario.comuns.Modelos
{
    public class Funcionario : EntidadeBase

    {
        public Funcionario(int id, string nomeCompleto, int cargoId,
            bool eBebedorCafe)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            CargoId = cargoId;
            EBebedorCafe = eBebedorCafe;
            DataEntrada = DateTime.Now;

        }

        public int Id { get; protected set; }
        private string _nomeCompleto;

        public string NomeCompleto
        {
            get { return _nomeCompleto; }
            set
            {
                var pedacosNome = value.Trim().Split(" ");
                PrimeiroNome = pedacosNome[0];
                UltimoNome = pedacosNome.Last();
                _nomeCompleto = value;
            }
        }

        public int CargoId { get; protected set; }
        public bool EBebedorCafe { get; protected set; }
        public string PrimeiroNome { get; protected set; }
        public string UltimoNome { get; protected set; }
        public DateTimeOffset DataEntrada { get; protected set; }
    }
}
