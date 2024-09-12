

public class Program
{
    public static void Main(string[] args)
    {
        BolsaNinja<Object> bolsaNinja= new BolsaNinja<Object>();

        bolsaNinja.AddItens(new Kunais("Explosiva"));
        bolsaNinja.AddItens(new Shuriken(4));
        bolsaNinja.AddItens(new Pergaminho("Invocação do sapo"));

        Console.WriteLine("Itens da bolsa Ninja:");
        bolsaNinja.MostrarItens();
    }

}