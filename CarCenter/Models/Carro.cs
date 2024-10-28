namespace CarCenter.Models
{
    public class Carro
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string Chassi { get; set; }
        public decimal Preco { get; set; }
    }
}
