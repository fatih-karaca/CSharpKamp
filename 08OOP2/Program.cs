using System;

namespace _08OOP2
{
    class Program
    {
        static void Main(string[] args) 
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "00000014";
            customer1.IdentityNumber = "12345678901";
            customer1.FirstName = "Fatih";
            customer1.LastName = "Karaca";
            
            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "00000029";
            customer2.IdentityNumber = "12345678902";
            customer2.FirstName = "Ahmet Salih";
            customer2.LastName = "Kocatepe";

            CorporateCustomer customer3 = new CorporateCustomer();
            customer3.Id= 3;
            customer3.CustomerNumber = "00000073";
            customer3.CompanyName = "Kuzey İnşaat San.Ltd.Şti.";
            customer3.TaxNumber = "1234567890";

            CorporateCustomer customer4 = new CorporateCustomer();
            customer4.Id = 4;
            customer4.CustomerNumber = "00000099";
            customer4.CompanyName = "Çapa Denizcilik A.Ş.";
            customer4.TaxNumber = "1234567891";

            Customer customer5 = new IndividualCustomer();

            Customer customer6 = new CorporateCustomer();
        }
    }
}