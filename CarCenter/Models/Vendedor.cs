namespace CarCenter.Models
{
    public class Vendedor
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }

        public decimal CalcularComissao()
        {
            
            return 0;
        }
    }
}
