using Microsoft.Maui.Controls; // For UI elements like Button and ContentPage
using Microsoft.Maui.ApplicationModel; // For TextToSpeech

namespace KidsLearningApp
{
    public partial class KLP : ContentPage
    {
        public KLP()
        {
            InitializeComponent();
        }

        private async void KLP_Button_Clicked(object sender, EventArgs e)
        {
            // Get the button that was clicked
            var button = (Button)sender;

            // Get the text of the button, which represents the color name
            string colorName = button.Text;

            // Use TextToSpeech to speak the color name
            await TextToSpeech.Default.SpeakAsync(colorName);
        }
    }
}
