using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp3
{
    class Result
    {

        public int EmptyPlace;

        public List<Film> ListCurrentFilms;

        public Result(int emptyPlace, List<Film> currentBoxes)
        {
            EmptyPlace = emptyPlace;
            ListCurrentFilms = currentBoxes;
        }


        public String ToString()
        {
            int startHours = 10;
            int startMinutes = 0;
            int endHours;
            int endMinutes;
            String str = "";
            foreach(Film film in ListCurrentFilms)
            {
                str += startHours + ":";
                if(startMinutes == 0)
                {
                    str += "00 - ";
                }
                else
                {
                    str += startMinutes + " - ";
                }

                endHours = startHours + film.Duration / 60;
                endMinutes = startMinutes + film.Duration % 60;
                str +=  endHours + ":";
                if (endMinutes == 0)
                {
                    str += "00";
                }
                else
                {
                    str += endMinutes + "";
                }
                str += " " + film.Name + Environment.NewLine;
                startHours = endHours;
                startMinutes = endMinutes;
            }

            return str;
        }
    }
}
