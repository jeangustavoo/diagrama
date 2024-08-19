using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroFornecedor2 : ContentPage
    {
        public CadastroFornecedor2()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            DisplayAlert("Salvar", "Os dados foram salvos com sucesso!", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            DisplayAlert("Cancelar", "Operação cancelada!", "OK");
            foreach (var child in ((Grid)((VerticalStackLayout)((Frame)((VerticalStackLayout)Content).Children[0]).Children[0]).Children))
            {
                if (child is Entry entry)
                {
                    entry.Text = string.Empty;
                }
            }
        }
    }
}
