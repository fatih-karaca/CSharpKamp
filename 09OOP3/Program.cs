using System;
using System.Collections.Generic;

namespace _09OOP3
{
    class Program
    {
        static void Main(string[] args) 
        {
            ILoanManager personalLoanManager = new PersonalLoanManager();
            ILoanManager vehicleLoanManager= new VehicleLoanManager();
            ILoanManager houseLoanManager = new HouseLoanManager();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Apply(personalLoanManager);           // Burada Apply() metoduna ILoanManager arayüzünün referansını tuttuğu herhangi bir LoanManager nesnesini gönderebiliriz.
                                                                     // Apply metodu ile gerçekleşecek işlemler de, hangisi gönderilmiş ise onunla ilgili olan işlemler olur.

            List<ILoanManager> loanManagers= new List<ILoanManager>() {personalLoanManager };
            applicationManager.LoanPreInformation(loanManagers);
        }
    }
}