public partial class ConfirmacaoNomePage : ContentPage
{
    public ConfirmacaoNomePage()
    {
        InitializeComponent();
    }

    private async void NaoButton_Clicked(object sender, EventArgs e)
    {
        // Ação a ser realizada quando o usuário clica em "Não"
        // Por exemplo, exibir uma mensagem de erro ou direcionar o usuário para corrigir o nome
        await DisplayAlert("Nome Inválido", "Por favor, insira um nome válido.", "OK");
        await Navigation.PopModalAsync();
    }

    private async void SimButton_Clicked(object sender, EventArgs e)
    {
        // Ação a ser realizada quando o usuário clica em "Sim"
        // Por exemplo, salvar o nome no banco de dados ou prosseguir para a próxima etapa
        await DisplayAlert("Nome Válido", "O nome foi confirmado.", "OK");
        await Navigation.PopModalAsync();
    }
}
