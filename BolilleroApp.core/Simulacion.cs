namespace BolilleroApp.core;

public class Simulacion
{
    long SimulacionSinHilos(Bolillero copia, List<int> jugada, int cantidadDeSimulaciones)

        => copia.JugarNVeces(jugada, cantidadDeSimulaciones);


    long SimulacionConHilos(Bolillero copia, List<int> jugada, int cantidadDeSimulaciones, int hilos)

    {
        Task<long>[] Simulaciones = new Task<long>[hilos];
        var division = cantidadDeSimulaciones / hilos;


        for (int i = 0; i < cantidadDeSimulaciones; i++)
        {
            var BolilleroCopia = copia.Clonar();

            Simulaciones[i] = Task<long>.Run(() => (long)BolilleroCopia.JugarNVeces(Jugada, 10000));

        }
        Task<long>.WaitAll(Simulaciones);


        return 0;
    }


}
