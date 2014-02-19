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

namespace XAMLToolkit.WPF.Demo
{
    /// <summary>
    /// Interaction logic for ChildView.xaml
    /// </summary>
    public partial class ChildView : UserControl, IChildView
    {
        public object Result { get; set; }

        public ChildView()
        {
            InitializeComponent();
            DataContext = this;
        }

        public void SetPayload(object payload)
        {
            Result = "" + payload;
        }

        public object Header
        {
            get { return "View Header"; }
        }
    }
}
