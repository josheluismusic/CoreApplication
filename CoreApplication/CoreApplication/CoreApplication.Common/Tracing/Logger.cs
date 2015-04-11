using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;

namespace CoreApplication.Common.Tracing
{
    public static class Logger
    {
        private static TraceSource _source;

        private static Tracer _tracer;

        public static string TraceSourceName;

        static Logger()
        {
            Init();
        }

        private static void Init()
        {
            _tracer = new Tracer();
            _source = _tracer.TraceSource;
        }

        private static bool IsTracing(SourceLevels currentLevel, SourceLevels currentAction)
        {
            return (currentLevel & currentAction) == currentAction;
        }

        public static void Verbose(string message, params object[] args)
        {
            if (IsTracing(_source.Switch.Level, SourceLevels.Verbose) && message != null)
            {
                _source.TraceEvent(TraceEventType.Verbose, 0, CreateTracedMessage(message, args));
            }
        }

        public static void Information(string message, params object[] args)
        {
            if (IsTracing(_source.Switch.Level, SourceLevels.Information) && message != null)
            {
                _source.TraceEvent(TraceEventType.Information, 0, CreateTracedMessage(message, args));
            }
        }

        public static void Warning(string message, params object[] args)
        {
            if (IsTracing(_source.Switch.Level, SourceLevels.Warning) && message != null)
            {
                _source.TraceEvent(TraceEventType.Warning, 0, CreateTracedMessage(message, args));
            }
        }

        public static void Error(string message, params object[] args)
        {
            if (IsTracing(_source.Switch.Level, SourceLevels.Error) && message != null)
            {
                ErrorInternal(CreateTracedMessage(message, args));
            }
        }

        public static void Error(Exception ex, string message, params object[] args)
        {
            if (IsTracing(_source.Switch.Level, SourceLevels.Error) && message != null)
            {
                ErrorInternal(CreateTracedMessage(ex.ToString()));
                ErrorInternal(CreateTracedMessage(message, args));
            }
        }

        public static void Error(Exception ex)
        {
            if (IsTracing(_source.Switch.Level, SourceLevels.Error) && ex != null)
            {
                ErrorInternal(CreateTracedMessage(ex.ToString()));
            }
        }

        private static void ErrorInternal(string message)
        {
            _source.TraceEvent(TraceEventType.Error, 0, message);
        }

        private static string CreateTracedMessage(string message, params object[] args)
        {
            try
            {
                StackTrace stack = new StackTrace();
                if (stack.FrameCount >= 3)
                {
                    var sourceMethod = stack.GetFrame(2).GetMethod();
                    return String.Format("|{0}|{1}| {2}.{3}: {4}",
                        DateTime.Now.ToShortDateString(),
                        DateTime.Now.ToLongTimeString(),
                        sourceMethod.DeclaringType.FullName,
                        sourceMethod.Name,
                        String.Format(message, args));
                }
                else
                {
                    return String.Format("|{0}|{1}|",
                        DateTime.Now.ToShortDateString(),
                        DateTime.Now.ToLongTimeString(),
                        String.Format(message, args));
                }
            }
            catch
            {
                return message;
            }
        }
    }
}
