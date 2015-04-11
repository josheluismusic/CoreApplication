using CoreApplication.Urgencia.Contrato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Urgencia.Contrato.ServiceInterfaces
{
    public interface IUrgenciaService
    {
        IList<UrgenciaModel> GetListadoUrgencia();
    }
}
