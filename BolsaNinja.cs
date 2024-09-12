public class BolsaNinja<T> 
{
    private List<T> _itens;

    public BolsaNinja()
    {
        _itens = new List<T>();
    }

    public void AddItens(T itens)
    {
        _itens.Add(itens);
    }

    public void MostrarItens()
    {
        foreach (var item in _itens)
        {
            Console.WriteLine(item);
        }        
    }
}