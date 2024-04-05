using System;

// Classe abstrata para representar um smartphone genérico
public abstract class Smartphone
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public double TamanhoTela { get; set; }

    // Método abstrato que será sobrescrito nas subclasses
    public abstract void InstalarAplicativo(string nomeAplicativo);

    protected Smartphone(string modelo, string marca, double tamanhoTela)
    {
        Modelo = modelo;
        Marca = marca;
        TamanhoTela = tamanhoTela;
    }

    // Método genérico para realizar uma chamada
    public void FazerChamada(string numero)
    {
        Console.WriteLine($"Fazendo chamada para o número: {numero}");
    }

    // Método genérico para enviar uma mensagem de texto
    public void EnviarMensagem(string numero, string mensagem)
    {
        Console.WriteLine($"Enviando mensagem para o número: {numero}");
        Console.WriteLine($"Mensagem: {mensagem}");
    }
}

// Classe para representar um smartphone da marca Nokia
public class Nokia : Smartphone
{
    public Nokia(string modelo, double tamanhoTela) : base(modelo, "Nokia", tamanhoTela)
    {
    }

    // Sobrescreve o método InstalarAplicativo para adicionar comportamento específico
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando aplicativo {nomeAplicativo} pela loja de aplicativos da Nokia.");
    }
}

// Classe para representar um smartphone da marca iPhone
public class IPhone : Smartphone
{
    public IPhone(string modelo, double tamanhoTela) : base(modelo, "iPhone", tamanhoTela)
    {
    }

    // Sobrescreve o método InstalarAplicativo para adicionar comportamento específico
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando aplicativo {nomeAplicativo} pela App Store da Apple.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Smartphone nokia = new Nokia("Nokia 3310", 2.4);
        nokia.FazerChamada("123456789");
        nokia.EnviarMensagem("987654321", "Olá, mundo!");
        nokia.InstalarAplicativo("WhatsApp");

        // Testando a classe iPhone
        Smartphone iphone = new IPhone("iPhone 12", 6.1);
        iphone.FazerChamada("987654321");
        iphone.EnviarMensagem("123456789", "Hello!");
        iphone.InstalarAplicativo("Instagram");
    }
}
