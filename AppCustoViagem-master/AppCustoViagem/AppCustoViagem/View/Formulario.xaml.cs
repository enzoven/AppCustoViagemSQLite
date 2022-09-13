using AppCustoViagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCustoViagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                Pedagio p = new Pedagio
                {
                    Localizacao = txt_localizacao.Text,
                    Valor = Convert.ToDouble(txt_valor.Text)
                };

                App.ListaPedagios.Add(p);

                //PropriedadesApp.ListaPedagios.Add(p);

                await DisplayAlert("Deu Certo!", "Pedágio Adicionado", "OK");

                await Navigation.PopAsync();



            }
            catch (Exception ex)
            { await DisplayAlert("Ops", ex.Message, "OK"); }
        }

    }
}
