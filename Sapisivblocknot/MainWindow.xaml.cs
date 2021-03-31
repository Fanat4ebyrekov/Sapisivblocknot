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
using System.IO;

namespace Sapisivblocknot
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

        private void btnSapic_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\USER\Desktop\Login and Password\note.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(txtName.Text);
                sw.Write(txtLName.Text);
                sw.Write(txtAge.Text);
                sw.Close();
            }

            MessageBox.Show("Добавлено");
        }

        private void txtName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void txtLName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void txtAge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }
    }
}
