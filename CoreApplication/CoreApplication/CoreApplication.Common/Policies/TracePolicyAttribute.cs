using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using CoreApplication.Common.ComponentModel.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace CoreApplication.Common.Policies
{
    /// <summary>
    /// Representa un atributo para poder inyectar políticas de tracing en los métodos 
    /// Autor: Lagash S.A.
    /// Fecha de creación: 29/04/2013
    /// Fecha de modificación: 29/04/2013
    /// </summary>
    public class TracingPolicyAttribute : HandlerAttribute
    {
        #region fields
        private string _traceSourceName = null;
        #endregion

        #region Constructores

        public TracingPolicyAttribute()
        {
            
        }

        public TracingPolicyAttribute(string traceSourceName = null)
        {
            _traceSourceName = traceSourceName;
        }

        #endregion

        #region HandlerAttribute overrides

        /// <summary>
        /// Crea un handler de que registra los traces
        /// </summary>
        /// <returns>Un nuevo objeto call handler.</returns>
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            return new Handlers.TraceHandler(_traceSourceName);
        }

        #endregion
    }
 }
