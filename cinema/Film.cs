using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp3
{
    class Film
    {
        public String Name { get; set; }
        public int Duration { get; set; }

        public Film(string name, int duration)
        {
            Duration = duration;
            Name = name;
        }

        public Film(Film film)
        {
            Name = film.Name;
            Duration = film.Duration;
        }

        public override bool Equals(object obj)
        {
            Film film = (Film)obj;
            if(Name == film.Name && Duration == film.Duration)
            {
                return true;
            }

            return false;
        }
    }
}
