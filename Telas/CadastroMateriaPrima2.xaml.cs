using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroMateriaPrimaPage : ContentPage
    {
        public CadastroMateriaPrimaPage()
        {
            InitializeComponent();
        }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            foreach (var view in Content.FindByName<Grid>("Content").Children)
            {
                if (view is Entry entry)
                {
                    entry.Text = string.Empty;
                }
                else if (view is CheckBox checkBox)
                {
                    checkBox.IsChecked = false;
                }
            }
        }

        private void OnFimClicked(object sender, EventArgs e)
        {
            DisplayAlert("Cadastro", "Cadastro de Matéria Prima concluído!", "OK");
        }
    }
}
