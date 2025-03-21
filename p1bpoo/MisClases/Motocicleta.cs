using p1bpoo.MisClases;

internal class Motocicleta : Vehiculo
{
    private bool tieneCasco;
    private int cilindraje;
    private bool encendida;

    public Motocicleta(int anio, string elColor, string elModelo, int cilindraje, bool casco) : base(anio, elColor, elModelo)
    {
        this.cilindraje = cilindraje;
        tieneCasco = casco;
        encendida = false;
    }

    public override void acelerar(int cuanto)
    {
        base.acelerar(cuanto + 5);
        Console.WriteLine("La motocicleta acelera más rápido!");
    }

    public void Encender()
    {
        encendida = true;
        Console.WriteLine("Motocicleta encendida");
    }
}