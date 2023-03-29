using System;
using System.ComponentModel.DataAnnotations;

namespace BSIStore.Models
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string CPF {get; set;}
        [DataType(DataType.Date)]
        public DateTime DtNasc {get; set;}
        public string Email {get; set;}
    }

}