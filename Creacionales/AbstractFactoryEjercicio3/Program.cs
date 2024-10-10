using AbstractFactoryEjercicio3;

FabricaProductosBancarios fabricaProductosBancarios = new FabricaProductosPlatinium();

CajaAhorro cajaAhorro = fabricaProductosBancarios.CrearCajaAhorro();
TarjetaDebito tarjetaDebito = fabricaProductosBancarios.CrearTarjetaDebito();

cajaAhorro.MostrarDetalle();
tarjetaDebito.MostrarDetalle();