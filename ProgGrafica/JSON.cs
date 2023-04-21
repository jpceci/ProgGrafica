using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ProgGrafica
{
    class JSON
    {
        public static void Save(string path, Object objeto)
        {
            string output = JsonConvert.SerializeObject(objeto);
            File.WriteAllText(path, output);
        }
        public static Object Load(string path)
        {
            string output = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Object>(output);
        }
    }
}
