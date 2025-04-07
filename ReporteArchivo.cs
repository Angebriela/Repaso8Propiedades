using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Repaso8Propiedades
{
    internal class ReporteArchivo
    {
        public void Guardar(string archivo, List<ReportePropiedad> reportes)
        {
            string json = JsonConvert.SerializeObject (reportes);
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<ReportePropiedad > Leer(string archivo)
        {
            List<ReportePropiedad > lista = new List<ReportePropiedad>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<ReportePropiedad>>(json);
            return lista;
        }
    }
}
