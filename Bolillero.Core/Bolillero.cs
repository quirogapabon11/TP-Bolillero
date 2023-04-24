namespace Bolillero.Core;
public class Bolillero
{
    public List<int>? Bolillas { get; set; }
    public List<int>? Afuera { get; set; }
    public List<int>? Jugada { get; set; }

    public Bolillero(int bolillas, int afuera, int jugada)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.Jugada = new List<int>();
    }

    public bool Jugar(List<int> jugada)
    {
        for (i = 0; i <= jugada;)
            return true;
    }

    public void SacarBolilla(int bolillas)
    {

    }

    public void MeterBolilla(int afuera)
    {

    }

    public void JugarNVeces()
    {

    }
}
