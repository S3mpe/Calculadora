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
            TextBlock numeroVisualizado;
            Viewbox contenedor;
            Button boton;
            int valor = 0;
            for (int filas = 2; filas < 5; filas++)
            {
                for (int columnas = 0; columnas < 3; columnas++)
                {
                    valor++;
                    numeroVisualizado = new TextBlock
                    {
                        Text = valor.ToString()
                    };
                    contenedor = new Viewbox
                    {
                        Child = numeroVisualizado
                    };
                    boton = new Button
                    {
                        Content = contenedor,
                        Tag = valor.ToString()
                    };
                    this.Calculadora.Children.Add(boton);
                    Grid.SetRow(boton, filas);
                    Grid.SetColumn(boton, columnas);
                }
            }

         
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button informacionBoton = (Button)sender;
            EntradaTextBox.Content += informacionBoton.Tag.ToString();
        }
    }
}
