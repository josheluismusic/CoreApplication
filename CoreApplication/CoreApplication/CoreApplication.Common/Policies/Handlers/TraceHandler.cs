using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity.InterceptionExtension;
using CoreApplication.Common.Tracing;
using System.Diagnostics;
using CoreApplication.Common.Exceptions;
using System.Collections.Concurrent;

namespace CoreApplication.Common.Policies.Handlers
{
    /// <summary>
    /// Implementación del ICallHandler para la politica de tracing de invocaciones a métodos.
    /// Autor: Lagash S.A.
    /// Fecha de creación: 29/04/2013
    /// Fecha de modificación: 29/04/2013
    /// </summary>
    /// <remarks>
    /// Esta clase aplica la política de tracing de un método de una clase a la que se le haya aplicado
    /// la política de tracing a través del atributo <see cref="TracePolicyAttribute"/>.
    /// o la que esté configurada por defecto en el archivo de configuración
    /// </remarks>
    public class TraceHandler : ICallHandler
    {
        #region fields
        private TraceSource source;
        private const int _registerEventId = 8002;
        private const short _category = 1;
        private int _errorEventId = 8003;

        private static ConcurrentDictionary<string, TraceSource> sourceList = new ConcurrentDictionary<string, TraceSource>();
        #endregion

        #region .ctor
        /// <summary>
        /// Constructor del manejador de traza
        /// </summary>
        /// <param name="traceSourceName">Nombre del Trace Source</param>
        public TraceHandler(string traceSourceName)
        {
            if (!String.IsNullOrEmpty(traceSourceName))
            {
                try
                {
                    source = sourceList.GetOrAdd(traceSourceName, (key) =>
                                                {
                                                   TraceSource newSource = new TraceSource(key);
                                                   newSource.TraceData(TraceEventType.Verbose, _registerEventId, "Incialización del Trace Source: " + key);       
                                                   return newSource;
                                                });
                }
                catch (Exception)
                {
                    System.Diagnostics.EventLog.WriteEntry(Defaults.DefaultTraceSource, "Error en la inicialización del Trace Source: " + traceSourceName, EventLogEntryType.Error, _errorEventId, _category);
                    source = null;
                }
            }
        }

        #endregion

        #region ICallHandler Members

        /// <summary>
        /// Order en el que debe ejecutarse el Handler
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Implementación de la invocación del handler. Aplica la política de tracing
        /// especificada en el constructor a través de un nombre, que debe estar en el archivo de configuración
        /// </summary>
        /// <param name="input">Datos de la invocación</param>
        /// <param name="getNext">Delegado al próximo eslabón de la cadena de responsabilidad</param>
        /// <returns>Resultado de la invocación</returns>
        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            //Tracing
            string callerMethodName = input.MethodBase.DeclaringType.FullName + "." + input.MethodBase.Name;
            using (Tracer tracer = new Tracer(source, callerMethodName))
            {
                // Ejecuto la siguiente policy o el target method y retorno el resultado
                return getNext()(input, getNext);
            }
        }

        #endregion
    }
}
