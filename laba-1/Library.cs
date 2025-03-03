using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba_1
{
    /// <summary>
    /// Класс Library представляет доступ к созданию библиотек
    /// Поля класса: 
    /// Name - имя библиотеки 
    /// Adress - адрес библиотеки
    /// NumberOfPhone - номер телефона библиотеки
    /// Rating - рейтинг библиотеки 
    /// CountOfBooks - количество книг в библиотеке 
    /// CountOfSeats - количество мест в читальном зале
    /// Id - id библиотеки
    /// CountOfObjects - количество существующих беблиотек
    /// </summary>
    public class Library
    {
        public string Name { get; set; }
        public string Addres { get ; set; } = "Отсутствует значение";
        public string NumberOfPhone { get ; set; } = "Отсутствует значение";
        public float Rating { get ; set ; } = 0;
        public int CountOfBooks { get; set; } = 0;
        public int CountOfSeats { get; set; } = 0;
        public int Id { get; set; } = 0;
        public static int CountOfObjects { get; set; } = 0;


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
            Id++;
            CountOfObjects++;
            Name = name;
        }

        public Library(String name, String addres)
        {
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
