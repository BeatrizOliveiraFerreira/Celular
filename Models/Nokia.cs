using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string modelo, double tamanhoTela) : base(modelo, "Nokia", tamanhoTela)
        {
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando aplicativo {nomeAplicativo} pela loja de aplicativos da Nokia.");
        }
    }
}
