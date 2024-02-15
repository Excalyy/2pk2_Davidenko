using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Patient
    {
        private static int count = 0;

        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; private set; }

        public Patient(string fullName, DateTime birthDate, DateTime admissionDate)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException("ФИО пациента не может быть пустым");
            }

            if (birthDate > DateTime.Today.AddYears(-18))
            {
                throw new ArgumentException("Пациенту должно быть 18 лет или больше");
            }

            if (admissionDate < DateTime.Today.AddDays(-7))
            {
                throw new ArgumentException("Дата поступления не может быть ранее, чем неделю назад");
            }

            if (count >= 10)
            {
                throw new InvalidOperationException("Отделение заполнено, невозможно принять нового пациента");
            }

            FullName = fullName;
            BirthDate = birthDate.Date;
            AdmissionDate = admissionDate.Date;
            DischargeDate = default(DateTime);

            count++;
        }

        public bool IsAdult()
        {
            return BirthDate <= DateTime.Today.AddYears(-18);
        }

        public void Discharge()
        {
            if (DischargeDate == default(DateTime))
            {
                DischargeDate = DateTime.Today;
                count--;
                Console.WriteLine($"Пациент {FullName} поступил в отделение {AdmissionDate.ToString("dd.MM.yy")}, выписан {DischargeDate.ToString("dd.MM.yy")}");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Дата рождения: {BirthDate.ToString("dd.MM.yy")}");
            Console.WriteLine($"Дата поступления: {AdmissionDate.ToString("dd.MM.yy")}");
        }

        public static void PrintPatientCount()
        {
            Console.WriteLine($"Количество пациентов в отделении: {count}");
        }
    }
}