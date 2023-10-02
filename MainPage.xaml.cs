using CommunityToolkit.Maui.Views;

namespace MauiIComm_VerifyPopupFlowDirection
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnShow1_Clicked(object sender, EventArgs e)
        {
            Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            var popup1 = new SimplePopup();
            if (popup1.Content is not null)
            {
                popup1.Content.FlowDirection = FlowDirection.RightToLeft;
            }
            popup1.VerticalOptions = verticalOptions;
            popup1.HorizontalOptions = horizontalOptions;
            await Shell.Current.ShowPopupAsync(popup1);
        }

        async void btnShow2_Clicked(object sender, EventArgs e)
        {
            Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            var popup2 = new SimplePopup();
            if (popup2.Content is not null)
            {
                popup2.Content.FlowDirection = FlowDirection.LeftToRight;
            }
            popup2.VerticalOptions = verticalOptions;
            popup2.HorizontalOptions = horizontalOptions;
            await Shell.Current.ShowPopupAsync(popup2);
        }
    }
}