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

namespace TPLwithWPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var task = new Task(DoWork);
            task.ContinueWith(UpdateUIAsLoaded,TaskScheduler.FromCurrentSynchronizationContext());
            task.Start();
            this.TbStatus.Text = "Loading....";
            //DoWork();
            
        }

        private void UpdateUIAsLoaded(Task obj)
        {
            this.TbStatus.Text = "Loaded";
        }

        private static void DoWork()
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                    }
                }
            }
        }
    }
}
