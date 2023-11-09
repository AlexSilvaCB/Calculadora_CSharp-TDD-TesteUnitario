namespace new_talent.teste;


public class UnitTest1
{

    Calculadora _calc = new Calculadora();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val01, int val02, int resultado)
    {
        int res_calculadora = _calc.Soma(val01, val02);

        Assert.Equal(resultado, res_calculadora);
    }

    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(10, 5, 5)]
    public void TesteSubtracao(int val01, int val02, int resultado)
    {
        int res_calculadora = _calc.Subtracao(val01, val02);

        Assert.Equal(resultado, res_calculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(10, 5, 50)]
    public void TesteMultiplicacao(int val01, int val02, int resultado)
    {
        int res_calculadora = _calc.Multiplicacao(val01, val02);

        Assert.Equal(resultado, res_calculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    public void TesteDivisão(int val01, int val02, int resultado)
    {
        int res_calculadora = _calc.Divisao(val01, val02);

        Assert.Equal(resultado, res_calculadora);
    }

    [Fact]
    public void TesteDivisãoPorZero()
    {

        Assert.Throws<DivideByZeroException>(() => _calc.Divisao(3,0));
    }

    [Fact]
    public void TesteHistorico()
    {
        _calc.Soma(10, 5);
        _calc.Subtracao(10, 5);
        _calc.Multiplicacao(10, 5);
        _calc.Divisao(10, 5);

        var lista = _calc.Historico();

        Assert.Empty(lista);
        Assert.Equal(4, lista.Count);
        
    }

}