namespace CarCenter.Models
{
    public class Nota
    {
        public int ID { get; set; }
        public int Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public bool Garantia { get; set; }
        public decimal ValorVenda { get; set; }

       
        public int CompradorId { get; set; }
        public Cliente Comprador { get; set; }

        
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

        
        public int CarroId { get; set; }
        public Carro Carro { get; set; }
    }
}
