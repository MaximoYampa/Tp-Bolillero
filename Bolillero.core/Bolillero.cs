namespace Bolillero.core;
public class Bolillero
{
    public List<int> Adentro { get; set; }
    public List<int> Jugada { get; set; }
    public List<int> Afuera { get; set; }

    public IAzar Azar { get; set; }

    public Bolillero(IAzar azar)
    {
        this.Adentro = new List<int>();
        this.Jugada = new List<int>();
        this.Afuera = new List<int>();
        this.Azar = azar;
    }

    public int SacarBolillas()
    {
        var indice = Azar.SacarIndice(this.Adentro);
        var elemento = Adentro[indice];

        this.Afuera.Add(elemento);
        this.Adentro.RemoveAt(elemento);

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
