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
    public partial class Listagem : ContentPage
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Formulario());
        }
        protected override void OnAppearing()
        {
            try
            {
                lst_pedagios.ItemsSource = App.ListaPedagios;

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem disparador = (MenuItem)sender;

            Pedagio pedagio_selecionado = (Pedagio)disparador.BindingContext;

            bool confirmacao = await DisplayAlert("Tem certeza?",
                                                  "Excluir pedágio " + pedagio_selecionado.Localizacao + "?",
                                                  "Sim", "Não");
            if (confirmacao)
            {
                App.ListaPedagios.Remove(pedagio_selecionado);

                //lst_pedagios.ItemsSource = new List<Pedagio>();
                lst_pedagios.ItemsSource = App.ListaPedagios;
            }
        }
    }
}