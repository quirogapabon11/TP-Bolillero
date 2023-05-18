namespace Bolillero.Core;
public class BolilleroUno
{
    public List<int>? Bolillas { get; set; }
    public List<int>? Afuera { get; set; }
    public List<int>? Jugada { get; set; }
    public Aleatorio Aleatorio { get; set; }

    public BolilleroUno(int bolillas, Aleatorio aleatorio)
    {

        this.Bolillas = new List<int>();
        CrearBolillas(bolillas);
        this.Afuera = new List<int>();
        this.Jugada = new List<int>();
        this.Aleatorio = aleatorio;
    }
    public void CrearBolillas(int bolillas)
    {
        for (int i = 0; i <= bolillas; i++)
        {
            Bolillas.Add(i);
        }
    }

    public bool Jugar(List<int> jugada)
    {
        for (int i = 0; i <= Jugada.Count;)
        {
            var bolilla = SacarBolilla();
            if (bolilla != Jugada[i])
            {
                return false;
            }
        }
        return true;
    }

    public int SacarBolilla()
    {
        var indice = Aleatorio.SacarIndice(this.Bolillas);
        var elemento = Bolillas[indice];


        this.Afuera.Add(elemento);
        this.Bolillas.Remove(elemento);
        return elemento;
    }

    public void MeterBolilla()
    {
        Bolillas.AddRange(Afuera);
        Afuera.Clear();
    }

    public int JugarNVeces(List<int> jugada, int cantidad)
    {
        var JugadasGanadas = 0;
        for (int i = 0; i <= cantidad; i++)
        {
            var jugar = Jugar(jugada);
            if (jugar == true)
            {
                JugadasGanadas = JugadasGanadas + 1;
            }
        }
        return JugadasGanadas;

    }
}
