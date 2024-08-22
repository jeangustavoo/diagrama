using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class ListaTransportardoraPage : ContentPage
    {
        public ListaTransportardoraPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public object NomeEntry { get; private set; }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            DisplayAlert("Apagar", "O nome foi apagado.", "OK");
        }

        private void OnFimClicked(object sender, EventArgs e)
        {
            DisplayAlert("Finalizado", "A operação foi finalizada.", "OK");

        }
    }
}
