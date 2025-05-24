using Microsoft.Maui.Controls;
using Microsoft.Maui.Media;
using System.Collections.ObjectModel;
using System.Linq;

namespace MimiMahJonggHelperReal
{
    public partial class HandSelectionPage : ContentPage
    {
        public HandSelectionPage(List<SpecificHand> hands, string categoryName)
        {
            InitializeComponent();
            CategoryTitleLabel.Text = categoryName;
            HandsListView.ItemsSource = new ObservableCollection<SpecificHand>(hands);
        }

        private async void OnHandSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is SpecificHand selectedHand)
            {
                if (!string.IsNullOrEmpty(selectedHand.SpokenContent))
                {
                    try
                    {
                        await TextToSpeech.Default.SpeakAsync(selectedHand.SpokenContent);
                    }
                    catch (Exception ex)
                    {
                        await DisplayAlert("TTS Error", "Could not speak: " + ex.Message, "OK");
                    }
                }
                else
                {
                    await DisplayAlert("Info", "No content to speak for this hand.", "OK");
                }

                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}