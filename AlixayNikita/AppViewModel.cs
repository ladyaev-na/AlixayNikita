using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlixayNikita
{
    public class AppViewModel : INotifyPropertyChanged
    {
        private Question selectedCustomer;

        public ObservableCollection<Question> customers;

        // Конструктор
        public AppViewModel()
        {
            // Создание списка работников
            customers = new ObservableCollection<Question>()
                {
                new Question("ГЛАГОЛЫ",
                    new List<string> {"Как называется начальная форма глагола?", "Что относится к видам глагола?", "В каком наклонении глагол «читал бы»?" },
                    new List<string> {"Инфинитив", "Совершенный", "Условном" }),
                new Question("ПРИЧАСТИЯ",
                    new List<string> {"В каком времени не может находиться причастие?", "Что не относится к непостоянным признакам причастия?", "По чему не могут изменяться краткие причастия?" },
                    new List<string> {"Будущем", "Переходность", "Падежам"}),
                new Question("МЕСТОИМЕНИЯ",
                    new List<string> {"Какое местоимение относится к личным?", "К какому виду относятся местоимения «ты, он, вы»?", "Каким членом предложения не может быть местоимение?" },
                    new List<string> {"Ты", "Личные", "Обстоятельством"}),
                new Question("ПРИЛАГАТЕЛЬНЫЕ",
                    new List<string> {"Чем прилагательное чаще всего является в предложении?", "От какой части речи зависит род, число и падеж имени прилагательного?", "Какое окончание имеют прилагательные в мужском и среднем роде\nв творительном падеже?" },
                    new List<string> {"Определением", "Существительного", "ым, им"}),
                new Question("СУЩЕСТВИТЕЛЬНЫЕ",
                    new List<string> {"Каким именем существительным является фамилия человека?", "На какой вопрос отвечают неодушевленные существительные?", "На какой вопрос отвечает одушевлённое имя существительное?" },
                    new List<string> {"Собственным", "Что?", "Кто?"})
            };

        }

        public Question SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                this.selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");
            }
        }

        public ObservableCollection<Question> Customers
        {
            get
            {
                return this.customers;
            }
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
