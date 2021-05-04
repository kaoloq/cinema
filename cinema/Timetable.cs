using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    class Timetable
    {
        public static List<Film> ListOfFilms;
     
        int _emptyTime;
        List<Film> _listOfCurrentFilms;
        List<Timetable> _next;

        public Timetable( int emptyTime, List<Film> listOfCurrentFilms = null) 
        {
            if(listOfCurrentFilms == null)
            {
                _listOfCurrentFilms = new List<Film>();
            }
            else
            {
                _listOfCurrentFilms = listOfCurrentFilms;
            }

            _emptyTime = emptyTime;
            _next = new List<Timetable>();
        }

        public void CreateGraph()
        {
            foreach (Film film in ListOfFilms)
            {
                if (_emptyTime >= film.Duration)
                {                    
                    List<Film> tmpFilms = new List<Film>();
                    foreach (Film currentFilm in _listOfCurrentFilms)
                    {
                        tmpFilms.Add(new Film(currentFilm));
                    }
                    tmpFilms.Add(new Film(film));
                    Timetable timetable = new Timetable( _emptyTime - film.Duration, tmpFilms);
                    _next.Add(timetable);
                    timetable.CreateGraph();
                }
            }
               
        }

        public void WriteGraph(TextBox textBox_timetable)
        {
            if (_next.Count == 0)
            {
                foreach (Film film in _listOfCurrentFilms)
                {
                    textBox_timetable.Text += film.Name + " ";
                }
            }
            else
            {
                foreach (Timetable timetable in _next)
                {
                    timetable.WriteGraph(textBox_timetable);
                }
            }
        }


        public Result GetResult()
        {
            if (_next.Count == 0)
            {
                return new Result(_emptyTime, _listOfCurrentFilms);
            }
            else
            {
                List<Result> listResults = new List<Result>();
                foreach (Timetable timetable in _next)
                {
                    listResults.Add(timetable.GetResult());
                }

                Result minResult = listResults[0];
                int maxUnigueFilms = 0;
                foreach (Result result in listResults)
                {
                    int counterUnigueFilms = CountUnigueFilms(result.ListCurrentFilms);
                    if(maxUnigueFilms < counterUnigueFilms)
                    {
                        minResult = result;
                        maxUnigueFilms = counterUnigueFilms;
                    }
                    else 
                    {
                        if (counterUnigueFilms == maxUnigueFilms)
                        {
                            if (minResult.EmptyPlace > result.EmptyPlace)
                            {
                                minResult = result;
                            }
                        }
                    }

                }

                return minResult;
            }
        }

        private int CountUnigueFilms(List<Film> listFilms)
        {
            int counter = 0;
            foreach (Film film in ListOfFilms)
            {
                if (listFilms.Contains(film))
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
