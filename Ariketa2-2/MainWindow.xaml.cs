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

namespace Ariketa2_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListBoxItem[] listItems;
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Anade(object sender, RoutedEventArgs e)
        {
             
            listBox1.Items.Add(nuevo.Text);
        }
        private void Elimina(object sender, RoutedEventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch {
                int i;
            }
        }
        private void Borra(object sender, RoutedEventArgs e)
        {
            try { 
                listBox1.Items.Clear();
            }
            catch
            {
                int i;
            }
        }

        private void Sal(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            seleccionado.Text = listBox1.SelectedItem.ToString();
            

        }
    }
}