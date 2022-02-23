using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace Monitoring
{
    [Serializable]
    public class Settings
    {
        [XmlElement("OPCURL")]
        public String OPCURL { get; set; }
        [XmlElement("TagRamp1")]
        public String TagRamp1 { get; set; }
        [XmlElement("TagRandom1")]
        public String TagRandom1 { get; set; }
        [XmlElement("TagSine1")]
        public String TagSine1 { get; set; }

        public Settings()
        {
            OPCURL = "OPCURL";
            TagRamp1 = "TagRamp1";
            TagRandom1 = "TagRandom1";
            TagSine1 = "TagSine1";
        }

        public String SerializeToString()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
            StringWriter stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, this);
            return stringWriter.ToString();
        }

        public void DeserialiseFromString(String stringData)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
            using (TextReader reader = new  StringReader(stringData))
            {
                Settings temp = (Settings)xmlSerializer.Deserialize(reader);
                this.OPCURL = temp.OPCURL;
                this.TagRamp1 = temp.TagRamp1;
                this.TagRandom1 = temp.TagRandom1;
                this.TagSine1 = temp.TagSine1;
            }
        }

        public void Load()
        {
            String dataFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            dataFile = Path.Combine(dataFile, "settings.dat");
            if (File.Exists(dataFile))
            {
                String serializedString = File.ReadAllText(dataFile);
                this.DeserialiseFromString(serializedString);
            }
        }

        public void Save()
        {
            String dataFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            dataFile = Path.Combine(dataFile, "settings.dat");
            String serializedString = this.SerializeToString();
            File.WriteAllText(dataFile, serializedString);
        }
    }
}
