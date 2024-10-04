using AbstractFactoryVehiculos;

FabricaVehiculos fabricaVehiculos = new FabricaVehiculosElectricidad();

Automovil automovil = fabricaVehiculos.CrearAutomovil("Yaris","Rojo",1600,4);
automovil.mostrarCaracteristicas();

Moto NuevaMoto = fabricaVehiculos.CrearMoto("Honda", 1600);
NuevaMoto.MostrarCarteristicas();