using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlixayNikita
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void play(object sender, RoutedEventArgs e)
        {
            play gw = new play();
            gw.Show();
            Close();
        }

        private void rules(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В этой игре вы узнаете о нескольких правил правильного правописания местоимений в русском языке!\nМы старались подобрать лёгкие варианты вопросов, и что смогли, то и сделали.\nПравила игры:\n1) Для начала игры нажмите кнопку \"Играть\".\n2) Выберите тему опроса (их всего 5).\n3) Ответьте на три вопроса по каждой теме.\n4) На вопросы отвечать с большой буквы, без всяких знаков препинания.\n5) Желаем удачи в нашей мини-игре \"Последний ответ\"!!!", "Руководство пользователя:");
        }

        private void RollUp(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Max(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
            label1.FontSize = 60;
            btn1.Width = btn2.Width = btn3.Width = 1500;
            btn1.Height = btn2.Height = btn3.Height = 130;
            btn1.Margin = new Thickness(0, 0, 0, 10);
            btn2.Margin = new Thickness(0, 300, 0, 0);
            btn3.Margin = new Thickness(0, 600, 0, 0);
            btn1.FontSize = btn2.FontSize = btn3.FontSize = 60;
        }

        private void Min(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            label1.FontSize = 30;
            btn1.Width = btn2.Width = btn3.Width = 570;
            btn1.Height = btn2.Height = btn3.Height = 40;
            btn2.Margin = new Thickness(0, 110, 0, 0);
            btn3.Margin = new Thickness(0, 220, 0, 0);
            btn1.FontSize = btn2.FontSize = btn3.FontSize = 30;
        }
    }
}
