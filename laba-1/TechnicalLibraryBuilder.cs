using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class TechnicalLibraryBuilder : ILibraryBuilder
    {
        private Library _library = new Library();

        /// <summary>
        /// Задаёт имя библиотеки
        /// </summary>
        /// <param name="name">имя</param>
        /// <returns></returns>
        public ILibraryBuilder SetName(string name)
        {
            _library.Name = name;
            return this;
        }

        /// <summary>
        /// Задаёт адрес библиотеки
        /// </summary>
        /// <param name="address">адрес</param>
        /// <returns></returns>
        public ILibraryBuilder SetAddress(string address)
        {
            _library.Addres = address;
            return this;
        }

        /// <summary>
        /// Задаёт номер телефона библиотеки
        /// </summary>
        /// <param name="address">номер телефона</param>
        /// <returns></returns>
        public ILibraryBuilder SetNumberOfPhone(string numberOfPhone)
        {
            _library.NumberOfPhone = numberOfPhone;
            return this;
        }

        /// <summary>
        /// Задаёт рейтинг библиотеки
        /// </summary>
        /// <param name="address">рейтинг</param>
        /// <returns></returns>
        public ILibraryBuilder SetRating(float rating)
        {
            _library.Rating = rating;
            return this;
        }

        /// <summary>
        /// Задаёт количество книг библиотеки
        /// </summary>
        /// <param name="address">количество книг</param>
        /// <returns></returns>
        public ILibraryBuilder SetCountOfBooks(int countOfBooks)
        {
            _library.CountOfBooks = countOfBooks;
            return this;
        }

        /// <summary>
        /// Задаёт количество мест в читальном зале библиотеки
        /// </summary>
        /// <param name="address">количество мест в читальном зале</param>
        /// <returns></returns>
        public ILibraryBuilder SetCountOfSeats(int countOfSeats)
        {
            _library.CountOfSeats = countOfSeats;
            return this;
        }

        /// <summary>
        /// Задаёт тип библиотеки
        /// </summary>
        /// <returns></returns>
        public ILibraryBuilder SetTypeOfLibrary()
        {
            _library.TypeOfLibrary = "Техническая";
            return this;
        }

        /// <summary>
        /// Создаёт объект Library 
        /// </summary>
        /// <returns></returns>
        public Library Build()
        {
            return _library;
        }
    }
}
