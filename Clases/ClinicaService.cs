namespace ClinicaVital;
using System.Linq;

public class ClinicaService
{
    protected List<SalaDeEspera> SalasDeEspera = new List<SalaDeEspera>();
    public void AgregarSalaDeEspera(SalaDeEspera saladeEspera) => SalasDeEspera.Add(saladeEspera);

    public void DerivarPaciente(SalaDeEspera origen, SalaDeEspera destino, int dNIpaciente)
    {
        if (!origen.EstaEnEspera(dNIpaciente))
        {
            throw new InvalidOperationException("El paciente no se encuentra en la sala origen");
        }

        if (destino.EstaEnEspera(dNIpaciente))
        {
            throw new InvalidOperationException("El paciente ya se encuentra en la sala destino");
        }

        var turno = origen.RemoverTurno(dNIpaciente);
        destino.AgregarTurno(turno);
    }

    public void ObtenerSalaConMasUrgencias()
    {
        
    }
    
}