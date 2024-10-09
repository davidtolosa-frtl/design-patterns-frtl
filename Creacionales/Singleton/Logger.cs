namespace Singleton;

public class Logger
{
    private  static Logger instancia = null;
    private Logger()
    {
        Console.WriteLine("Se creo un objeto Logger");
    }

    public static Logger getInstancia(){
        if(instancia == null)
            instancia = new Logger();

        return instancia;
    }
}
