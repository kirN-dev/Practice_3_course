using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibraryArray
{
    public class SaveSystem
    {
        private readonly BinaryFormatter _formatter = new BinaryFormatter();

        public void Save(object data, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                _formatter.Serialize(stream, data);
            }
        }

        public object Open(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException();
            }

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
               return _formatter.Deserialize(stream);
            }
        }
    }
}