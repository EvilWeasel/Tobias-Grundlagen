namespace PhonewordMaui
{
  public partial class MainPage : ContentPage
  {
    string translatedNumber;
    public MainPage()
    {
      InitializeComponent();
    }
    private void OnTranslate(object sender, EventArgs e)
    {
      string enteredNumber = PhoneNumberText.Text;
      translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);

      if (!string.IsNullOrEmpty(translatedNumber))
      {
        // TODO:
        CallButton.Text = "Call " + translatedNumber;
        CallButton.IsEnabled = true;
      }
      else
      {
        // TODO:
        CallButton.Text = "You picked the wrong number, fool!";
        CallButton.IsEnabled = false;
      }
    }
    async void OnCall(object sender, System.EventArgs e)
    {
      bool wantToCall = await this.DisplayAlert(
        "Dial a number",
        "Call " + translatedNumber + " ?",
        "Hell Yeah!",
        "Heck nah!");
      if (wantToCall) 
      {
        await this.DisplayAlert("Cool", "Hier könnte Ihre Werbung stehen", "Cancel");
      }
    }
  }

}
