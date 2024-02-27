﻿using System;
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
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _duration = value;
            }
        }

        public Song(string name, string author, int duration)
        {
            Name = name;
            Author = author;
            Duration = duration;
        }

        public Song() { }
    }
}
