using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenJavierPila
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Actividad : ContentPage
    {
       
      public Actividad()
        {

        }
        
        public Actividad(string name, string mon, string men)

        {
            InitializeComponent();
            string nombre = txtNombre.Text;
            txtNombre.Text = nombre + name;

            string monto = txtMonto.Text;
            txtMonto.Text = monto + mon;

            string mensual = txtMensual.Text;
            txtMensual.Text = mensual + men;
        }

        
    }
    
}