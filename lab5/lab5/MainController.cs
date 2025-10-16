using lab5;
using Lab5.Model;
using System;

namespace Lab5.Controller
{
    public class MainController
    {
        private Form1 _view;
        private Calculator _calculator;
        private AgeChecker _ageChecker;
        private MultiplicationTable _multiplicationTable;

        private string _currentInput = "";
        private string _currentOperation = "";
        private double _firstNumber = 0;
        private bool _newCalculation = true;

        public MainController(Form1 view)
        {
            _view = view;
            _calculator = new Calculator();
            _ageChecker = new AgeChecker();
            _multiplicationTable = new MultiplicationTable();
        }

        // МЕТОДИ ДЛЯ КАЛЬКУЛЯТОРА
        public void AppendNumber(string number)
        {
            if (_newCalculation)
            {
                _currentInput = "";
                _newCalculation = false;
            }
            _currentInput += number;
            _view.DisplayText = _currentInput;
        }

        public void SetOperation(string operation)
        {
            if (!string.IsNullOrEmpty(_currentInput))
            {
                _firstNumber = double.Parse(_currentInput);
                _currentOperation = operation;
                _currentInput = "";
                _view.DisplayText = _firstNumber + " " + operation;
            }
        }

        public void CalculateResult()
        {
            if (!string.IsNullOrEmpty(_currentInput) && !string.IsNullOrEmpty(_currentOperation))
            {
                try
                {
                    double secondNumber = double.Parse(_currentInput);
                    double result = _calculator.Calculate(_firstNumber, secondNumber, _currentOperation);
                    _view.DisplayText = result.ToString();
                    _currentInput = result.ToString();
                    _currentOperation = "";
                    _newCalculation = true;
                }
                catch (Exception ex)
                {
                    _view.DisplayText = "Помилка: " + ex.Message;
                    _currentInput = "";
                    _currentOperation = "";
                }
            }
        }

        public void ClearCalculator()
        {
            _currentInput = "";
            _currentOperation = "";
            _firstNumber = 0;
            _newCalculation = true;
            _view.DisplayText = "";
        }

        // МЕТОДИ ДЛЯ ПЕРЕВІРКИ ВІКУ
        public void CheckAge()
        {
            try
            {
                if (string.IsNullOrEmpty(_view.AgeText))
                {
                    _view.AgeCategoryResult = "Введіть вік";
                    return;
                }

                int age = int.Parse(_view.AgeText);
                string category = _ageChecker.CheckAgeCategory(age);
                _view.AgeCategoryResult = category;
            }
            catch (FormatException)
            {
                _view.AgeCategoryResult = "Помилка: Введіть коректний вік";
            }
            catch (Exception ex)
            {
                _view.AgeCategoryResult = $"Помилка: {ex.Message}";
            }
        }

        // МЕТОДИ ДЛЯ ТАБЛИЦІ МНОЖЕННЯ
        public void GenerateMultiplicationTable()
        {
            try
            {
                if (string.IsNullOrEmpty(_view.TableNumberText))
                {
                    _view.MultiplicationTableResult = "Введіть число";
                    return;
                }

                int number = int.Parse(_view.TableNumberText);
                string table = _multiplicationTable.GenerateTable(number);
                _view.MultiplicationTableResult = table;
            }
            catch (FormatException)
            {
                _view.MultiplicationTableResult = "Помилка: Введіть коректне число";
            }
            catch (Exception ex)
            {
                _view.MultiplicationTableResult = $"Помилка: {ex.Message}";
            }
        }
    }
}