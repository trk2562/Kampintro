﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri : " +musteri.Id + " " + musteri.Adi+ " " + musteri.SoyAd);
        }
     
    }
}
