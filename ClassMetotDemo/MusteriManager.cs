﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.Adi + " " + musteri.Soyadi);
           
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Adi + " " + musteri.Soyadi);
        }

    }
}
