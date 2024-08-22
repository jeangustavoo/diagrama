using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroCliente2 : ContentPage
    {
        public CadastroCliente2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            foreach (var child in ((StackLayout)Content).Children)
            {
                if (child is Grid grid)
                {
                    foreach (var gridChild in grid.Children)
                    {
                        if (gridChild is Entry entry)
                        {
                            entry.Text = string.Empty;
                        }
                    }
                }
            }
            DisplayAlert("Ação", "Campos apagados com sucesso!", "OK");
        }

        private void OnFimClicked(object sender, EventArgs e)
        {
            
            Navigation.PopAsync(); 
        }
    }
}
