using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace sınıflarVeNesneler
//{
//    internal class Müşteri
//    {
//        public int id;
//        public string name;
//        public string surname;
//        public string city;
//    }
//}

// Kapsülleme 

namespace sınıflarVeNesneler
{
    internal class Müşteri
    {
        public int id;
        private string name;
        public string surname;
        public string city;

        public string Name { get => name; set => name = value.ToLower(); }
        public string Surname { 
            get => surname; 
            set => surname = value.ToUpper(); }

        /* CTRL + R +R  -> APPLY 
         * Bir harfi büyük olmalı 
         */

    }
}