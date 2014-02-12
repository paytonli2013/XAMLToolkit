using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XAMLToolkit.Model;

namespace XAMLToolkit.WPF.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Toast> Messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            InitData();

            DataContext = this;
        }

        private void InitData()
        {
            Messages = new List<Toast>();

            Messages.Add(new Toast("Toast1", "Title1"));
            Messages.Add(new Toast("Toast1", "Title1Title1"));
            Messages.Add(new Toast("Toast1", "Title1Title1Title1"));
            //throw new NotImplementedException();
        }
    }
}
