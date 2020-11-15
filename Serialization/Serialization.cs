using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization
{
    class Serialization<T>
    {
        private string fileName;

        public Serialization(string fileNmae)
        {
            this.fileName = fileNmae;
        }

        public void binarySerialize(T t)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName + ".dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, t);
            }
        }

        public void xmlSerialize(T t)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            File.WriteAllText("salon.xml", string.Empty);
            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, t);
            }
        }

        public void jsonSerialize(T t)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string jsonString = JsonConvert.SerializeObject(t, settings);
            File.WriteAllText(fileName + ".json", jsonString);
        }

        public T binaryDeserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName + ".dat", FileMode.OpenOrCreate))
            {
                return (T)formatter.Deserialize(fs);
            }
        }

        public T xmlDeserialize()
        {
            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                return (T)formatter.Deserialize(fs);
            }
        }

        public T jsonDeserialize()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string jsonString = File.ReadAllText(fileName + ".json");
            return JsonConvert.DeserializeObject<T>(jsonString, settings);
        }
    }
}
