namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
	public NewProductPage()
	{
		InitializeComponent();

		// lista kategorii wpisana w kodzie zamiast x:Array w XAML
		KategoriaPicker.ItemsSource = new List<string>
		{
			"Procesory",
			"Płyty Główne",
			"Karty Graficzne",
			"Dyski SSD",
			"Pamięci RAM"
		};
	}

	// 1. po każdej wpisanej literze pokazujemy długość nazwy
	private void NazwaEntry_TextChanged(object? sender, TextChangedEventArgs e)
	{
		// e.NewTextValue to aktualny tekst w polu (może być null, wtedy 0 znaków)
		int dlugosc = e.NewTextValue?.Length ?? 0;
		EtykietaWyniku.Text = $"Nazwa ma {dlugosc} znaków";
	}

	// 2. po przełączeniu pokazujemy, czy produkt jest dostępny
	private void AvailableSwitch_Toggled(object? sender, ToggledEventArgs e)
	{
		// e.Value = true gdy przełącznik włączony
		if (e.Value)
		{
			DostepnoscLabel.Text = "Produkt dostępny";
		}
		else
		{
			DostepnoscLabel.Text = "Produkt niedostępny";
		}
	}

	// 3. po wyborze kategorii pokazujemy jej nazwę
	private void KategoriaPicker_SelectedIndexChanged(object? sender, EventArgs e)
	{
		// SelectedIndex = -1 gdy nic nie wybrano
		if (KategoriaPicker.SelectedIndex == -1)
		{
			return;
		}
		EtykietaWyniku.Text = $"Kategoria: {KategoriaPicker.SelectedItem}";
	}
}
