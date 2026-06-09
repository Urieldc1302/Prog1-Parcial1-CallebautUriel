namespace ClinicaVital;

public class TurnoPorEspecialidad : Turno
{
    public string ?Especialidad {get; set;}
    public bool EsPrimeraConsulta {get; set;}

    public TurnoPorEspecialidad(int dNIpaciente, string nombrePaciente, int edad, string enfermedadOMotivoConsulta, string especialidad, bool esPrimeraConsulta) : base(dNIpaciente, nombrePaciente, edad, enfermedadOMotivoConsulta)
    {
        if (string.IsNullOrWhiteSpace(especialidad))
        {
            throw new ArgumentException("La especialidad no puede estar vacía o con espacios en blanco");
        }
        Especialidad=especialidad;
        EsPrimeraConsulta=esPrimeraConsulta;
    }
}