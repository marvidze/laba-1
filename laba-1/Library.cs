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
        private string _addres = "";
        private string _numberOfPhone = "";
        private float _rating = 0;
        private int _countOfBooks = 0;
        private int _countOfSeats = 0;
        private int _id;
        private static int _countOfObjects = 0;
        private static List<Library> _objectList = new List<Library>();

        public string Name { get => _name; set => _name = value; }
        public string Addres {  get => _addres == "" ? throw new LibraryException("Отсутствует значение!") : _addres; 
            set => _addres = value; }
        public string NumberOfPhone { get => _numberOfPhone == "" ? throw new LibraryException("Отсутствует значение!") : _numberOfPhone;
            set => _numberOfPhone = value; }
        public float Rating { get => _rating; set => _rating = value; }
        public int CountOfBooks { get => _countOfBooks; set => _countOfBooks = value; }
        public int CountOfSeats { get => _countOfSeats; set => _countOfSeats = value; }
        public int Id { get => _id; set => _id = value; }
        public static List<Library> ObjectList { get => _objectList; set => _objectList = value; }
        public static int CountOfObjects { get => _countOfObjects; set => _countOfObjects = value; }

        /// <summary>
        /// Конструктор по-умолчанию для класса Library
        /// </summary>
        public Library()
        {
            _countOfObjects++;
            _id = _countOfBooks;
            _name = "Библиотека №" + _countOfObjects.ToString();
        }
        /// <summary>
        /// Конструктор с одним параметром для класса Library 
        /// </summary>
        /// <param name="name">Имя библиотеки</param>
        public Library(string name)
        {
            _countOfObjects++;
            _name = name;
        }
        /// <summary>
        /// Конструктор с двумя параметрами для класса Library 
        /// </summary>
        /// <param name="name">Имя библиотеки</param>
        /// <param name="addres">Адрес библиотеки</param>
        public Library(string name, string addres) : this(name) 
        { 
            _countOfObjects++;
            _addres = addres;
        }

        /// <summary>
        /// Конструктор со всеми параметрами для класса Library
        /// </summary>
        /// <param name="name">Имя библиотеки</param>
        /// <param name="addres">Адрес библиотеки</param>
        /// <param name="numberOfPhone">Номер телефона библиотеки</param>
        /// <param name="rating">Рейтинг библиотеки</param>
        /// <param name="countOfBooks">Количество книг в библиотеке</param>
        /// <param name="countOfSeats">Количество мест в читальном зале</param>
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

        public static void IWantToException(int count)
        {
            if (count > 1000)
            {
                throw new StackOverflowException("Стек переполнен!");
            }
            IWantToException(count+1);
        }
    }
}
