using CoreApplication.Cabeceras.Contrato.Models;
using CoreApplication.Cabeceras.Contrato.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Cabeceras.Mocks.Servicio.Implementation
{
    [Export(typeof(ICabeceraPacienteService))]
    public class MockCabeceraPaciente : ICabeceraPacienteService
    {
        public IList<Paciente> GetDatosPaciente()
        {
            IList<Paciente> _pacientes = new List<Paciente>();
            _pacientes.Add(new Paciente
            {

                fichaPaciente = 1,
                episodioPaciente = 1,
                nombrePaciente = "Nombre Nombre APELLIDO APELLIDO",
                rutPaciente = "1-9",
                sexoPaciente = "Masculino",
                fechaNacPaciente = Convert.ToDateTime("01/01/1987"),
                estadoCivilPaciente = "Soltero",
                nacionalidadPaciente = "Chileno",
                etniaPaciente  = "Ninguna",
                actividadPaciente = "Estudiante",
                direccionPaciente  = "Dirección #4512",
                paisPaciente  = "Chile",
                comunaPaciente = "Vitacura",
                ciudadPaciente = "Santiago",
                telefono1Paciente  = "25545125",
                telefono2Paciente  = "+569 54152548",
                emailPaciente  = "maildeprueba@alemana.cl"

            });

            return _pacientes;
        }
       public Paciente GetDatosPacientef() 
        {
            return new Paciente
            {
                fichaPaciente = 1,
                episodioPaciente = 1,
                nombrePaciente = "Nombre Nombre APELLIDO APELLIDO",
                rutPaciente = "1-9",
                sexoPaciente = "Masculino",
                fechaNacPaciente = Convert.ToDateTime("01/01/1987"),
                estadoCivilPaciente = "Soltero",
                nacionalidadPaciente = "Chileno",
                etniaPaciente = "Ninguna",
                actividadPaciente = "Estudiante",
                direccionPaciente = "Dirección #4512",
                paisPaciente = "Chile",
                comunaPaciente = "Vitacura",
                ciudadPaciente = "Santiago",
                telefono1Paciente = "25545125",
                telefono2Paciente = "+569 54152548",
                emailPaciente = "maildeprueba@alemana.cl"
            };
        }
    }
}
