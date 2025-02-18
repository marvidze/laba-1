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

        /// <summary>
        /// Конструктор по-умолчанию для класса Library
        /// </summary>
        public Library()
        {
            CountOfObjects++;
            Id++;
            Name = "Библиотека №" + CountOfObjects.ToString();
        }
        /// <summary>
        /// Конструктор с одним параметром для класса Library 
        /// </summary>
        /// <param name="name">Имя библиотеки</param>
        public Library(string name)
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

        /// <summary>
        /// Метод для переполнения стека
        /// </summary>
        /// <param name="count"></param>
        /// <exception cref="StackOverflowException"></exception>
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
