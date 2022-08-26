namespace MultipleCompany
{  
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate the different company monthly wage, daily wage is 50 part time
            // 4hrs and full time 8hrs  using array list using inheritance


            var multiple= new MultipleCompanyWage();
            multiple.AddCompany("ABC",100);
            multiple.AddCompany("XYZ",150);
            multiple.AddCompany("DEF",120);

            multiple.GetCompanyList();
            




            
        }
    }
}