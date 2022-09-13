using System;
using System.Collections.Generic;
using System.Text;

namespace AppCustoViagem.Model
{
    public class Pedagio
    {
        string _localizacao;
        double _valor;

        public string Localizacao
        {
            get => _localizacao;
            set
            {
                if (value == null)
                    throw new Exception("Informe a localização");

                _localizacao = value;
            }
        }

        public double Valor
        {
            get => _valor;
            set
            {
                if (value == 0)
                    throw new Exception("Informe o valor");

                _valor = value;
            }
        }
    }
}
