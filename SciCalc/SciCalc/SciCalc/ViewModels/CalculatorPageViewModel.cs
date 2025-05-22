using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SciCalc.ViewModels
{
	[INotifyPropertyChanged]
	internal partial class CalculatorPageViewModel //:ObservableObject
	{
		[ObservableProperty]
		private string inputText = string.Empty;

		[ObservableProperty]
		private string calculatedResult = "0";

		private bool isSciOpWaiting = false;

		[RelayCommand]
		private void Reset()
		{
			CalculatedResult = "0";
			InputText = string.Empty;
			isSciOpWaiting = false;
		}

		[RelayCommand]
		private void Calculate()
		{
			if (InputText.Length == 0)
			{
				return;
			}

			if (isSciOpWaiting)
			{
				InputText += ")";
				isSciOpWaiting = false;
			}
			try
			{
				var inputString = NormalizeInputString();
				var expression = new NCalc.Expression(inputString);
				var result = expression.Evaluate();

				CalculatedResult = result.ToString();
			}
			catch (Exception ex)
			{
				CalculatedResult = "NaN";
			}
		}
		private string NormalizeInputString()
		{
			Dictionary<string, string> _opMapper = new()
			{
				{"×", "*"},
				{"÷", "/"},
				{"SIN", "Sin"},
				{"COS", "Cos"},
				{"TAN", "Tan"},
				{"ASIN", "Asin"},
				{"ACOS", "Acos"},
				{"ATAN", "Atan"},
				{"LOG", "Log"},
				{"EXP", "Exp"},
				{"LOG10", "Log10"},
				{"POW", "Pow"},
				{"SQRT", "Sqrt"},
				{"ABS", "Abs"},
			};

			var retString = InputText;

			foreach (var key in _opMapper.Keys)
			{
				retString = retString.Replace(key, _opMapper[key]);
			}

			return retString;
		}

		[RelayCommand]
		private void Backspace()
		{
			if (InputText.Length > 0)
			{
				inputText = InputText.Substring(0, InputText.Length - 1);
			}
		}

		[RelayCommand]
		private void NumberInput(string key)
		{
			InputText += key;
		}

		[RelayCommand]
		private void MathOperator(string op)
		{
			if (isSciOpWaiting)
			{
				InputText += ")";
				isSciOpWaiting = false;
			}
			InputText += $"{op} ";
		}

		[RelayCommand]
		private void RegionOperator(string op)
		{
			if (isSciOpWaiting)
			{
				InputText += ")";
				isSciOpWaiting = false;
			}
			InputText += $"{op} ";
		}

		[RelayCommand]
		private void ScientificOperator(string op)
		{
			InputText += $"{op}(";
			isSciOpWaiting = true;
		}
	}
}