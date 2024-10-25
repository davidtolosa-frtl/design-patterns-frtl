using Decorator;

VistaVehiculo vista = new VistaVehiculo();
ModeloDecorador modeloDecorador = new ModeloDecorador(vista);
LogoDecorador logoDecorador = new LogoDecorador(modeloDecorador);

logoDecorador.visualiza();