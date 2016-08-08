using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logbook_POI
{
    /// <summary>
    /// Clase que se encarga de cargar, guardar y gestionar conceptos.
    /// </summary>
    public static class Diario
    {
        public static List<Concepto> Lista = new List<Concepto>();
        /// <summary>
        /// La estructura base que define un concepto del diario.
        /// </summary>
        [Serializable]
        public class Concepto
        {
            public uint id
            {
                get { return _id; }
            }
            public string nombre { get; set; }
            public string definicion { get; set; }
            public Concepto(string nombre, string definicion)
            {
                _id = _idCount++;
                this.nombre = nombre;
                this.definicion = definicion;
            }
            private uint _id;
        }
        private static uint _idCount;
        /// <summary>
        /// Guardar los conceptos en un archivo binario
        /// </summary>
        public static void Guardar()
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
        public static void Cargar()
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
}
