﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DAL
{
    public class KayitJSON<T>
    {
        static JavaScriptSerializer tercuman = new JavaScriptSerializer();
        public static void Kaydet(List<T> kaydedilecekSey)
        {
            string JSONyazi = tercuman.Serialize(kaydedilecekSey);
            string dosyaYol = typeof(T).Name;
            File.WriteAllText(dosyaYol + ".json", JSONyazi);
        }
        public static void Kaydet(T kaydedilecekSey, string dosyaYolu)
        {
            string JSONyazi = tercuman.Serialize(kaydedilecekSey);
            File.WriteAllText(dosyaYolu, JSONyazi);
        }
        public static List<T> Oku()
        {
            string dosyaYol = typeof(T).Name + ".json";
            if (File.Exists(dosyaYol))
            {
                string JSONyazi = File.ReadAllText(dosyaYol);
                return tercuman.Deserialize<List<T>>(JSONyazi);
            }
            else return null;
        }
        public static T YedektenOku(string dosyaYolu)
        {
            string okunan = File.ReadAllText(dosyaYolu);
            return tercuman.Deserialize<T>(okunan);
        }
    }
}
