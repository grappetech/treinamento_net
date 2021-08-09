using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreinaWeb.Models
{
    public class Tasks
    {
        private bool finalizado;
        [Key]
        public int Id { get; set; }
        [MaxLength(100), 
            Required(AllowEmptyStrings = false, ErrorMessage = "Campo Título é obrigatório.")]
        public string Titulo { get; set; }
        [MaxLength(200)]
        public string Reponsavel { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public DateTime? Prazo { get; set; }
        public DateTime? FinalizadoEm { get; protected set; }
        [MaxLength(int.MaxValue)]
        public string Descricao { get; set; }
        public int Prioridade { get; set; } = 1;
        public bool Finalizado { 
            get => finalizado; 
            set { 
                finalizado = value;
                if (value)
                    FinalizadoEm = DateTime.Now;
                else
                    FinalizadoEm = null;
            } 
        }
    }
}