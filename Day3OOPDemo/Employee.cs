using System.Diagnostics.Contracts;

namespace Day4OOPDemo{

    class Employee{
        
        public int EmpId {get; set;}
        public string Name {get; set;} 

        public int baseSal {get;set;}


        public virtual int  CalculateSalary(int sal)
        {
            int mySal = 0;
            // net salary = salary+hra+ta+da-pf
            mySal = (sal+15000+1500-2500);
            return mySal;
        }
    }
}
