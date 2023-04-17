namespace Bolillero.core;
public class Bolillero
{
    public List<int> adentro { get; set; }
    public List<int> Jugada { get; set; }
    public List<int> afuera { get; set; }

    public IAzar Azar { get; set; }

    public Bolillero()
    {
        this.adentro = new List<int>();
        this.Jugada = new List<int>();
        this.afuera = new List<int>();
    }

    public int SacarBolillas()
    {
        var indice = Azar.SacarIndice(this.adentro);
        var elemento = adentro[indice];

        this.afuera.Add(elemento);
        this.adentro.RemoveAt(elemento);

        return indice;
    }

    public bool Jugar(List<int> jugada)

    {
        for(int i=0; i <= jugada.Count() ; i ++);
        {
            SacarBolillas();
        }
        return false;
    }

    public int JugarNVeces(List<int> Jugada, int cantidad)
    {
        var Victoria = 0;

        Jugar(Jugada);

        return Victoria;
    }

}
