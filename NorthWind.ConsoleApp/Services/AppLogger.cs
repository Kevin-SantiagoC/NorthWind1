using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ConsoleApp.Services
{
    internal class AppLogger(IEnumerable<IUserActionWriter> writer)
    {
        public void WriteLog(string message)
        {
            UserAction Log = new UserAction("System", message);
            foreach(var Writer in writer) 
            Writer.Write(Log);
        }
    }
}
