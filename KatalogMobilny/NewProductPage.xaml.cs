namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
	public NewProductPage()
	{
		InitializeComponent();

		KategoriaPicker.ItemsSource = new List<string>
		{
			"Procesory",
			"Płyty Główne",
			"Karty Graficzne",
			"Dyski SSD",
			"Pamięci RAM"
		};
	}

	private void NazwaEntry_TextChanged(object? sender, TextChangedEventArgs e)
	{
		int dlugosc = e.NewTextValue?.Length ?? 0;
		EtykietaWyniku.Text = $"Nazwa ma {dlugosc} znaków";
	}

	private void AvailableSwitch_Toggled(object? sender, ToggledEventArgs e)
	{
		if (e.Value)
		{
			DostepnoscLabel.Text = "Produkt dostępny";
		}
		else
		{
			DostepnoscLabel.Text = "Produkt niedostępny";
		}
	}

	private void KategoriaPicker_SelectedIndexChanged(object? sender, EventArgs e)
	{
		if (KategoriaPicker.SelectedIndex == -1)
		{
			return;
		}
		EtykietaWyniku.Text = $"Kategoria: {KategoriaPicker.SelectedItem}";
	}
}
