using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MultipleCompany
{
    internal class MultipleCompanyWage:CompanyWage
    {
        private List<CompanyWage> _companyWages;
        public MultipleCompanyWage() 
        {
           _companyWages= new List<CompanyWage>();
        }


        public void AddCompany(string company, int totalWorkingHours)
        {  
           CompanyWage obj=new CompanyWage();
           obj.Company(company,totalWorkingHours);
           obj.WageCalculation();
           _companyWages.Add(obj);
        }
        public void GetCompanyList()
        {
            foreach (var company in _companyWages)
            {
                Console.WriteLine($"Total Monthly Wage for company {company.company} is {company.totalWage}");
            }
        }
    }
}
