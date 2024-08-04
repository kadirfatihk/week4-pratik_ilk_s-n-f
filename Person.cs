using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_pratik_ilk_sınıf
{
    public class Person
    {
        private string name;
        private string surname;
        private int birthday;

        // isim tanımlama
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // soyisim tanımlama
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        // doğum tarihi tanımlama
        public int Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if (value >= 1940 && value <=2017)
                    birthday = value;
            }
        }
        // öğretmen bilgilerini yazdırma metodu
        public void TeacherDisplay()
        {
            Console.WriteLine($"Öğretmen: {name} {surname} {birthday}");
        }

        // öğrenci bilgilerini yazdırma metodu
        public void StudentDisplay()
        {
            Console.WriteLine($"Öğrenci: {name} {surname} {birthday}");

        }
    }
}
