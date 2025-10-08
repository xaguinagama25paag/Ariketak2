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
using Microsoft.VisualBasic;

namespace Ariketa2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejecutar(object sender, RoutedEventArgs e)
        {
            DateTime i = DateTime.Now;
            ahora.Text = i.ToString();
            hoy.Text = i.Day.ToString()+"/"+i.Month.ToString()+"/"+i.Year.ToString();
            hora.Text = i.Hour+":"+i.Minute+":"+i.Second;
            try
            {
                DateTime a = DateTime.Parse(Interaction.InputBox("Ingrese una fecha de la forma dd/mm/aaaa:", "Función SumaFechas"));
                int o = int.Parse(Interaction.InputBox("Ingrese el número de meses que se agrega a la fecha:", "Meses"));
                suma.Text = "Fecha Inicio: " + a.Date.ToString().Substring(0, 10) + ", Meses a sumar: " + o + ", Nueva Fecha: " + a.AddMonths(o).ToString().Substring(0, 10);
                DateTime u = DateTime.Parse(Interaction.InputBox("Ingrese fecha inicial de la forma dd/mm/aaaa:", "Función DiferenciaFechas"));
                DateTime aa = DateTime.Parse(Interaction.InputBox("Ingrese fecha final de la forma dd/mm/aaaa:", "Función DiferenciaFechas"));

                diferencia.Text = "desde " + u.Date + " hasta " + aa.Date + " hay " + (aa - u).Days.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduzca los datos correctamente o pulse Salir");
            }


        }
        private void Limpia(object sender, RoutedEventArgs e) {
            ahora.Text = "";
            hoy.Text = "";
            hora.Text = "";
            suma.Text = "";
            diferencia.Text = "";
        }
        private void Sal(object sender, RoutedEventArgs e) {
        this.Close();
        }
    }
}