public class MotoElectricidad : Moto
{
    

    public MotoElectricidad(string marca, int cilindrada) : base(marca, cilindrada)
    {
    }

    public override void MostrarCarteristicas()
    {
        Console.WriteLine($"La marca es {Marca} y cilindrada: {Cilindrada} electrica");
    }
}