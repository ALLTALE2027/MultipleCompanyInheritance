using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleCompany
{
    internal class CompanyWage
    {
        public string company;
        private int DAILY_WAGE = 50;
        private const int PART_TIME = 2;
        private const  int FULL_TIME = 1;
        public int totalWorkingHrs;
        public int totalWage = 0;


        public void  Company(string company, int totalWorkingHours)
        {
            this.company = company;
            this.totalWorkingHrs = totalWorkingHours;
        }

        public void WageCalculation()
        {
            int empHrs;
            int dailyWage = 0;
            int totalNoOfHrs = 0;
            int totalWorkingDays = 0;

            Random random = new Random();
            while (totalWorkingDays < 30 && totalNoOfHrs <= totalWorkingHrs)
            {
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME :
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalNoOfHrs += empHrs;
                totalWorkingDays++;
            }
            totalWage =totalNoOfHrs*DAILY_WAGE;

        }

        
    }
}
