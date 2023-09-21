using System;
using Xamarin.Forms;

namespace CONVERTIDOR_TEMPERATURA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AplicarEstilos(); // Llama a la función para aplicar estilos
        }

        private void AplicarEstilos()
        {
            // Estilo para los Entry (cuadros de entrada)
            var entryStyle = new Style(typeof(Entry))
            {
                Setters = {
                    new Setter { Property = Entry.FontSizeProperty, Value = 18 },
                    new Setter { Property = Entry.TextColorProperty, Value = Color.Black },
                    new Setter { Property = Entry.KeyboardProperty, Value = Keyboard.Numeric },
                    new Setter { Property = Entry.PlaceholderColorProperty, Value = Color.Gray },
                    new Setter { Property = Entry.MarginProperty, Value = new Thickness(0, 10) }
                }
            };

            // Estilo para los botones
            var buttonStyle = new Style(typeof(Button))
            {
                Setters = {
                    new Setter { Property = Button.FontSizeProperty, Value = 18 },
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex("#2196F3") },
                    new Setter { Property = Button.TextColorProperty, Value = Color.White },
                    new Setter { Property = Button.CornerRadiusProperty, Value = 5 },
                    new Setter { Property = Button.MarginProperty, Value = new Thickness(0, 10) }
                }
            };

            // Aplicar estilos a los elementos
            librasEntry.Style = entryStyle;
            litrosEntry.Style = entryStyle;
            celsiusEntry.Style = entryStyle;

            ConvertirPesoButton.Style = buttonStyle;
            ConvertirVolumenButton.Style = buttonStyle;
            ConvertirTemperaturaButton.Style = buttonStyle;
        }

        // Resto de tus métodos aquí...

    }
}
