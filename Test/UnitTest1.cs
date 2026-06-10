using NUnit.Framework;
using ClinicaVital;

namespace Test;

[TestFixture]
public class ClinicaVitalTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TurnoPorUrgencia_NivelUrgenciaAlta_CalculeTiempoDeEspera15Minutos_Y_NivelUrgenciaCritica_Calcule0Minutos()
    {
        var tiempoDeEsperaAlta = 0;
        var turnoPorUrgenciaAlta = new TurnoPorUrgencia(1234, "Uriel", 20, "Dolor de cabeza", "Alta");
        turnoPorUrgenciaAlta.CalcularTiempoDeEspera(tiempoDeEsperaAlta);
        Assert.That(turnoPorUrgenciaAlta.CalcularTiempoDeEspera(tiempoDeEsperaAlta), Is.EqualTo(15));

        var tiempoDeEsperaCritica = 0;
        var turnoPorUrgenciaCritica = new TurnoPorUrgencia(5647, "Fabricio", 11, "Dolor de estómago", "Critica");
        turnoPorUrgenciaCritica.CalcularTiempoDeEspera(tiempoDeEsperaCritica);
        Assert.That(turnoPorUrgenciaCritica.CalcularTiempoDeEspera(tiempoDeEsperaCritica), Is.EqualTo(0));
    }

    [Test]
    public void EstaEnEspera_DevuelveTrueCuandoUnPacienteTieneUnTurnoRegistrado_Y_FalseCuandoNo()
    {
        var turno = new TurnoPorUrgencia(1234, "Juan", 20, "Corte", "Bajo");
        var salaDeEspera = new SalaDeEspera();
    }
}