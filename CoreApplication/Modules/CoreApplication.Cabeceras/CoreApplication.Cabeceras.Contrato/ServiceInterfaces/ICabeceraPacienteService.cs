using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApplication.Cabeceras.Contrato.Models;

namespace CoreApplication.Cabeceras.Contrato.ServiceInterfaces
{
    public interface ICabeceraPacienteService
    {
        IList<Paciente> GetDatosPaciente();
        Paciente GetDatosPacientef();
    }
}
