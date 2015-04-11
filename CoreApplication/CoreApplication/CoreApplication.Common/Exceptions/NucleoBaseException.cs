using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CoreApplication.Common.Exceptions
{
    [Serializable]
    public class NucleoBaseException : Exception
    {
        #region fields
        private string _uniqueId = Guid.NewGuid().ToString();
        private const short _category = 1;
        private string _message;
        private string _innerExceptionMessages = string.Empty;
        private int _eventId = 0;
        #endregion fields

        #region properties
        /// <summary>
        /// Identificador unico de instancia de error.
        /// (un Guid único para identificar la instancia del error). Este dato perfectamente 
        /// se le puede mostrar al usuario, para tener una trazabilidad exacta del error y 
        /// su correspondiente mensaje.
        /// </summary>
        public string UniqueId
        {
            get
            {
                return _uniqueId;
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Mensaje de la excepción</param>
        public NucleoBaseException(int eventId, string message, params object[] args)
            : base(String.Format(message, args))
        {
            _eventId = eventId;
            _message = String.Format(message, args);
            
            LogException();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Mensaje de la excepción</param>
        /// <param name="innerException">Excepción interna</param>
        public NucleoBaseException(int eventId, Exception innerException, string message, params object[] args)
            : base(String.Format(message, args), innerException)
        {
            _eventId = eventId;
            _message = String.Format(message, args);
            
            SetInnerExceptionsMessages(innerException);
            LogException();
        }

        /// <summary>
        /// Constructor para serialización
        /// </summary>
        /// <param name="info">Información de serialización</param>
        /// <param name="context">Parámetro de contexto</param>
        public NucleoBaseException(int eventId, SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _eventId = eventId;
            _message = context.ToString();
            
            LogException();
        }

        #endregion

        #region Private methods

        private void LogException()
        {
            object[] args = new object[] { UniqueId, _message, this.StackTrace, _innerExceptionMessages };
                        
            _message = String.Format(Messages.NucleoCommonException, args);
            //Intento guardar en el log de eventos de Windows, sino no puede no hacer nada
            try
            {
                System.Diagnostics.EventLog.WriteEntry(Defaults.DefaultTraceSource, _message, EventLogEntryType.Error, _eventId, _category);
            }
            finally
            {
            }
        }

        private void SetInnerExceptionsMessages(Exception innerException)
        {
            _innerExceptionMessages = "InnerExceptions->";
            
            StringBuilder sb = new StringBuilder();
            
            while(innerException!=null) 
            {
                sb.Append(innerException.GetType().ToString());
                sb.Append(":");
                sb.Append(innerException.Message);
                sb.Append("Stack Trace:");
                sb.Append(innerException.StackTrace);
                sb.Append("|");

                innerException = innerException.InnerException;
            }

            _innerExceptionMessages += sb.ToString();

        }
        
        #endregion

    }
}
