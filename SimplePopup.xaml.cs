using CommunityToolkit.Maui.Views;

namespace MauiIComm_VerifyPopupFlowDirection;

public partial class SimplePopup : Popup
{
	public SimplePopup()
	{
		InitializeComponent();
	}

    void OnButtonClicked(object sender, EventArgs e)=> Close();
}