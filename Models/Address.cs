using System.ComponentModel.DataAnnotations.Schema;

namespace MyAddress.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int Client { get; set; } //Relacionamento com a tabela clients

        [Column(TypeName = "boolean")]
        public bool IsCommercial { get; set; } //True(1) caso seja comercial

        [Column(TypeName = "varchar(8)")]
        public string Cep { get; set; } //Não deve ser int devido a existencia de 0 a esquerda

        [Column(TypeName = "varchar(10)")]
        public string City { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string State { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Street { get; set; }

        [Column(TypeName = "varchar(8)")]
        public string Number  { get; set; } // pode possuir endereços S/n "Sem número"

        [Column(TypeName = "varchar(30)")]
        public string Complement { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string District { get; set; }

    }

}