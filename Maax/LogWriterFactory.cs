using System;
using System.Collections.Generic;
using System.Text;

namespace Maax
{
    public class LogWriterFactory
    {
        private static readonly LogWriterFactory instance;

        private LogWriterFactory()
        {

        }
        
        public T GetLogWriter<T>(params AbstractLogWriter[] abstractLogWriters) where T : AbstractLogWriter, new()
        {
            T logWriter = new T();

            if (abstractLogWriters != null)
            {
                var mlw = logWriter as MultipleLogWriter;

                if (mlw != null)
                    mlw.LogWriters.AddRange(abstractLogWriters);
            }

            return logWriter;
        }

        public static LogWriterFactory GetInstance()
        {
            if (instance == null)
                return new LogWriterFactory();

            return instance;
        }
    }
}
