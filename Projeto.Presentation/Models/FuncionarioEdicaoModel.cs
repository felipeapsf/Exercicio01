﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Models
{
    public class FuncionarioEdicaoModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int IdFuncionario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public DateTime DataAdmissao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cargo { get; set; }
    }
}
