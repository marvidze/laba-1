using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class LibrariesList : IEnumerable<Library>
    {
        private List<Library> libraries = new List<Library>();

        public delegate void LibraryEventHandler();
        public event LibraryEventHandler OnAddingLibrary;
        public event LibraryEventHandler OnDeletingLibrary;

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Library this[int index]
        {
            get => libraries[index];
            set => libraries[index] = value;
        }

        /// <summary>
        /// Добавление элемента в список.
        /// </summary>
        /// <param name="library">Библиотека, которую добавляем</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public bool Add(Library library)
        {
            libraries.Add(library);
            if (libraries.Contains(library))
            {
                OnAddingLibrary.Invoke();
                return true;
            }
            return false;

            
        }

        /// <summary>
        /// Удаление элемента из списка.
        /// </summary>
        /// <param name="library">Библиотека, которую удаляем.</param>
        /// <returns>True - элемент удалён. False - элемент не удалён.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool Remove(Library library)
        {
            if (libraries.Contains(library))
            {
                return false;
            }
            libraries.Remove(library);
            OnDeletingLibrary.Invoke();
            return true;
        }

        public (int, int) IWantToComparison()
        {
            int StartTime = Environment.TickCount;
            {

            }
                return (1, 2);
        }

        public IEnumerator<Library> GetEnumerator()
        {
            return libraries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return libraries.GetEnumerator();
        }


    }
}
