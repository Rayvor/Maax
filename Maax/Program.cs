using System;

namespace Maax
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriterFactory factory = LogWriterFactory.GetInstance();

            var cw = factory.GetLogWriter<ConsoleLogWriter>();
            var fw = factory.GetLogWriter<FileLogWriter>();
            var mw = factory.GetLogWriter<MultipleLogWriter>(cw, fw);
        }
    }
}
