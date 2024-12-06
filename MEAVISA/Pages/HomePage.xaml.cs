namespace MEAVISA.Pages;

public partial class HomePage : ContentPage
{
    private readonly List<Label> labels;
	public HomePage()
	{
		InitializeComponent();

        labels =
        [
            new() { Text = "• Obras" },
            new() { Text = "• Problemas de água/energia" },
            new() { Text = "• Eventos" },
            new() { Text = "• Concursos" },
            new() { Text = "• Atendimentos" },
            new() { Text = "• Vacinas" },
            new() { Text = "• Campanhas" }
        ];

        foreach (Label item in labels)
        {
            item.Style = (Style)Microsoft.Maui.Controls.Application.Current!.Resources["ulLabel"];
            containerss.Add(item);
        }

    }

    private void OnRegisterButtonClicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new RegisterPage());
    }
}