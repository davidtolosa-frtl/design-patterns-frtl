using Strategy;

int distancia = 10;

Navegador navegador = new Navegador();

navegador.setTiempoRutaStrategy(new TiempoRutaCaminata());
Console.WriteLine(navegador.calcularTiempoRuta(distancia));

navegador.setTiempoRutaStrategy(new TiempoRutaBicicleta());
Console.WriteLine(navegador.calcularTiempoRuta(distancia));

navegador.setTiempoRutaStrategy(new TiempoRutaAuto());
Console.WriteLine(navegador.calcularTiempoRuta(distancia));