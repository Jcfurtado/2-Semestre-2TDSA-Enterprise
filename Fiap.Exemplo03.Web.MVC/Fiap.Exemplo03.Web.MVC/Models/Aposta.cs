using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.Web.MVC.Models
{
    public class Aposta
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public bool Dobradinha { get; set; }
        public DateTime DataAposta { get; set; }
    }
}