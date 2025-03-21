public class Vehiculo
{
    public string Color { get; set; }
    public string Modelo { get; }
    public int Year { get; }

    protected int velocidad = 0; 

    public Vehiculo(int anio, string elColor, string elModelo)
    {
        this.Color = elColor;
        this.Modelo = elModelo;
        this.Year = anio;
    }

    public void InformacionVehiculo()
    {
        Console.WriteLine("Color: {0}", this.Color);
        Console.WriteLine("Modelo: {0}", this.Modelo);
        Console.WriteLine("Año: {0}", this.Year);
    }

    
    public virtual void frenar(int cuanto)
    {
        velocidad -= cuanto;
        if (velocidad < 0) velocidad = 0;
        Console.WriteLine("Has frenado. Velocidad actual: {0} KMS/H", velocidad);
    }

    public virtual void acelerar(int cuanto)
    {
        velocidad += cuanto;
        Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
    }
}
