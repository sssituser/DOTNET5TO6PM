using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    interface ILoan
    {
        void LoanType();

        void RateOfIntrest();

    }
    class HomeLoan : ILoan
    {
        public void LoanType()
        {
            Console.WriteLine("Hii,This is HomeLoan");
        }
        public void RateOfIntrest()
        {
            Console.WriteLine("Hii, This is Rate of intrest in Home loan");
        }
    }
    class PersonalLoan : ILoan
    {
        public void LoanType()
        {
            Console.WriteLine("Hii, I'm personal loan");
        }
        public void RateOfIntrest()
        {
            Console.WriteLine("rate of intrest from Personal Loan");
        }
    }
    class GoldLoan : ILoan
    {
        public void LoanType()
        {
            Console.WriteLine("This is gold loan");
        }
        public void RateOfIntrest()
        {
            Console.WriteLine("Gold loan has x rate of intrest");
        }
    }
    internal class HierarchicalInheritance
    {
        static void Main(string[] args)
        {
             HomeLoan homeLoan=new HomeLoan();
            homeLoan.LoanType();
            homeLoan.RateOfIntrest();
            Console.WriteLine();

            PersonalLoan personalLoan=new PersonalLoan();
            personalLoan.LoanType();
            personalLoan.RateOfIntrest();
            Console.WriteLine();

            GoldLoan goldLoan=new GoldLoan();
            goldLoan.LoanType();
            goldLoan.RateOfIntrest();
        }
    }
}
