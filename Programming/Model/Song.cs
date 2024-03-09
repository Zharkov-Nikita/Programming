using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        private string _name;
        private string _author;
        private int _duration;

        public string Name { get; set; }
        public string Author { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название. Нет ограничений.</param>
        /// <param name="author">Автор. Нет ограничений.</param>
        /// <param name="duration">Продолжительность. Не может быть отрицательным и равным 0.</param>
        public Song(string name, string author, int duration)
        {
            Name = name;
            Author = author;
            Duration = duration;
        }

        public Song() { }
    }
}
