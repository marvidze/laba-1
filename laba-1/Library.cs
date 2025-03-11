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
    public class Library
    {
        public string Name { get; set; }
        public string Addres { get; set; } = "Отсутствует значение";
        public string NumberOfPhone { get; set; } = "Отсутствует значение";
        public float Rating { get; set; } = 0;
        public int CountOfBooks { get; set; } = 0;
        public int CountOfSeats { get; set; } = 0;
        public int Id { get; set; } = 0;
        public string TypeOfLibrary { get; set; }
        public static int CountOfObjects { get; set; } = 0;

        

        /// <summary>
        /// Конструктор по умолчанию класса Library
        /// </summary>
        public Library()
        {
            CountOfObjects++;
            Id++;
            Name = "Библиотека №" + CountOfObjects.ToString();
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
