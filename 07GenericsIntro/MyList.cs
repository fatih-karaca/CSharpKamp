using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()   // CONSTRUCTOR Metodu
        {
            items = new T[0];   // 
        }
        public void Add(T item)
        {
            T[] tempArray = items;   // "tempArray" adında geçici bir T dizisi oluşturuldu ve ona items'ın referans adresi atandı.

            items = new T[items.Length + 1];   // T tipinde bir eleman fazla dizi oluşturuldu. items'a yeni oluşturulan referans adresi atandı. (Yeni referans atanınca items'ın içeriği sıfırlandı.)

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];   // tempArray'e emanet edilen dizi elemanları yeniden items'a tanımlandı.
            }

            items[items.Length-1] = item;   // items'ın sonuncu eleman:ına item'ı atadık.
        }
    }
}