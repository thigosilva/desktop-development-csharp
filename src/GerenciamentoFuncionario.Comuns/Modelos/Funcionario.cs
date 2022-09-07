﻿using System;
using System.Linq;

namespace GerenciamentoFuncionario.Comuns.Modelos
{
    public class Funcionario : EntidadeBase
    {

        public Funcionario(string nomeCompleto, int cargoId,
            bool eBebedorCafe = false)
        {
            //Id = id;
            NomeCompleto = nomeCompleto;
            CargoId = cargoId;
            EBebedorCafe = eBebedorCafe;
            DataEntrada = DateTime.Now;
        }

        private string _nomeCompleto;

        public string NomeCompleto
        {
            get { return _nomeCompleto; }
            set
            {
                string[] pedacosNome = value.Trim().Split(" ");
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

        public void SetCargoId(int cargoId)
        {
            if (cargoId < 1)
                throw new Exception("Cargo invalido");
            CargoId = cargoId;
        }
        public void SetBebedorCafe (bool eBebedordeCafe) => EBebedorCafe = eBebedordeCafe;
        public void EBebedordeCafe() => EBebedorCafe = true;
        public void NaoEBebedordeCafe() => EBebedorCafe = false;

    }
}
