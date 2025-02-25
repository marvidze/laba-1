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

        public delegate void LibraryEventHandler(Library library);
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
        public void Add(Library library)
        {
            libraries.Add(library);

            OnAddingLibrary.Invoke(library);
        }

        /// <summary>
        /// Удаление элемента из списка.
        /// </summary>
        /// <param name="library">Библиотека, которую удаляем.</param>
        /// <returns>True - элемент удалён. False - элемент не удалён.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public void Remove(Library library)
        {
            libraries.Remove(library);
            OnDeletingLibrary.Invoke(library);
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
