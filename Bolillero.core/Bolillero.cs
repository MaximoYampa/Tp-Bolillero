namespace Bolillero.core;
public class Bolillero
{
    public List<int> Numeros { get; set; }
    public List<int> Jugada { get; set; }
    public List<int> BolillasJugadas { get; set; }

    public IAzar Azar {get;set;}

    public Bolillero()
    {
        this.Numeros = new List<int>();
        this.Jugada = new List<int>();
        this.BolillasJugadas = new List<int>();
    }

    public int SacarBolillas()
    { 
        var indice = Azar.SacarIndice(this.Numeros);

        this.Numeros.Remove(indice);
        this.Numeros.Add(indice);
    }

    public bool Jugar(List<int> jugada)
    {
    }

    public int JugarNVeces(List<int> Jugada, int cantidad)
    {
        var Victoria = 0;

        Jugar(Jugada);

        return Victoria;
    }

}
