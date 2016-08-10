//Diario de conceptos - POI
//Tarea escolar de la materia de POI
//Referencias
//http://stackoverflow.com/questions/16352879/write-list-of-objects-to-a-file
//https://msdn.microsoft.com/en-us/library/x0b5b5bc.aspx
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Logbook_POI
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Tests
            //Diario.Lista.Add(new Diario.Concepto("Amor", "El amor es un concepto"));
            //Diario.Lista.Add(new Diario.Concepto("Locura", "La locura es otro concepto"));
            //Diario.Lista.Add(new Diario.Concepto("Hambre", "El hambre te hace querer comer"));
            //Diario.Guardar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Diario.Guardar();
        }
    }
}
