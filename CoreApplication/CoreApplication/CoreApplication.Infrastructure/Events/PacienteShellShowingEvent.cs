using CoreApplication.Infrastructure.Models;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Infrastructure.Events
{
    public class PacienteShellShowingEvent : CompositePresentationEvent<SwitchShellData>
    {
    }
}
