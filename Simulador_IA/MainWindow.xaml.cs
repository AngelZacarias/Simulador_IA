using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace Simulador_IA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string pathApplication = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "../../../"; //root path of the application
        public bool[] isSectionDirty = new bool[2]; //Section A and Section B to check whether is dirty or not
        public System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        public MainWindow()
        {            
            InitializeComponent();
            
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5); //TimeSpan(int hours, int min, int secs) Every 5 seconds do dispatcherTimer_Tick
            dispatcherTimer.Start();
            initializeSections();
        }

        private void initializeSections()
        {
            for (int i = 0; i < 2; i++)
            {
                isSectionDirty[i] = false; //false = not dirty, true = dirty
            }
        }

        private void BTN_TrashA_Click(object sender, RoutedEventArgs e)
        {
            IMG_TrashA.Source = new BitmapImage(new Uri(pathApplication + "paper.png"));
            isSectionDirty[0] = true;            
        }

        private void BTN_TrashB_Click(object sender, RoutedEventArgs e)
        {
            IMG_TrashB.Source = new BitmapImage(new Uri(pathApplication + "paper.png"));
            isSectionDirty[1] = true;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (IMG_SectionA.Source == null) // if section A doesn't have the vaccum
            {
                IMG_SectionB.Source = null; //Remove vaccum from section B
                IMG_SectionA.Source = new BitmapImage(new Uri(pathApplication + "vaccum.png")); //Put vaccum in section A
                if (isSectionDirty[0]) //If section A is dirty
                {
                    IMG_TrashA.Source = null;
                    isSectionDirty[0] = false;
                }
            }
            else //if section B doesn't have the vaccum
            {
                IMG_SectionA.Source = null;
                IMG_SectionB.Source = new BitmapImage(new Uri(pathApplication + "vaccum.png"));
                if (isSectionDirty[1])
                {
                    IMG_TrashB.Source = null;
                    isSectionDirty[1] = false;
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}