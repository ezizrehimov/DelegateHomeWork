using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DelegateHomeWork
{
    internal class Exams
    {

        public string Student { get; set; }
        public int Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exams(string student, int point, string subject, DateTime startDate, DateTime endDate)
        {
            Student = student;
            Point = point;
            Subject = subject;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
