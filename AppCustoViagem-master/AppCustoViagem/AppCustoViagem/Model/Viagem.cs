using System;
using System.Collections.Generic;
using System.Text;

namespace AppCustoViagem.Model
{
    public class Viagem
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public double Destino { get; set; }
        public double Consumo { get; set; }
        public double Preco_Combustivel { get; set; }
    }
}
