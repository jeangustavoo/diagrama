using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class EsseEndereçoValido : ContentPage
    {
        public EsseEndereçoValido()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
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
