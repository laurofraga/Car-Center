﻿namespace CarCenter.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }
    }
}
