namespace BolilleroAppTest;
using BolilleroApp.core;

public class BolilleroAppTest

{
    public Bolillero Bolillero1 { get; set; }

    public BolilleroAppTest() => Bolillero1 = new Bolillero(new AzarPrimero(), 10);


    [Fact]
    public void SacarBolillaTest()
    {
        var numero = Bolillero1.SacarBolilla();
        var esperado = 0;
        var esperado1 = 9;
        var esperado2 = 1;

        Assert.Equal(esperado, numero);
        Assert.Equal(esperado1, Bolillero1.Adentro.Count);
        Assert.Equal(esperado2, Bolillero1.Afuera.Count);
    }

    [Fact]
    public void ReingresarBolillaTest()
    {
        Bolillero1.SacarBolilla();
        Bolillero1.ReingresarBolillas();
        
        var bolillasAdentro = Bolillero1.Adentro.Count;

        Assert.Equal(10, bolillasAdentro);
        Assert.Empty(Bolillero1.Afuera);
    }
    [Fact]
    public void JugarGana()
    {
        var intentoGana = Bolillero1.Jugar(Jugada: new List<int>() { 0, 1, 2, 3 });
        Assert.True(intentoGana);
    }

    [Fact]
    public void JugarPierde()
    {
        var intentoPierde = Bolillero1.Jugar(Jugada: new List<int> { 4, 2, 1 });

        Assert.False(intentoPierde);
    }

    [Fact]
    public void JugarNVecesGana()
    {
        var jugada = Bolillero1.JugarNVeces(Jugada: new List<int> { 0, 1 }, 1);

        Assert.Equal(1, jugada);
    }


}