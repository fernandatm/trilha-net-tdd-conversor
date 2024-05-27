using conversor_tdd;

namespace conversor_testes;

public class TestesConversor
{
    public Conversor construirConversor()
    {
        Conversor construtorDoConversor = new Conversor();
        return construtorDoConversor;
    }

    [Fact]
    public void DeveConverter10GrausCelsiusPara50GrausFahrenheit()
    {
        Conversor conversor = construirConversor();
        double resultado = Math.Round(conversor.ConverterCelsiusParaFahrenheit(10), 2);

        Assert.Equal(50, resultado);
    }

    [Theory]
    [InlineData(10, 283.15)]
    [InlineData(29, 302.15)]
    [InlineData(82, 355.15)]
    public void DeveConverterGrausCelsiusParaKelvin(double temperatura, double resultadoTeste)
    {
        Conversor conversor = construirConversor();
        double resultadoConversor = Math.Round(conversor.ConverterCelsiusParaKelvin(temperatura), 2);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Theory]
    [InlineData(300, 26.85)]
    [InlineData(283, 9.85)]
    [InlineData(350, 76.85)]
    public void DeveConverterKelvinParaCelsius(double temperatura, double resultadoTeste)
    {
        Conversor conversor = construirConversor();
        double resultadoConversor = Math.Round(conversor.ConverterKelvinParaCelsius(temperatura), 2);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Theory]
    [InlineData(300, 80.33)]
    [InlineData(283, 49.73)]
    [InlineData(350, 170.33)]
    public void DeveConverterKelvinParaFahrenheit(double temperatura, double resultadoTeste)
    {
        Conversor conversor = construirConversor();
        double resultadoConversor = Math.Round(conversor.ConverterKelvinParaFahrenheit(temperatura), 2);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Theory]
    [InlineData(300, 422.04)]
    [InlineData(283, 412.59)]
    [InlineData(350, 449.82)]
    public void DeveConverterFahrenheitParaKelvin(double temperatura, double resultadoTeste)
    {
        Conversor conversor = construirConversor();
        double resultadoConversor = Math.Round(conversor.ConverterFahrenheitParaKelvin(temperatura), 2);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Theory]
    [InlineData(300, 148.89)]
    [InlineData(283, 139.44)]
    [InlineData(350, 176.67)]
    public void DeveConverterFahrenheitParaCelsius(double temperatura, double resultadoTeste)
    {
        Conversor conversor = construirConversor();
        double resultadoConversor = Math.Round(conversor.ConverterFahrenheitParaCelsius(temperatura), 2);

        Assert.Equal(resultadoTeste, resultadoConversor);
    }

    [Fact]
    public void DeveRetornarHistoricoDasTresUltimasOperacoesRealizadas()
    {
        Conversor conversor = construirConversor();
        
        conversor.ConverterKelvinParaFahrenheit(10);
        conversor.ConverterFahrenheitParaCelsius(10);
        conversor.ConverterKelvinParaCelsius(10);
        conversor.ConverterCelsiusParaFahrenheit(10);

        var lista = conversor.historico();
        
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}