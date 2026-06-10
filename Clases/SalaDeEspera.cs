namespace ClinicaVital;
using System.Linq;

public class SalaDeEspera
{
    public string ?NombreOIdentificadorDeLaSala {get; set;}
    protected List<Turno> Turnos = new List<Turno>();


    public void AgregarTurno(Turno turno) => Turnos.Add(turno);

    public void AgregarTurno(Turno turno, int posicion)
    {
        if(posicion < 0)
        {
            throw new ArgumentException("La posición no puede ser negativa");
        }
    }

    public Turno RemoverTurno(int dNIpaciente)
    {
        var turno = Turnos.FirstOrDefault(f => f.DNIPaciente == dNIpaciente);
        Turnos.Remove(turno);
        return turno;
    }

    public bool EstaEnEspera(int dni)
    {
        return Turnos.Any(f => f.DNIPaciente == dni);
    }

    public List<Turno> ObtenerOrdenDeAtencion()
    {
        return Turnos
            .OrderBy(f => f.TiempoDeEspera)
            .ToList();
    }
}