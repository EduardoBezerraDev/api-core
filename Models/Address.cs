using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAddress.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int Client { get; set; } //Relacionamento com a tabela clients

        public int IsCommercial { get; set; } //True(1) caso seja comercial


        [Column(TypeName = "nvarchar(8)")]
        [Required]
        public string Cep { get; set; } //Não deve ser int devido a existencia de 0 a esquerda


        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string City { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(2)")]
        public string State { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Street { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(8)")]
        public string Number  { get; set; } // pode possuir endereços S/n "Sem número"

        [Column(TypeName = "nvarchar(30)")]
        public string Complement { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string District { get; set; }

    }

}