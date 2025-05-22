using SciCalc.ViewModels;


namespace SciCalc.Views;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
		InitializeComponent();

		this.BindingContext = new CalculatorPageViewModel();
	}
}