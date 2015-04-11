using CoreApplication.Urgencia.Contrato.Models;
using CoreApplication.Urgencia.Contrato.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Urgencia.Mocks.ServicioMocks.Implementation
{
    [Export(typeof(IUrgenciaService))]
    public class MockUrgenciaService : IUrgenciaService
    {
        public IList<UrgenciaModel> GetListadoUrgencia()
        {
            IList<UrgenciaModel> listadoUrgencia = new List<UrgenciaModel>();
            listadoUrgencia.Add(new UrgenciaModel
            {
                IdPaciente = 1,
                Box = "Rean 1",
                Codigo = "AE",
                Edad = "20a",
                MotivoConsulta = "Esguince Tobillo",
                NombrePaciente = "Gonzalez Cabello María Cristina"
            });
            listadoUrgencia.Add(new UrgenciaModel
            {
                IdPaciente = 2,
                Box = "12",
                Codigo = "AE",
                Edad = "32a",
                MotivoConsulta = "Esguince Tobillo",
                NombrePaciente = "Mujica Barría Diego"
            });
            listadoUrgencia.Add(new UrgenciaModel
            {
                IdPaciente = 3,
                Box = "1",
                Codigo = "AE",
                Edad = "28a",
                MotivoConsulta = "Dolor Estomacal Agudo",
                NombrePaciente = "Araya Romano Andres Eduardo"
            });
            listadoUrgencia.Add(new UrgenciaModel
            {
                IdPaciente = 4,
                Box = "2",
                Codigo = "AE",
                Edad = "32a",
                MotivoConsulta = "Mareos",
                NombrePaciente = "Barría Espinoza Diego Patricio"
            });
            listadoUrgencia.Add(new UrgenciaModel
            {
                IdPaciente = 5,
                Box = "7",
                Codigo = "AE",
                Edad = "20a",
                MotivoConsulta = "Dolor de cabeza, mareos",
                NombrePaciente = "Coutinho Cabello Saraha Andrea"
            });

            return listadoUrgencia;
        }
    }
}
