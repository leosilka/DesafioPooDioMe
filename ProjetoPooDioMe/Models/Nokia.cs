namespace ProjetoPooDioMe.Models;

public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Baixa a App Store para baixar o aplicativo {nomeApp}!");
    }

    public override void ReceberLigacao()
    {
        base.ReceberLigacao();
    }

    public override void Ligar()
    {
        base.Ligar();
    }
}
