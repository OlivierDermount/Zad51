
using System.IO;
using System.Xml.Serialization;

namespace StudentsDiary
{
    
    public class FileHelper<T> where T : new()
    {
        private string _filePath;
        public int _studentId;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T students)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (T)serializer.Deserialize(streamReader);
                streamReader.Close();
                return students;
            }
        }
        /*   public List<string> DoItemsKlasa(List<Student> students, string wstawka)
             {
             var itemId = students.Count();

                 var itemKlasa = new List<string>();

                 for (int i = 0; i < itemId; i++)
                 {  
                     itemKlasa.Add(students[i].Klasa);
                 }
                var itemsKlasa = itemKlasa.Distinct().ToList();
              
            itemsKlasa.Add(wstawka);
            return itemsKlasa;
            }
            */
    }
}

