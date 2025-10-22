using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    interface ILoan
    {
        void RateOfIntrest();//
        void LoanType();
    }
    class HomeLoan : ILoan
    {
        public void LoanType()
        {
            Console.WriteLine("Hi Iam Home Loan");
        }
      
        public void RateOfIntrest()
        {
            Console.WriteLine("Hi Im Rate of Interest method from Home loan");
        }
    }
    class PersonalLoan : ILoan
    {
        public void LoanType()
        {
            Console.WriteLine("Hi Im Personal loan ");
        }

        public void RateOfIntrest()
        {
            Console.WriteLine("Hi Iam RaterOf Interest");
        }
    }



    internal class Class7
    {
        static void Main(string[] args)
        {
            HomeLoan homeLoan = new HomeLoan();
            homeLoan.LoanType();
            homeLoan.RateOfIntrest();

            PersonalLoan personalLoan = new PersonalLoan();
            personalLoan.LoanType();
            personalLoan.RateOfIntrest();
        }
    }
}
