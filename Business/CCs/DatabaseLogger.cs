using System;

namespace Business.CCs
{
    public class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
