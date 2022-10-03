﻿using System.ComponentModel.DataAnnotations;

namespace GerenciadorDespesas.Models
{
    public class Despesas
    {
        public int DespesaId { get; set; }
        public int MesId { get; set; }
        public Meses Meses { get; set; }

        public int TipoDespesaId { get; set; }
        public TipoDespesas TipoDespesas { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor inválido.")]
        public double Valor { get; set; }
    }
}
