using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class EsseTelefoneValido : ContentPage
    {
        public EsseTelefoneValido()
        {
            InitializeComponent();
        }

        private void NaoButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Resposta", "Nome inválido. Por favor, tente novamente.", "OK");
        }

        private void SimButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Resposta", "Nome confirmado. Prosseguindo...", "OK");
        }
    }
}
