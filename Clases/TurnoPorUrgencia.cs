namespace ClinicaVital;

public class TurnoPorUrgencia : Turno
{
    public string ?NivelDeUrgencia {get; set;}

    public TurnoPorUrgencia(int dNIpaciente, string nombrePaciente, int edad, string enfermedadOMotivoConsulta, string nivelDeUrgencia) : base(dNIpaciente, nombrePaciente, edad, enfermedadOMotivoConsulta)
    {
        NivelDeUrgencia=nivelDeUrgencia;
    }

    public override int CalcularTiempoDeEspera(int TiempoDeEspera)
    {
        TiempoDeEspera=0;
        if (NivelDeUrgencia == "Critica")
        {
            TiempoDeEspera=0;
        }
        if (NivelDeUrgencia == "Alta")
        {
            TiempoDeEspera=15;
        }
        if (NivelDeUrgencia == "Media")
        {
            TiempoDeEspera=30;
        }
        if (NivelDeUrgencia == "baja")
        {
            TiempoDeEspera=45;
        }
        return TiempoDeEspera;
    }
}