using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DAL
{
    //1. KayitJSON sınıfını ekledik
    //2. Kayit<T> içindeki tüm metodları bu yeni sınıfa aktardık.
    //3. Kayit<T> statik değil

    //public  class Kayit<T> : KayitJSON<T> {   }
    public class Kayit<T> : KayitXML<T> { }
}
