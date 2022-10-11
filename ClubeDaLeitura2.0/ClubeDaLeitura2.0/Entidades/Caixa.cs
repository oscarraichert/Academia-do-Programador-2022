using System;

namespace ClubeDaLeitura2._0
{
    public class Caixa
    {
        public string Cor { get; set; }
        public string Etiqueta { get; set; }
        public string Numero { get; set; }

        public Caixa(string cor, string etiqueta, string numero)
        {
            Cor = cor;
            Etiqueta = etiqueta;
            Numero = numero;
        }

        public Caixa()
        {

        }

        public override string ToString()
        {
            return $"Cor: {Cor}" +
                $"\nEtiqueta: {Etiqueta}";
        }
    }
}