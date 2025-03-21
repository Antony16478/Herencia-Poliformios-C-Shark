using p1bpoo.MisClases;

 
AutoDeCombustion miAuto = new AutoDeCombustion(2026, "Azul", "Alfa Romeo", 50, 0.5, "Gasolina");
miAuto.InformacionVehiculo();
miAuto.acelerar(20); 
miAuto.frenar(10); 
miAuto.CargarCombustible(20); 

CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");
miBYD.InformacionVehiculo();
miBYD.cargarBateria();
Console.WriteLine("El nivel de batería es: {0}", miBYD.NivelBateria());
