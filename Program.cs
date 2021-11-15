using System;

namespace GPA_Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            grade Calgrade = new grade();
            Console.Write("Enter Term that want to Calculate : ");
            int TotalCal = Convert.ToInt32(Console.ReadLine());

            Calgrade.GetGrade(TotalCal);

            Calgrade.Addline();
            
        }
    }
}
