using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09OOP3
{
    class ApplicationManager
    {
        public void Apply(ILoanManager loanManager) 
        {
            loanManager.Calculate();
        }

        public void LoanPreInformation(List<ILoanManager> loanManagers)
        {
            foreach (var loanManager in loanManagers)
            {

            }
        }
    }
}
