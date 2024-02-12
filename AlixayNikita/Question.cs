using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace AlixayNikita
{
    public class Question : INotifyPropertyChanged
    {// Данные о задаче
        public string title;
        private List<string> questions;
        private List<string> answers;

        // Авто-свойства
        public string Title { get { return this.title; } }
        public List<string> Questions { get { return this.questions; } }
        public List<string> Answers { get { return this.answers; } }


        public bool IsSolved
        {
            get { return this.IsSolved; }
            set
            {
                this.IsSolved = value;
                // Если свойство меняется, вызывается метод, уведомляющий об изменении модели
                OnPropertyChanged("IsSolved");
                // Если изменено несколько значений, можно вызвать дополнительный метод
                OnPropertyChanged("Color");
            }
        }

        // Конструктор
        public Question(string title, List<string> questions, List<string> answers)
        {
            this.title = title;
            this.questions = questions;
            this.answers = answers;
        }



        // Событие, вызываемое при изменении модели
        public event PropertyChangedEventHandler PropertyChanged;

        // Метод, оповещающий ViewModel о необходимости передачи Виду новых данных
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
