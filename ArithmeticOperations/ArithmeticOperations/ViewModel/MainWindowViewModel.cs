using ArithmeticOperations.Model;
using ArithmeticOperations.MVVM;
using System;

namespace ArithmeticOperations.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Operand operand;
        private string resultText;

        public MainWindowViewModel()
        {
            operand = new Operand();
            AddCommand = new RelayCommand(ExecuteAdd);
            SubtractCommand = new RelayCommand(ExecuteSubtract);
            MultiplyCommand = new RelayCommand(ExecuteMultiply);
        }

        public Operand Operand
        {
            get { return operand; }
            set
            {
                operand = value;
                OnPropertyChanged(nameof(Operand));
            }
        }

        public string ResultText
        {
            get { return resultText; }
            set
            {
                resultText = value;
                OnPropertyChanged(nameof(ResultText));
            }
        }

        public RelayCommand AddCommand { get; }
        public RelayCommand SubtractCommand { get; }
        public RelayCommand MultiplyCommand { get; }

        private void ExecuteAdd(object parameter)
        {
            Operand.Result = Operand.FirstOperand + Operand.SecondOperand;
            ResultText = "Result: " + Operand.Result;
        }

        private void ExecuteSubtract(object parameter)
        {
            Operand.Result = Operand.FirstOperand - Operand.SecondOperand;
            ResultText = "Result: " + Operand.Result;
        }

        private void ExecuteMultiply(object parameter)
        {
            Operand.Result = Operand.FirstOperand * Operand.SecondOperand;
            ResultText = "Result: " + Operand.Result;
        }
    }
}
