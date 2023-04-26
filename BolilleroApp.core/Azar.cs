namespace BolilleroApp.core;
public class Azar: IAzar
{
    private Random _random { get; set; }
    public Azar()
        => _random = new Random(DateTime.Now.Millisecond);
    public int SacarIndice(List<int> numeros)
        => _random.Next(0, numeros.Count);
    
}

