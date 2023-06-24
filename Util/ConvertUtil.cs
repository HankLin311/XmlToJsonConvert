using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ConvertJson.Util
{
    internal class ConvertUtil
    {
        private readonly Type[] convertDocument;

        public ConvertUtil(Type[] _convertDocument) 
        {
            convertDocument = _convertDocument;
        }

        /// <summary>
        /// JSON to XML
        /// </summary>
        internal string JsonToXml(string listClass, string txtSource)
        {
            Type t = convertDocument.Single(x => x.FullName == listClass);
            object r = JsonConvert.DeserializeObject(txtSource, t);
            XmlSerializer serializer = new XmlSerializer(t);
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, r);
            return writer.ToString();
        }

        /// <summary>
        /// XML to JSON
        /// </summary>
        internal string XmlToJson(string listClass, string txtSource)
        {
            Type t = convertDocument.Single(x => x.FullName == listClass);
            string xmlString = txtSource;
            XmlSerializer serializer = new XmlSerializer(t);
            object obj = Activator.CreateInstance(t);
            using (StringReader reader = new StringReader(xmlString))
            {
                obj = serializer.Deserialize(reader);
            }
            return JsonConvert.SerializeObject(obj);
        }
    }
}