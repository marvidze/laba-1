using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba_1
{
    public class Library
    {
        private static List<Library> _objectList = new List<Library>();

        public string Name { get; set; }
        public string Addres { get ; set; } = "Отсутствует значение";
        public string NumberOfPhone { get ; set; } = "Отсутствует значение";
        public float Rating { get ; set ; } = 0;
        public int CountOfBooks { get; set; } = 0;
        public int CountOfSeats { get; set; } = 0;
        public int Id { get; set; } = 0;
        public static int CountOfObjects { get; set; } = 0;
        public static List<Library> ObjectList { get => _objectList; set => _objectList = value; }

        public Library()
        {
            CountOfObjects++;
            Id++;
            Name = "Библиотека №" + CountOfObjects.ToString();
        }

        public Library(String name)
        {
            CountOfObjects++;
            Name = name;
        }

        public Library(String name, String addres)
        {
            CountOfObjects++;
            Name = name;
            Addres = addres;
        }

        public Library(string name, string addres, string numberOfPhone, float rating, int countOfBooks, int countOfSeats) : this(name, addres)
        {
            CountOfObjects++;
            NumberOfPhone = numberOfPhone;
            Rating = rating;
            CountOfBooks = countOfBooks;
            CountOfSeats = countOfSeats;
        }

        /// <summary>
        /// Переопределённый метод toString().
        /// </summary>
        /// <returns>Возвращает строку, содержащую всю информацию о библиотеке.</returns>
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
