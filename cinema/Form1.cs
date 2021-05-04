using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int _countOfFilms;
        int _counterSendingFilms = 0;
        List<Film> _listOfFilms;
        const int MinutesOfWorkingCinema = 840;

        public Form1()
        {
            InitializeComponent();
            button_SendFilm.Visible = false;
            textBox_NameOfFilm.Visible = false;
            textBox_Duration.Visible = false;
            textBox_Timetable.ReadOnly = true;
        }

        private void button_SendFilm_Click(object sender, EventArgs e)
        {
            if(textBox_NameOfFilm.Text != "Name of a film" && textBox_Duration.Text != "Duration" && _counterSendingFilms < _countOfFilms)
            {
                _counterSendingFilms++;
                _listOfFilms.Add(new Film(textBox_NameOfFilm.Text, Convert.ToInt32(textBox_Duration.Text)));
                textBox_NameOfFilm.Text =  "Name of a film";
                textBox_Duration.Text = "Duration";
            }
            
            if (_counterSendingFilms == _countOfFilms)
            {
                button_SendFilm.Enabled = false;
                textBox_NameOfFilm.ReadOnly = true;
                textBox_Duration.ReadOnly = true;
                Timetable.ListOfFilms = _listOfFilms;
                Timetable timetable = new Timetable(MinutesOfWorkingCinema);
                timetable.CreateGraph();
                Result result = timetable.GetResult();
                textBox_Timetable.Text = result.ToString();
                
            }

        }

        private void button_SendCount_Click(object sender, EventArgs e)
        {
            if (textBox_CountOfFilms.Text != "Count of films")
            {
                _countOfFilms = Convert.ToInt32(textBox_CountOfFilms.Text);
                _listOfFilms = new List<Film>(_countOfFilms);
                button_SendCount.Enabled = false;
                button_SendFilm.Visible = true;
                textBox_CountOfFilms.ReadOnly = true;
                textBox_NameOfFilm.Visible = true;
                textBox_Duration.Visible = true;
            }
            else
            {
                textBox_CountOfFilms.Text = "Invalid duration";
            }
        }
    }
}
