using System.Xml.Serialization;
using System.Xml;

namespace AkaryakitExample.Helpers
{
    public  class ParseHelpers
    {


        public T DeserializeXml<T>(string xmlPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(xmlPath, FileMode.Open))
            {
                return (T)serializer.Deserialize(stream);
            }
        }
    }

}
