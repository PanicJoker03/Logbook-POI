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
    public class Concepto
    {
        public uint id;
        public string nombre;
        public string contenido;
        public Concepto(string nombre, string contenido)
        {
            id = idCounter_++;
            this.nombre = nombre;
            this.contenido = contenido;
        }
        private static uint idCounter_;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Tests
            List<Concepto> conceptoList = new List<Concepto>();
            conceptoList.Add(new Concepto("Amor", "El amor es un concepto"));
            conceptoList.Add(new Concepto("Locura", "La locura es otro concepto"));
            conceptoList.Add(new Concepto("Hambre", "El hambre te hace querer comer"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
