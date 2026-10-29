namespace KatalogMobilny
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PokazClicked(object? sender, EventArgs e)
        {
            EtykietaWyniku.Text = "Wybrano procesor";
        }

        private void UkryjClicked(object? sender, EventArgs e)
        {
            EtykietaWyniku.Text = "Nic nie wybrano";
        }
    }
}
