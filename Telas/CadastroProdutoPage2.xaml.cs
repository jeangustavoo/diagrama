using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroProdutoPage2 : ContentPage
    {
        public CadastroProdutoPage2 ()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Apagar_Clicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            CustoEntry.Text = string.Empty;
            ValorEntry.Text = string.Empty;
            TempoProducaoEntry.Text = string.Empty;
        }

        private void Fim_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Produto", "Cadastro de Produto concluído!", "OK");
            
        }
    }
}
