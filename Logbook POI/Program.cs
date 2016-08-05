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
using System.IO;
namespace Logbook_POI
{
    /// <summary>
    /// Clase que se encarga de cargar, guardar y gestionar conceptos.
    /// </summary>
    class Diario
    {
        /// <summary>
        /// La estructura base que define un concepto del diario.
        /// </summary>
        [Serializable]
        public struct Concepto
        {
            public uint id
            {
                get { return _id; }
            }
            public string nombre;
            public string definicion;
            public Concepto(string nombre, string definicion)
            {
                _id = _idCount++;
                this.nombre = nombre;
                this.definicion = definicion;
            }
            private uint _id;
        }
        private static uint _idCount;
        public List<Concepto> Lista = new List<Concepto>();
        /// <summary>
        /// Guardar los conceptos en un archivo binario
        /// </summary>
        public void Guardar()
        {
            var serializationFile = "Diario.bin";
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, Lista);
            }
        }
        /// <summary>
        /// Carga los conceptos de un archivo binario
        /// </summary>
        public void Cargar()
        {
            var serializationFile = "Diario.bin";
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Lista = (List<Concepto>)binaryFormatter.Deserialize(stream);
                _idCount = Lista.Last<Concepto>().id + 1;
            }
        }
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
            Diario diario = new Diario();
            //diario.Lista.Add(new Diario.Concepto("Amor", "El amor es un concepto"));
            //diario.Lista.Add(new Diario.Concepto("Locura", "La locura es otro concepto"));
            //diario.Lista.Add(new Diario.Concepto("Hambre", "El hambre te hace querer comer"));
            diario.Cargar();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
