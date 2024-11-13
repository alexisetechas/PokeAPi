namespace PokeApi
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"CLicou {count} time";
            else
                CounterBtn.Text = $"Clicou {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
