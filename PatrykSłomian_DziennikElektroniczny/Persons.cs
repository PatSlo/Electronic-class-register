using System.Windows.Forms;

namespace PatrykSłomian_DziennikElektroniczny
{

    public abstract class Person
    { 
        private int _id;
        private string _firstName;
        private string _name;
        private DateTime _birthDate;
        public string _personalIDNumber;
        private string _sex;
        private string _placeOfResidence;
        private string _postcode; 
        private string _street; 
        private string _eMail;
        protected Bitmap _photo;

        private static int _noOfPersons = 0;

        public Bitmap Photo
        {
            get => _photo;
        }

        public Person()
        {
            _noOfPersons += 1;
            _id = _noOfPersons;
            _firstName = "-";
            _name = "-";
            _personalIDNumber = "00000000000";
            _sex = "-";
            _birthDate = DateTime.Now;
            _placeOfResidence = "-";
            _postcode = "-";
            _street = "-";
            _eMail = "-";
        }

        public Person(string firstName, string name, DateTime birthDate, string personalIDNumber,
                      string placeOfResidence, string postcode, string street, string sex, string eMail,
                      Bitmap photo)
        {
            _noOfPersons += 1;
            _id = _noOfPersons;
            _firstName = firstName;
            _name = name;
            _sex = sex;
            _birthDate = birthDate;
            _personalIDNumber = personalIDNumber;
            _placeOfResidence = placeOfResidence;
            _postcode = postcode;
            _street = street;
            _eMail = eMail;
            _photo = photo;
        }
 
        public Person(Person p)
        {
            _noOfPersons += 1;
            _id = _noOfPersons;
            _firstName = p._firstName;
            _name = p._name;
            _sex = p._sex;
            _birthDate = p._birthDate;
            _personalIDNumber = p._personalIDNumber;
            _placeOfResidence = p._placeOfResidence;
            _postcode = p._postcode;
            _street = p._street;
            _eMail = p._eMail;
            _photo = p._photo;
        }

        public virtual List<string> GetInfo()
        {
            List<string> info = new List<string>();               
            info.Add("Id:\t\t" + _id);
            info.Add("Imię i nazwisko:\t" + _firstName + " " + _name);
            info.Add("Płeć: \t\t" + _sex);
            info.Add("Rok urodzenia:\t" + _birthDate);
            info.Add("Wiek:\t\t" + CalculateAge());
            info.Add("PESEL:\t\t" + _personalIDNumber);
            info.Add("Miejscowość:\t" + _placeOfResidence);
            info.Add("Ulica:\t\t" + _street);
            info.Add("Kod pocztowy:\t" + _postcode);
            info.Add("Adres e-mail: \t" + _eMail);              

            return info;
        }        

        private int CalculateAge()
        {
            return DateTime.Now.Year - _birthDate.Year;
        }
        public static string operator ==(Person p1, Person p2)
        {
            if (p1._personalIDNumber == p2._personalIDNumber)
            {
                return "PESEL-e są takie same";
            }
            else
                return "";
        }

        public static string operator !=(Person p1, Person p2)
        {
            if (p1._personalIDNumber != p2._personalIDNumber)
            {
                return "PESEL-e nie są takie same";
            }
            else
                return "";
        }
    }
}
