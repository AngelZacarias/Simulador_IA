using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace Simulador_IA
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string path = @"Score.txt"; //File path
        int trash = 0, movements = 0, count = 0;

        public Window1()
        {
            InitializeComponent();


            using (StreamReader sr = File.OpenText(path))
            {
                string[] parts;
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    parts = s.Split(',');
                    var data = new Score { Movements = parts[0], Trash = parts[1] };
                    DataGridScore.Items.Add(data);
                    trash += Convert.ToInt32(parts[1]);
                    movements += Convert.ToInt32(parts[0]);
                    count++;
                }
            }
            LBL_Movements.Content = Convert.ToString(movements / count);
            LBL_Trash.Content = Convert.ToString(trash / count);
        }

        private void DataGridScore_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public class Score
        {
            public string Movements { get; set; }
            public string Trash { get; set; }
        }


        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            //Close window
            this.Close();
        }

    }
}
