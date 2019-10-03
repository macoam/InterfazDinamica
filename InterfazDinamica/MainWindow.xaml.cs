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

namespace InterfazDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;

        }

        private void ComboxTitulo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdDatos.Children.Clear();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (comboxTitulo.SelectedIndex)
            {
                case 0: //Alumno
                    grdDatos.Children.Add(new Alumno());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                case 1:  //Maestro
                    grdDatos.Children.Add(new Maestro());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                default:
                    break;

            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdDatos.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            grdDatos.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
