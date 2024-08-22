using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroTransportadoraPage2 : ContentPage
    {
        public CadastroTransportadoraPage2 ()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
            CodigoEntry.Text = string.Empty;
        }

        private void OnFimClicked(object sender, EventArgs e)
        {
            DisplayAlert("Cadastro", "Cadastro de Transportadora concluído!", "OK");
            
        }
    }
}
