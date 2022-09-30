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

namespace WpfUserControlExample
{
    /// <summary>
    /// Lógica de interacción para LimitedInputUserControl.xaml
    /// </summary>
    public partial class LimitedInputUserControl : UserControl
    {
        public LimitedInputUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        //public static DependencyProperty SetTitleProperty = DependencyProperty.Register("titleProperty", typeof(string), typeof(LimitedInputUserControl));

        //public string titleProperty
        //{
        //    get { return (string)GetValue(SetTitleProperty); }
        //    set { SetValue(SetTitleProperty, value); }
        //}

        private string p_title; 
        public string title { get; set; }
           
        public int MaxLength { get; set; }

    }
}
