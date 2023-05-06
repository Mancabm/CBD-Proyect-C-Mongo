using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Mongo;
using C_Mongo.Models;
using C_Mongo.MongoDataAccess;

namespace C_Mongo
{
    class ProgramMain
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Inicio form = new Inicio();
            form.ShowDialog();
        }
    }
}