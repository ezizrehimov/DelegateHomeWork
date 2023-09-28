using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Exams> exams = new List<Exams>();

            Console.WriteLine("Nece eded Exam elave etmek isteyirsiz?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Exam N" + i + 1);

                Console.Write("Ad: ");
                string studentName = Console.ReadLine();
                Console.Write("Point: ");
                int point = int.Parse(Console.ReadLine());
                Console.Write("Movzu: ");
                string subject = Console.ReadLine();
                Console.Write("Baslangic Tarixi (YYYY-MM-DD HH:MM): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Bitme Tarixi (YYYY-MM-DD HH:MM): ");
                DateTime endDate = DateTime.Parse(Console.ReadLine());

                exams.Add(new Exams(studentName, point, subject, startDate, endDate));
            }


            Console.WriteLine("Pointi 50den cox olanlar: ");
            foreach (var exam in exams)
            {
                if (exam.Point > 50)
                {
                    Console.WriteLine($"{exam.Student}, {exam.Subject}, ({exam.Point} point), " +
                        $"{exam.StartDate}, {exam.EndDate} ");
                }
            }

            Console.WriteLine("1 saatdan cox cekenler: ");
            foreach (var exam in exams)
            {
                TimeSpan difference = exam.StartDate - exam.EndDate;
                int totalDaysToHours = difference.Days * 24;

                if (difference.Hours + totalDaysToHours < 0)
                {
                    Console.WriteLine($"{exam.Student}, {exam.Subject}, ({(exam.EndDate - exam.StartDate).TotalHours} saat cekib)");
                }

            }
        }
    }
}
