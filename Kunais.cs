public class Kunais
{
    private string _nome;

    public Kunais(string nome)
    {
        _nome = nome;
    }

    public string Getnome()
    {
        return _nome;
    }


    public override string ToString()
    {
        return $"Kunai: {_nome}";
    }
}