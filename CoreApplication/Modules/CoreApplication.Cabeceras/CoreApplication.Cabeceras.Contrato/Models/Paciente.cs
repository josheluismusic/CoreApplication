using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Cabeceras.Contrato.Models
{
    public class Paciente
    {
        public long fichaPaciente { get; set; }
        public long episodioPaciente { get; set; }
        public string nombrePaciente { get; set; }
        public string rutPaciente { get; set; }
        public string sexoPaciente { get; set; }
        public DateTime fechaNacPaciente { get; set; }
        public string estadoCivilPaciente { get; set; }
        public string nacionalidadPaciente { get; set; }
        public string etniaPaciente { get; set; }
        public string actividadPaciente { get; set; }
        public string direccionPaciente { get; set; }
        public string paisPaciente { get; set; }
        public string comunaPaciente { get; set; }
        public string ciudadPaciente { get; set; }
        public string telefono1Paciente { get; set; }
        public string telefono2Paciente { get; set; }
        public string emailPaciente { get; set; }
    }
}
