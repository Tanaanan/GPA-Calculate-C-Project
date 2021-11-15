using System;

namespace GPA_Cal
{
    class grade
    {
        public void Addline()
        {
            Console.WriteLine("---------------------------------------");
        }
        
        public void GetGrade(int _TotalCal)
        {
            Addline();
            float[] data = new float[_TotalCal];
            int count = 0;

            Console.WriteLine("Process...");
            while (count < _TotalCal)
            {
                Console.Write("Enter grade {0} : ",count+1);
                data[count] = Convert.ToSingle(Console.ReadLine());
                if (data[count] >= 0 && data[count] <= 4) count++;
                else Console.WriteLine("Error please type  onlygrade 1-4 !");
            }
            string CallClass = Calculate(data);
            Console.WriteLine(CallClass); //Call another function
        }

        private string Calculate(float[] _data)
        {
            float result = 0;
            for (int j = 0; j < _data.Length; j++)
            {
                result += _data[j];
            }
            float Calgrade = (result*4) / (_data.Length*4);
            Addline();
            Console.WriteLine("Result...");
            return $"GPA Average = {Calgrade:F2}";
        }
    }
}
