namespace ProjetoPooDioMe.Models;

public abstract class Smartphone
{
    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        // TODO: Passar os parâmetros do construtor para as propriedades
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    public string Numero { get; set; }
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama
    private string Modelo { get; }

    private string Imei { get; }

    private int Memoria { get; }


    public virtual void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public virtual void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
}
