using p1bpoo.MisClases;

internal class Camion : Vehiculo
{
    private int cargaMaxima;
    private int cargaActual;
    private bool tieneRemolque;

    public Camion(int anio, string elColor, string elModelo, int cargaMax, bool remolque) : base(anio, elColor, elModelo)
    {
        cargaMaxima = cargaMax;
        cargaActual = 0;
        tieneRemolque = remolque;
    }

    public override void acelerar(int cuanto)
    {
        base.acelerar(cuanto / 2);
        Console.WriteLine("El camión acelera más lento debido a la carga.");
    }

    public void Cargar(int peso)
    {
        if (cargaActual + peso <= cargaMaxima)
        {
            cargaActual += peso;
            Console.WriteLine("Carga actual: {0}kg", cargaActual);
        }
        else
        {
            Console.WriteLine("No se puede cargar más, el camión está lleno.");
        }
    }
}