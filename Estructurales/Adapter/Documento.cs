using System;

namespace Adapter;

public interface Documento   
{   
  void setContenido(String contenido);   
  void dibuja();   
  void imprime();   
}
