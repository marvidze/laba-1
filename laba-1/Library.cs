using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public abstract class Library
    {
        public string Name { get; set; }
        public string Addres { get; set; } = "отсутствует значение";
        public string NumberPhone { get; set; } = "отсутствует значение";
        public float Rating { get; set; } = 0;
        public int CountBooks { get; set; } = 0;
        public int CountSeats { get; set; } = 0;
        public int Id { get; set; } = 0;
        public bool IsOpen { get; private set; } = false;
        public static int CountObjects { get; set; } = 0;
        public string LevelLibrary { get; set; } = "отсутствует значение";
        public ItypeLibrary TypeLibrary { get; set; }


        /// <summary>
        /// Конструктор по умолчанию класса Library
        /// </summary>
        public Library()
        {
            CountObjects++;
            Id++;
            Name = "Библиотека №" + CountObjects.ToString();
        }

        /// <summary>
        /// Конструктор с параметрами класса Library.
        /// </summary>
        /// <param name="Addres"></param>
        /// <param name="NumberPhone"></param>
        /// <param name="Rating"></param>
        /// <param name="CountBooks"></param>
        /// <param name="CountSeats"></param>
        /// <param name="TypeLibrary"></param>
        public Library(string Name, string Addres, string NumberPhone, float Rating, int CountBooks, int CountSeats, string LevelLibrary, ItypeLibrary TypeLibrary)
        {
            this.Name = Name;
            this.Addres = Addres;
            this.NumberPhone = NumberPhone;
            this.Rating = Rating;
            this.CountBooks = CountBooks;
            this.CountSeats = CountSeats;
            this.LevelLibrary = LevelLibrary;
            this.TypeLibrary = TypeLibrary;

            CountObjects++;
            Id++;
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

        public string OpenLibrary()
        {
            if (IsOpen) return "Библиотека уже открыта!";
            else
            {
                IsOpen = true;
                return "Вы открыли библиотеку!";
            }
        }

        public string CloseLibrary()
        {
            if (!IsOpen) return "Библиотека уже зыкрыта!";
            else
            {
                IsOpen = false;
                return "Вы зыкрыли библиотеку!";
            }
        }
    }
}
