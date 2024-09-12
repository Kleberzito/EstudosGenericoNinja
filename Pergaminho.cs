public class Pergaminho
{
    private string _conteudo;

    public Pergaminho(string conteudo)
    {
        _conteudo = conteudo;
    }

    public string GetConteudo()
    {
        return _conteudo;
    }

    public override string ToString()
    {
        return $"Pergaminho {_conteudo}";
    }
}