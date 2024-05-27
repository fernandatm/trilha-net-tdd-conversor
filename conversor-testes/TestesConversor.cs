using conversor_tdd;

namespace conversor_testes;

public class TestesConversor
{
    [Fact]
    public void DeveConverter10GrausCelsiusPara50GrausFahrenheit()
    {
        Conversor conversor = new Conversor();
        decimal resultado = conversor.ConverterCelsiusParaFahrenheit(10);

        Assert.Equal(50, resultado);
    }

    [Theory]
    [InlineData(10, 283.15)]
    [InlineData(29, 302.15)]
    [InlineData(82, 355.15)]
    public void DeveConverterGrausCelsiusParaKelvin(decimal temperatura, decimal resultadoTeste)
    {
        Conversor conversor = new Conversor();
        decimal resultadoConversor = conversor.ConverterCelsiusParaKelvin(temperatura);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Theory]
    [InlineData(300, 26.85)]
    [InlineData(283, 9.85)]
    [InlineData(350, 76.85)]
    public void DeveConverterKelvinParaCelsius(decimal temperatura, decimal resultadoTeste)
    {
        Conversor conversor = new Conversor();
        decimal resultadoConversor = conversor.ConverterKelvinParaCelsius(temperatura);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Theory]
    [InlineData(300, 80.33)]
    [InlineData(283, 49.73)]
    [InlineData(350, 170.33)]
    public void DeveConverterKelvinParaFahrenheit(decimal temperatura, decimal resultadoTeste)
    {
        Conversor conversor = new Conversor();
        decimal resultadoConversor = conversor.ConverterKelvinParaFahrenheit(temperatura);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Theory]
    [InlineData(300, 422.039)]
    [InlineData(283, 412.594)]
    [InlineData(350, 449.817)]
    public void DeveConverterFahrenheitParaKelvin(decimal temperatura, decimal resultadoTeste)
    {
        Conversor conversor = new Conversor();
        decimal resultadoConversor = conversor.ConverterFahrenheitParaKelvin(temperatura);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Theory]
    [InlineData(300, 422.039)]
    [InlineData(283, 412.594)]
    [InlineData(350, 449.817)]
    public void DeveConverterFahrenheitParaCelsius(decimal temperatura, decimal resultadoTeste)
    {
        Conversor conversor = new Conversor();
        decimal resultadoConversor = conversor.ConverterFahrenheitParaCelsius(temperatura);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Fact]
    public void DeveRetornarHistoricoDasTresUltimasOperacoesRealizadas()
    {
        Conversor conversor = new Conversor();
        
        conversor.ConverterKelvinParaFahrenheit(10);
        conversor.ConverterFahrenheitParaCelsius(10);
        conversor.ConverterKelvinParaCelsius(10);
        conversor.ConverterCelsiusParaFahrenheit(10);

        var lista = conversor.historico();
        
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}