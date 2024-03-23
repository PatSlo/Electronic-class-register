using System;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PatrykSłomian_DziennikElektroniczny
{

    class Student : Person
    {
        private string _studentsClass;
        private string _opinion;
        private string _schoolBus;
        private string _conductGrade;
        public List<double> _grades = new List<double>();

        public Student() : base()
        {
            _studentsClass = "3a";
            _opinion = "Tak";
            _schoolBus = "Nie";
            _conductGrade = "Dobre";
            _grades = new List<double>();
        }

        public Student(string firstName, string name, DateTime birthDate, string personalIDNumber,
                       string placeOfResidence, string postcode, string street, string sex, string eMail,
                       string studentsClass, string opinion, string schoolBus, string conductGrade,
                       Bitmap photo, List<double> grades) : base(firstName, name, birthDate,
                       personalIDNumber, placeOfResidence, postcode, street, sex, eMail, photo)
        {
            _studentsClass = studentsClass;
            _opinion = opinion;
            _schoolBus = schoolBus;
            _conductGrade = conductGrade;
            _grades = grades;
        }

        public Student(Student s) : base(s)
        {
            _studentsClass = s._studentsClass;
            _opinion = s._opinion;
            _schoolBus = s._schoolBus;
            _conductGrade = s._conductGrade;
            _grades = s._grades;
        }

        public override List<string> GetInfo()
        {
            List<string> info2 = base.GetInfo();
            info2.Add("Klasa ucznia:\t" + _studentsClass);
            info2.Add("Zachowanie ucznia:\t" + _conductGrade);
            info2.Add("Czy dojeżdża: \t" + _schoolBus);
            info2.Add("Opinia ucznia o przystosowaniu do nauk:\t" + _opinion);
            info2.Add("Opis:" + StudentsBehavior() + StOpinion());
            info2.Add("Oceny: \t\t");
            foreach (var item in _grades)
            {
                info2.Add(item.ToString());
            }
            info2.Add("");

            return info2;
        }

        public void AddGrades(double grades)
        {
            _grades.Add(grades);
        }

        public string StudentsBehavior()
        {
            if (_conductGrade == "Wzorowe")
            {
                return "Uczeń nie sprawia żadnych problemów,wykazuje ogromną aktywność.";
            }
            else if (_conductGrade == "Bardzo dobre")
            {
                return "Uczeń nie sprawia żadnych problemów, wykazuje aktywność.";
            }
            else if (_conductGrade == "Dobre")
            {
                return "Uczeń nie sprawia żadnych problemów.";
            }
            else if (_conductGrade == "Poprawne")
            {
                return "Uczeń wykazuje się niską frekwencją.";
            }
            else if (_conductGrade == "Nieodpowiednie")
            {
                return "Uczeń zachowuje sie karygodnie, oraz ma niską frekwencje.";
            }
            else if (_conductGrade == "Naganne")
            {
                return "Zachowanie ucznia jest do poprawy, niska frekwencje oraz brak  aktywnośći.";
            }
            else
            {
                return "";
            }
        }

        public string StOpinion()
        {
            if (_opinion == "Tak")
            {
                return "Uczeń ma prawo pisać dłużej wszelakiego rodzaju formy zaliczeniowe.";
            }
            else if (_opinion == "Nie")
            {
                return "Uczeń pisze formy zaliczeniowe w czasie normalnym.";
            }
            else
            {
                return "";
            }
        }
    }
}


