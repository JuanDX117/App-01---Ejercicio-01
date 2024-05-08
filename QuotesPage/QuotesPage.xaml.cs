using Microsoft.Maui.Controls;

namespace QuotesPage
{
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();
            
            // Llamamos a un método para cargar las frases en la lista
            LoadQuotes();

            // Configuramos el control deslizante con los valores mínimo y máximo
            slider.Minimum = 16;
            slider.Maximum = 50;
        }

        // Método para cargar las frases en la lista
        private void LoadQuotes()
        {
            // Definimos un array de frases
            string[] quotes = {
                "La vida es lo que pasa mientras estás ocupado haciendo otros planes.",
                "El único modo de hacer un gran trabajo es amar lo que haces.",
                "La vida es 10% lo que nos sucede y 90% cómo reaccionamos ante ello.",
                "La mejor venganza es un éxito masivo.",
                "La única manera de hacer un gran trabajo es amar lo que haces.",
                "La vida no se trata de encontrarte a ti mismo, sino de crearte a ti mismo.",
                "La verdadera medida de la amistad no es cómo te sientes acerca de alguien, sino cómo ellos se sienten acerca de ti.",
                "Sólo se vive una vez, pero si lo haces bien, una vez es suficiente."
            };

            // Asignamos el array de frases como origen de datos para la lista
            quotesListView.ItemsSource = quotes;
        }

        // Método para manejar el cambio de valor del control deslizante
        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Actualizamos el valor del label con el valor actual del control deslizante
            sliderValueLabel.Text = e.NewValue.ToString();
        }
    }
}
