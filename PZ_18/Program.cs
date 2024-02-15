using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var patient1 = new Patient("Иванов Иван Иванович", new DateTime(1990, 1, 1), DateTime.Today.AddDays(-5));
                var patient2 = new Patient("Петров Петр Петрович", new DateTime(2005, 5, 5), DateTime.Today.AddDays(-3));
                var patient3 = new Patient("Сидоров Сидор Сидорович", new DateTime(1985, 10, 10), DateTime.Today.AddDays(-2));

                patient1.PrintInfo();
                patient2.PrintInfo();
                patient3.PrintInfo();

                if (patient1.IsAdult())
                {
                    Console.WriteLine($"{patient1.FullName} является совершеннолетним");
                }
                else
                {
                    Console.WriteLine($"{patient1.FullName} не является совершеннолетним.");
                }

                patient1.Discharge();
                patient2.Discharge();
                patient3.Discharge();

                Patient.PrintPatientCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}