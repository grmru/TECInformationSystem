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

namespace TECInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listBoxValues;

        public MainWindow()
        {
            listBoxValues = new List<string>();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBoxValues.Add(this.textBox.Text);
            UpdateList();
        }

        private void UpdateList()
        {
            lBox.Items.Clear();
            for (int i = 0; i < listBoxValues.Count; i++)
            {
                lBox.Items.Add(listBoxValues[i]);
            }
        }
    }
}
