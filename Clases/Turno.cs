namespace ClinicaVital;

public abstract class Turno
{
    public int DNIPaciente {get; set;}
    public string ?NombrePaciente {get; set;}
    public int Edad {get; set;}
    public string ?EnfermedadOMotivoConsulta {get; set;}
    public int TiempoDeEspera {get; set;}


    public Turno(int dNIpaciente, string nombrePaciente, int edad, string enfermedadOMotivoConsulta)
    {
        if(dNIpaciente <= 0)
        {
            throw new ArgumentException("El DNI del paciente no puede ser menor o igual a 0");
        }
        if (string.IsNullOrWhiteSpace(nombrePaciente))
        {
            throw new ArgumentException("El nombre del paciente no puede estar vacío o con espacios en blanco");
        }
        if(edad <= 0)
        {
            throw new ArgumentException("La edad del paciente no puede ser menor o igual a 0");
        }
        if(edad > 120)
        {
            throw new ArgumentException("La edad del paciente no puede ser mayor a 120 años");
        }
        if (string.IsNullOrWhiteSpace(enfermedadOMotivoConsulta))
        {
            throw new ArgumentException("La enfermedad o motivo de consulta no puede estar vacía o con espacios en blanco");
        }

        DNIPaciente=dNIpaciente;
        NombrePaciente=nombrePaciente;
        Edad=edad;
        EnfermedadOMotivoConsulta=enfermedadOMotivoConsulta;
    }

    public abstract int CalcularTiempoDeEspera(int TiempoDeEspera);
}
