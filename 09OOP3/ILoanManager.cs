using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09OOP3
{
    interface ILoanManager           // Operasyonel metodlar oluşturacağımız zaman, ebeveyn olarak CLASS yerine INTERFACE kullanılırız.
                                     // Buradaki Calculate metodunu bu Interface'i implemente ettiğimiz bütün sınıflarda farklı işlemleri yapcak şekilde tanımlayabiliriz.
    {
        public void Calculate();
    }
}
