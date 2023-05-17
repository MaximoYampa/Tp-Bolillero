namespace BolilleroApp.core;

public class Simulacion
{
    long SimulacionSinHilos(Bolillero copia, List<int> Jugada, int CantidadDeSimulaciones)

        => copia.JugarNVeces(Jugada, CantidadDeSimulaciones);

}
