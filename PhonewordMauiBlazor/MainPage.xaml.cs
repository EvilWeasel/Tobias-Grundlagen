namespace PhonewordMauiBlazor
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    public async Task ShowAlert(string translatedNumber) 
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
