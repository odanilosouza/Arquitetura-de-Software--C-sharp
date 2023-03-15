using System;
using System.ComponentModel.DataAnnotations;

namespace BSIStore.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Descricao {get; set;}
        [DataType(DataType.Date)]
        public DateTime validade {get; set;}
        public string categoria {get; set;}       
        public double preco {get; set;}
    }
}