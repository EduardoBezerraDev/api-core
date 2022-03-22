namespace MyAddress.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int Client { get; set; } //Relacionamento com a tabela clients
        public bool IsCommercial { get; set; } //True(1) caso seja comercial
        public string Cep { get; set; } //Não deve ser int devido a existencia de 0 a esquerda
        public string Street { get; set; }
        public string Number  { get; set; } // pode possuir endereços S/n "Sem número"
        public string Complement { get; set; }
        public string District { get; set; }
    }

}