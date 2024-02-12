using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace AlixayNikita
{
    /// <summary>
    /// Логика взаимодействия для play.xaml
    /// </summary>
    public partial class play : Window
    {
        List<TextBox> TextBlocks = new List<TextBox>();
        public play()
        {
            InitializeComponent();
            DataContext = new AppViewModel();

            TextBlocks.Add(Answer1);
            TextBlocks.Add(Answer2);
            TextBlocks.Add(Answer3);
        }

        public void Examination(object sender, RoutedEventArgs e)
        {
            int score = 0;
            int index = Category.SelectedIndex;

            AppViewModel appViewModel = new AppViewModel();

            if (index == -1)
            {
                proverka.Content = $"Выбери тему!";
            }
            else
            {
                for (int i = 0; i < appViewModel.customers[index].Questions.Count; i++)
                {
                    if (TextBlocks[i].Text == appViewModel.customers[index].Answers[i]) score++;
                }

                proverka.Content = $"{score} из 3 верно!";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow qw = new MainWindow();
            qw.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Max(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
            theme.FontSize = 40;
            tb1.FontSize = tb2.FontSize = tb3.FontSize = tb4.FontSize = tb5.FontSize = tb6.FontSize = tb7.FontSize = tb8.FontSize = 30;
            label1.FontSize = label2.FontSize = label3.FontSize = 30;
            Answer1.FontSize = Answer2.FontSize = Answer3.FontSize = 30;
            Answer1.Width = Answer2.Width = Answer3.Width = 400;
            Answer1.Height = Answer2.Height = Answer3.Height = 60;
            btn1.Width = btn2.Width = 600;
            btn1.Height = btn2.Height = 100;
            btn1.Margin = new Thickness(0, 0, 800, 40);
            btn2.Margin = new Thickness(800, 0, 0, 40);
            btn1.FontSize = btn2.FontSize = 40;
            proverka.FontSize = 32;
        }

        private void Min(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            theme.FontSize = 20;
            tb1.FontSize = tb2.FontSize = tb3.FontSize = tb4.FontSize = tb5.FontSize = tb6.FontSize = tb7.FontSize = tb8.FontSize = 15;
            label1.FontSize = label2.FontSize = label3.FontSize = 15;
            Answer1.FontSize = Answer2.FontSize = Answer3.FontSize = 15;
            Answer1.Width = Answer2.Width = Answer3.Width = 200;
            Answer1.Height = Answer2.Height = Answer3.Height = 30;
            btn1.Width = btn2.Width = 300;
            btn1.Height = btn2.Height = 50;
            btn1.Margin = new Thickness(0, 0, 400, 20);
            btn2.Margin = new Thickness(400, 0, 0, 20);
            btn1.FontSize = btn2.FontSize = 20;
            proverka.FontSize = 16;
        }
    }
}
