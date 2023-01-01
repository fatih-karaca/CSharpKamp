using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _04ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------- DEĞER TİPLİ VERİ ---------------------
            
            /*
                SAYISAL veri tipleri (int,decimal,float,double,bool), DEĞER tiplerdir.
                DEĞER tipler, bellekte STACK alanında tutulurlar.
            */
            
            int num1 = 30;           // DEĞER tipli veri

            int num2 = num1;         // Bu atama işleminde num2'ye num1'in SADECE DEĞERİ (verinin kendisi) atanır ve num1 ile irtibat orada kopar.
            
            num1 = 65;               // num1'e 65 değerini atadığımızda, num2 etkilenmez. Çünkü ona num1'in referansı değil, sadece num1'in DEĞERİ olan "30" atanmıştır.

            Console.WriteLine(num2); // Dolayısıyla burada num2, "30" olarak ekrana yazdırılacaktır.



            // --------------------- REFERANS TİPLİ VERİ ---------------------

            /*
                ARRAY, CLASS ve INTERFACE ise; REFERANS tiptir.
                REFERANS tipler, NEW komutuyla oluşturulduğu anda bellekte HEAP alanında tutulurlar. Ve her birine bir REFERANS ADRES tanımlanır.
            */

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 1000, 2000, 3000 };

            numbers1 = numbers2; // numbers1'e numbers2'nin REFERANSI atandı. Artık numbers2'de yapılacak değişiklikler numbers1'de de gerçekleşir.
            
            numbers2[0] = 14;    // Bundan dolayı; numbers2'nin ilk elemanına "14" değerini atadığımızda, numbers1'in ilk elemanı da "14" olur.
            
            Console.WriteLine(numbers1[0]);


            // --------------------- (İSTİSNA) ---------------------
            
            /*
                STRING veri tipi de REFERANS tipli bir veridir. Ama atama işlemlerinde DEĞER tipli bir veri gibi davranır.
            */
            string name1 = "Fatih";
            string name2 = "Nizamettin";

            name1 = name2;
            name2 = "Tansel";

            Console.WriteLine(name1);
        }
    }
}