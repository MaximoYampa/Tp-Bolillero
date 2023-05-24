using BolilleroApp.core;

namespace BolilleroAppTest
{
    public class SimulacionTest
    {
    public Bolillero BolilleroSimulacion { get; set; }
    public Simulacion SimulacionBolillero { get; set; }
    public SimulacionTest()
    {
        BolilleroSimulacion = new Bolillero(new AzarPrimero(),10);
        SimulacionBolillero = new Simulacion();
    }

    [Fact]
    public void SimularSinHilostest()
    {
        var copiaBolillero = BolilleroSimulacion.Clonar();
        var simulacion = SimulacionBolillero.SimularSinHilos(copiaBolillero, 1, jugada: new List<int> { 0, 1 });

        Assert.Equal(1, simulacion);
    }

    [Fact]
    public void SimularConHilosTest()
    {
        var cantidadHilos = 6;
        var simulaciones = 5_000;
        var resultado = SimulacionBolillero.SimularConHilos
            (bolillero: BolilleroSimulacion, cantSimulaciones: simulaciones, jugada: new List<int> { 0, 1 }, hilos: cantidadHilos);

        Assert.Equal(cantidadHilos, resultado);
    }
}

}