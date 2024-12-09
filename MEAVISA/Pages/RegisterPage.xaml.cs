using MEAVISA.CORE;
using MEAVISA.Utilities;

namespace MEAVISA.Pages;

public partial class RegisterPage : ContentPage
{
    private List<string> _selectedCategories { get; set; } = [];
    private string? _selectedLocation;
    private string? _selectedDdd;
    private string? _name;
    private string? _password;
    private ContactPreference? _preference;
    private string? _whatsApp;
    private string? _email;
    public RegisterPage()
    {
        InitializeComponent();
        BindingContext = this;

        picker.ItemsSource = DataValues.Locations;
        pickerDDD.ItemsSource = DataValues.Ddds;

        foreach (string item in DataValues.Categories)
        {
            CheckBox checkBox = new()
            {
                ClassId = item
            };
            checkBox.CheckedChanged += OnCheckBoxCheckedChanged;

            HorizontalStackLayout stackLayout = new()
            {
                Children =
                {
                    checkBox,
                    new Label { Text = item, VerticalOptions = LayoutOptions.Center }
                }
            };

            categoriesList.Add(stackLayout);
        }
    }
    private void OnCheckBoxCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (e.Value) _selectedCategories.Add(checkBox.ClassId);
            else _selectedCategories.Remove(checkBox.ClassId);
        }
    }
    private void OnPickerSelectionChanged(object sender, EventArgs e)
    {
        if (sender is Picker picker)
        {
            if (picker.SelectedItem is string location)
            {
                _selectedLocation = location;
                labelPlaceholder.IsVisible = false; 
            }
        }
    }
    private void PreferenceWhatsApp_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            _preference = ContactPreference.WhatsApp;
            preferenceEmail.IsChecked = false;
        }
        else _preference = null;
    }
    private void PreferenceEmail_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            _preference = ContactPreference.Email;
            preferenceWhatsApp.IsChecked = false;
        }
        else _preference = null;
    }
    private void EmailEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        _email = e.NewTextValue;
    }
    private void PickerDDD_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (sender is Picker picker)
        {
            if (picker.SelectedItem is string ddd)
            {
                _selectedDdd = ddd;
                labelDDD.IsVisible = false;
            }
        }
    }
    private void WhatsappEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        _whatsApp = e.NewTextValue;
    }
    private void NameEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        _name = e.NewTextValue;
    }
    private void PasswordEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        _password = e.NewTextValue;
    }
    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        (string nameMsg, int nameCode) = ValidatorField.ValidateName(_name);
        (string passwordMsg, int passwordCode) = ValidatorField.ValidatePassword(_password);

        if(_selectedCategories.Count == 0)
        {
            await DisplayAlert("Erro", "Selecione pelo menos uma categoria!", "OK");
            return;
        }

        if(_preference is null)
        {
            await DisplayAlert("Erro", "Selecione uma preferência de contato", "OK");
            return;
        }

        if (_preference is ContactPreference.Email)
        {
            (string emailMsg, int emailCode) = ValidatorField.ValidateEmail(_email);
            if (emailCode == 400)
            {
                await DisplayAlert("Erro", emailMsg, "OK");
                return;
            }
        }
        else if (_preference is ContactPreference.WhatsApp)
        {
            if (_selectedDdd is null)
            {
                await DisplayAlert("Erro", "Selecione o DDD", "OK");
                return;
            }

            (string whatsAppMsg, int whatsAppCode) = ValidatorField.ValidateWhatsApp(_whatsApp);
            if (whatsAppCode == 400)
            {
                await DisplayAlert("Erro", whatsAppMsg, "OK");
                return;
            }
        }

        if (nameCode == 400)
        {
            await DisplayAlert("Erro", nameMsg, "OK");
            return;
        }

        if (passwordCode == 400)
        {
            await DisplayAlert("Erro", passwordMsg, "OK");
            return;
        }


        await DisplayAlert("Sucesso", "Cadastrado", "OK");
    }
}
