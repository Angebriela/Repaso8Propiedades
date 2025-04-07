using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Repaso8Propiedades
{
    internal class PropietarioArchivo
    {
        /*
         *  public void Guardar(string archivo, List<Empleado> empleados)
        {
            string json = JsonConvert.SerializeObject(empleados);
            System.IO.File.WriteAllText(archivo, json);

        }

        public List<Empleado> Leer(string archivo)
        {
            List <Empleado> lista = new List<Empleado>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Empleado>>(json);
            return lista;
        }
         */
        public void Guardar(string archivo, List<Propietario> propietarios)
        {
            string json = JsonConvert.SerializeObject(propietarios);
            System.IO.File.WriteAllText(archivo,json);
        }

        public List<Propietario> propietarios = new List<Propietario>();
        public List<Propietario> Leer(string archivo)
        {
            List<Propietario> lista = new List<Propietario>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Propietario>>(json);
            return lista;
        }
    }
}
