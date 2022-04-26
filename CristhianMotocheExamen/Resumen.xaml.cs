using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CristhianMotocheExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen()
        {
            InitializeComponent();
        }

        public Resumen(string strUser, string strNombre, decimal decTotal) 
        {
            InitializeComponent();

            LblUser.Text = strUser;

            TxtNombre.Text = strNombre;

            TxtTotal.Text = decimal.Round(decTotal,2).ToString();
        }
    }
}