public class AutoDeCombustion : Vehiculo
{
    private int capacidadTanque;  
    private double consumoCombustible;  
    private string tipoCombustible;  
    
    public AutoDeCombustion(int anio, string elColor, string elModelo, int tanque, double consumo, string combustible)
        : base(anio, elColor, elModelo)
    {
        this.capacidadTanque = tanque;
        this.consumoCombustible = consumo;
        this.tipoCombustible = combustible;
    }

    public void CargarCombustible(int litros)
    {
        capacidadTanque += litros;
        Console.WriteLine("Se han cargado {0} litros. Capacidad actual: {1}L", litros, capacidadTanque);
    }

   
    public override void frenar(int cuanto)
    {
        velocidad -= cuanto;
        if (velocidad < 0) velocidad = 0;

        capacidadTanque -= 1;  
        if (capacidadTanque < 0) capacidadTanque = 0;

        Console.WriteLine("Frenaste. Velocidad: {0} KMS/H. Combustible restante: {1}L", velocidad, capacidadTanque);
    }

    public void EncenderMotor()
    {
        Console.WriteLine("El motor de {0} está encendido. Listo para arrancar.", tipoCombustible);
    }
}
