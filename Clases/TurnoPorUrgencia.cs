namespace ClinicaVital;

public class TurnoPorUrgencia : Turno
{
    public string ?NivelDeUrgencia {get; set;}

    public TurnoPorUrgencia(int dNIpaciente, string nombrePaciente, int edad, string enfermedadOMotivoConsulta, string nivelDeUrgencia) : base(dNIpaciente, nombrePaciente, edad, enfermedadOMotivoConsulta)
    {
        NivelDeUrgencia=nivelDeUrgencia;
    }
}