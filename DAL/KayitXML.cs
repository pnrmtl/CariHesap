using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace DAL
{
   public class KayitXML<T>
    {
        public static void Kaydet(List<T> kaydedilecekSey)
        {
            XmlSerializer tercuman = new XmlSerializer(typeof(List<T>));
            string dosyaYol = typeof(T).Name +".xml";
            using (FileStream fs = new FileStream(dosyaYol, FileMode.OpenOrCreate))
                tercuman.Serialize(fs, kaydedilecekSey);
        }
        public static void Kaydet(T kaydedilecekSey, string dosyaYolu)
        {
            XmlSerializer tercuman = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(dosyaYolu, FileMode.OpenOrCreate))
                tercuman.Serialize(fs, kaydedilecekSey);
        }
        public static List<T> Oku()
        {
            XmlSerializer tercuman = new XmlSerializer(typeof(List<T>));

            string dosyaYol = typeof(T).Name + ".xml";
            if (File.Exists(dosyaYol))
            {
                byte[] okunan = File.ReadAllBytes(dosyaYol);
                object o = "";
                using(MemoryStream ms = new MemoryStream(okunan))
                   o = tercuman.Deserialize(ms);
                
                return (List<T>)o;
            }
            else return null;
        }
        public static T YedektenOku(string dosyaYolu)
        {
            XmlSerializer tercuman = new XmlSerializer(typeof(T));
            byte[] okunan = File.ReadAllBytes(dosyaYolu);
            object o = "";
            using (MemoryStream ms = new MemoryStream(okunan))
                o = tercuman.Deserialize(ms);

            return (T)o;
        }
    }
}
