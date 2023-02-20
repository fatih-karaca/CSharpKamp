using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07GenericsIntro
{
    class MyList<T>         // Generic Class'ı oluşturduk.
    {
        T[] items;         // Belleğin STACK bölümünde T tipinde items dizisini oluşturduk.
        public MyList()         // CONSTRUCTOR Metodu
        {
            items = new T[0];         // Belleğin HEAP bölümünde 0 elemanlı items dizisini newleyerek yeni bir referans adresi tanımlandı.
        }
        public void Add(T item)
        {
            T[] tempArray;         // "tempArray" adında geçici bir T dizisi oluşturuldu.
            
            tempArray = items;         // Ve ona items'ın referans adresi atandı.

            items = new T[items.Length + 1];         // T tipinde bir eleman sayısı bir fazla dizi oluşturuldu. items'a yeni oluşturulan referans adresi atandı. (Yeni referans atanınca items'ın içeriği sıfırlandı.)

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];         // tempArray'e emanet edilen dizi elemanları yeniden items'a tanımlandı.
            }

            items[items.Length-1] = item;         // items'ın sonuncu elemanına item'ı atadık.
        }

        public int Length         // 
        { 
            get { return items.Length; } 
        }
       
        public T[] Items 
        { 
            get { return items;} 
        }
    }
}