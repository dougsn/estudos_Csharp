﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDespesas.Models
{
    public class TipoDespesas
    {
        public int TipoDespesaId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength( 50 ,ErrorMessage = "Use menos caracteres.")]
        [Remote("TipoDespesaExiste", "TipoDespesas")]
        public string Nome { get; set; }
        public ICollection<Despesas> Despesas{ get; set; }
    }
}
