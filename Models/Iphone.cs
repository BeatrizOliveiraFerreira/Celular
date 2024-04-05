using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string modelo, double tamanhoTela) : base(modelo, "iPhone", tamanhoTela)
        {
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando aplicativo {nomeAplicativo} pela App Store da Apple.");
        }
    }
}
