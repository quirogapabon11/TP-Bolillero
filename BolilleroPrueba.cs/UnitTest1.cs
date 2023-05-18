using Bolillero.Core;

namespace BolilleroPrueba;

public class BolilleroTest
{
    public BolilleroUno Bolillero { get; set; }
    public BolilleroTest()=> BolilleroUno = new Bolillero(20, new Aleatorio2());
    {
        
    }
    [Fact]
    public void TestName()
    {
        // Given

        // When

        // Then
    }
}