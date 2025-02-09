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
        private string _name;
        private string _addres = "Отсутствует значение";
        private string _numberOfPhone = "Отсутствует значение";
        private float _rating = 0;
        private int _countOfBooks = 0;
        private int _countOfSeats = 0;
        private int _id;
        private static int _countOfObjects = 0;
        public static List<Library> objectList = new List<Library>();

        public string Name { get => _name; set => _name = value; }
        public string Addres { get => _addres; set => _addres = value; }
        public string NumberOfPhone { get => _numberOfPhone; set => _numberOfPhone = value; }
        public float Rating { get => _rating; set => _rating = value; }
        public int CountOfBooks { get => _countOfBooks; set => _countOfBooks = value; }
        public int CountOfSeats { get => _countOfSeats; set => _countOfSeats = value; }
        public int Id { get => _id; set => _id = value; }

        public Library()
        {
            _countOfObjects++;
            _id = _countOfBooks;
            _name = "Библиотека №" + _countOfObjects.ToString();
        }

        public Library(String name)
        {
            _countOfObjects++;
            _name = name;
        }

        public Library(String name, String addres)
        {
            _countOfObjects++;
            _name = name;
            _addres = addres;
        }

        public Library(string name, string addres, string numberOfPhone, float rating, int countOfBooks, int countOfSeats) : this(name, addres)
        {
            _countOfObjects++;
            _numberOfPhone = numberOfPhone;
            _rating = rating;
            _countOfBooks = countOfBooks;
            _countOfSeats = countOfSeats;
        }

        /// <summary>
        /// Переопределённый метод toString().
        /// </summary>
        /// <returns>Возвращает строку, содержащую всю информацию о библиотеке.</returns>
        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
