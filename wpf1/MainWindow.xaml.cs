using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
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
using System.Globalization;
using lib1;

namespace wpf1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n = 5;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Angle.Text != "" & check_num(Angle.Text) == true)
            {
                Trigonometry s = new Trigonometry(Angle.Text);
                if (n == 0) 
                { 
                    Result.Content = s.nsin();
                    SatusPanel.Text = "";
                }
                else if (n == 1) 
                { 
                    Result.Content = s.ncos();
                    SatusPanel.Text = "";
                }
                else if (n == 2) 
                { 
                    Result.Content = s.ntg();
                    SatusPanel.Text = "";
                }
                else if (n == 3) 
                { 
                    Result.Content = s.nctg();
                    SatusPanel.Text = "";
                }
                else { SatusPanel.Text = "Не выбрана функция"; }
            }
            else 
            {
                if (Angle.Text == "")
                {
                    SatusPanel.Text = "Не задан угол";
                }
                if (check_num(Angle.Text) == false)
                {
                    SatusPanel.Text = "Угол задан неверно";
                }
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StreamWriter SaveRes = new StreamWriter(@"D:\lliri\Desktop\Учеба\Программирование\lab_sr\wpf1\Save_Result.txt", true);
            string safe = Angle.Text + " - " + Result.Content;
            SaveRes.WriteLine(safe);
            SatusPanel.Text = "Сохранено";
            SaveRes.Close();
        }

        private void load_button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad.exe", "D:\\lliri\\Desktop\\Учеба\\Программирование\\lab_sr\\wpf1\\Save_Result.txt");
            SatusPanel.Text = "Загрузка";
        }

        public bool check_num(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9') { return false; }
            }
            return true;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Trigon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string st = Trigon.SelectedIndex.ToString();
            n = Convert.ToInt32(st);
        }

        private void Button_Click_en(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            if (lang != null)
            {
                App.Language = lang;
            }
        }

        private void Button_Click_ru(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            if (lang != null)
            {
                App.Language = lang;
            }
        }



    }
}
