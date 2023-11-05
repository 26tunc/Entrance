using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen istediğiniz şehri seçiniz");
            Console.WriteLine("1)İstanbul");
            Console.WriteLine("2)Ankara");
            Console.WriteLine("3)Eskişehir");
            string sehir = Console.ReadLine();

            if (sehir =="1")
            {
                //string apikey1 = "e4b7070abab1899610fd58316c8d4c53";
                string link1 = "https://api.openweathermap.org/data/2.5/weather?q=%C4%B0stanbul&lang=tr&units=metric&mode=xml&appid=e4b7070abab1899610fd58316c8d4c53" ;
                XDocument havadurumu1 = XDocument.Load(link1);
                string havasicaklik1 = havadurumu1.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum1 = havadurumu1.Descendants("weather").ElementAt(0).Attribute("value").Value;

                Console.WriteLine("İstanbul için sıcaklık =" + havasicaklik1 + "Hava durumu =" + durum1);
            }   
            else if (sehir =="2") 
            {
                string link2 = "https://api.openweathermap.org/data/2.5/weather?q=Ankara&lang=tr&units=metric&mode=xml&appid=e4b7070abab1899610fd58316c8d4c53";
                XDocument havadurumu2 = XDocument.Load(link2);
                string havasicaklik2 = havadurumu2.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum2 = havadurumu2.Descendants("weather").ElementAt(0).Attribute("value").Value;

                Console.WriteLine("Ankara için sıcaklık =" + havasicaklik2 + "Hava durumu =" + durum2);

            }

            else if (sehir =="3")
            {

            
            string apikey = "e4b7070abab1899610fd58316c8d4c53";
            string link = "https://api.openweathermap.org/data/2.5/weather?q=Eskişehir&lang=tr&units=metric&mode=xml&appid=" + apikey;

            XDocument havadurumu = XDocument.Load(link);

            string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            Console.WriteLine("Eskişehir için sıcaklık = " + havasicaklik + " Hava Durumu = " + durum);
             }

            else
            {
                Console.WriteLine("Hatalı yada yanlış tuşlama");
            }


    }
    }
}
