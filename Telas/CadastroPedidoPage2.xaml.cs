using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroPedidoPage2 : ContentPage
    {
        public CadastroPedidoPage2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Apagar_Clicked(object sender, EventArgs e)
        {
            foreach (var view in ((StackLayout)((Grid)Content).Children[1]).Children)
            {
                if (view is Entry entry)
                {
                    entry.Text = string.Empty;
                }
                else if (view is DatePicker datePicker)
                {
                    datePicker.Date = DateTime.Now;
                }
            }
        }

        private void Fim_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Pedido", "Cadastro de Pedido concluído!", "OK");
        }
    }
}
