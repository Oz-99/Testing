using System.Reflection;


namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var calc = new Calculadora();
        var resultado = calc.Sumar(2, 3);
        Assert.Equal(5, resultado);

        var resultadoResta = calc.Restar(5, 2);
        Assert.Equal(3, resultadoResta);
    }
    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(100, 200, 300)]

    public void TestSumar(int a, int b, int resultadoEsperado)
    {
        var calc = new Calculadora();
        var resultado = calc.Sumar(a, b);
        Assert.Equal(resultadoEsperado, resultado);
    }
    
    [Theory]
    [InlineData(5, 3, 2)]       
    [InlineData(-1, 1, -2)]
    [InlineData(0, 0, 0)]
    [InlineData(100, 200, -100)]
    public void TestRestar(int a, int b, int resultadoEsperado)
    {
        var calc = new Calculadora();
        var resultado = calc.Restar(a, b);
        Assert.Equal(resultadoEsperado, resultado);
    }
}