public abstract class Moto{

    protected string Marca;
    protected int Cilindrada;

    public Moto(string marca , int cilindrada)
    {
        Marca = marca;
        Cilindrada = cilindrada;
    }

    public abstract void MostrarCarteristicas();
}