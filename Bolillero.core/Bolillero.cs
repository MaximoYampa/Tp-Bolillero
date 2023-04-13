namespace Bolillero.core;
public class Bolillero
{
    public List<int> BolillasNoJugadas { get; set; }
    public List<int> Jugada { get; set; }
    public List<int> BolillasJugadas { get; set; }

    public IAzar Azar { get; set; }

    public Bolillero()
    {
        this.BolillasNoJugadas = new List<int>();
        this.Jugada = new List<int>();
        this.BolillasJugadas = new List<int>();
    }

    public int SacarBolillas()
    {
        var indice = Azar.SacarIndice(this.BolillasNoJugadas);

        this.BolillasJugadas.Remove(indice);
        this.BolillasNoJugadas.Add(indice);
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
