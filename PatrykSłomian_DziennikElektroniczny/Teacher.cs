using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrykSłomian_DziennikElektroniczny
{
    class Teacher : Person
    {
        private string _degree;
        private string _subject;
        private double _salary;
        private DateTime _dateOfEmployment;

        public Teacher() : base()
        {
            _degree = "mgr";
            _subject = "Matematyka";
            _salary = 2600.5;
            _dateOfEmployment = DateTime.Now;
        }

        public Teacher(string firstName, string name, DateTime birthDate, string personalIDNumber,
                       string placeOfResidence, string postcode, string street, string sex, string eMail,
                       string degree, string subject, double salary, DateTime dateOfEmployment, Bitmap photo)
                       : base(firstName, name, birthDate, personalIDNumber, placeOfResidence, postcode, street,
                             sex, eMail, photo)
        {
            _degree = degree;
            _subject = subject;
            _salary = salary;
            _dateOfEmployment = dateOfEmployment;
        }

        public Teacher(Teacher t) : base(t)
        {
            _degree = t._degree;
            _subject = t._subject;
            _salary = t._salary;
            _dateOfEmployment = t._dateOfEmployment;
        }

        public override List<string> GetInfo()
        {
            List<string> info2 = base.GetInfo();
            info2.Add("Stopień naukowy:\t" + _degree);
            info2.Add("Przedmiot:\t" + _subject);
            info2.Add("Zarobki nauczyciela:\t" + _salary + "zł");
            info2.Add("Zarobki z wliczonym podatkiem:\t" + CalculateSalary() + "zł");
            info2.Add("Data zatrudnienia:\t" + _dateOfEmployment);
            info2.Add("Lat pracy:\t " + CalculateWorkTime());
            info2.Add("");

            return info2;
        }

        private int CalculateWorkTime()
        {
            return DateTime.Now.Year - _dateOfEmployment.Year;
        }

        private double CalculateSalary()
        {
            return _salary * 1.23;
        }
    }
}
