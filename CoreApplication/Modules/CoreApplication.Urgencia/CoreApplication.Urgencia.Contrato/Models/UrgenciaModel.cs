using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Urgencia.Contrato.Models
{
    public class UrgenciaModel
    {
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string Codigo { get; set; }
        public string Box { get; set; }
        public string Edad { get; set; }
        public string MotivoConsulta { get; set; }
    }
}
