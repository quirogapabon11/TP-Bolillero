namespace Bolillero.Core;

public class Aleatorio : IAleatorio
{
    private Random _random { get; set; }
    public Aleatorio()
        => _random = new Random(DateTime.Now.Millisecond);
    public int SacarIndice(List<int> Bolillas)
    => _random.Next(0, Bolillas.Count);
}