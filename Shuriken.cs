public class Shuriken
{
    private int _tamanho;

    public Shuriken(int tamanho)
    {
        _tamanho = tamanho;
    }

    public int Gettamanho()
    {
        return _tamanho;
    }

    public override string ToString()
    {
        return $"Shuriken de tamanho: {_tamanho}";
    }
}