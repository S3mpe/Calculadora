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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button numero1 = new Button
            {
                Content = "1",
            Style = (Style)this.Resources["botones"]
            };
            Button numero2 = new Button
            {
                Content = "2",
                Style = (Style)this.Resources["botones"]
            };
            Button numero3 = new Button
            {
                Content = "3",
                Style = (Style)this.Resources["botones"]
            };
            Button numero4 = new Button
            {
                Content = "4",
                Style = (Style)this.Resources["botones"]
            };
            Button numero5 = new Button
            {
                Content = "5",
                Style = (Style)this.Resources["botones"]
            };
            Button numero6 = new Button
            {
                Content = "6",
                Style = (Style)this.Resources["botones"]
            };
            Button numero7 = new Button
            {
                Content = "7",
                Style = (Style)this.Resources["botones"]
            };
            Button numero8 = new Button
            {
                Content = "8",
                Style = (Style)this.Resources["botones"]
            };
            Button numero9 = new Button
            {
                Content = "9",
                Style = (Style)this.Resources["botones"]
            };
            Button numero0 = new Button
            {
                Content = "0",
                Style = (Style)this.Resources["botones"]
            };
            numero1.Click += Button_Click;
            numero2.Click += Button_Click;
            numero3.Click += Button_Click;
            numero4.Click += Button_Click;
            numero5.Click += Button_Click;
            numero6.Click += Button_Click;
            numero7.Click += Button_Click;
            numero8.Click += Button_Click;
            numero9.Click += Button_Click;
            numero0.Click += Button_Click;
        }

        private void Numero1_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button informacionBoton = (Button)sender;
            EntradaTextBox.Content += informacionBoton.Tag.ToString();
        }
    }
}
