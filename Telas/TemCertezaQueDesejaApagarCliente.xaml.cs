using Microsoft.Maui.Controls;
using System;

namespace diagrama
{
    public partial class TemCertezaQueDesejaApagarCliente : ContentPage
    {
        public TemCertezaQueDesejaApagarCliente()
        {
            InitializeComponent();
        }

        private async void NaoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void SimButton_Clicked(object sender, EventArgs e)
        {
            bool sucesso = ApagarCliente(); 
            if (sucesso)
            {
                await DisplayAlert("Cliente Apagado", "O cliente foi apagado com sucesso.", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Ocorreu um erro ao tentar apagar o cliente.", "OK");
            }

            await Navigation.PopAsync(); 
        }

        private bool ApagarCliente()
        {
            return true;
        }
    }
}
