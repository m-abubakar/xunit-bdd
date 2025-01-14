
using Newtonsoft.Json.Converters;

class Calculator  {

    public void SetFirstNumber(int firstNumber) {
        this.firstNumber = firstNumber;
    }

    public void SetSecondNumber(int secondNumber) {
        this.secondNumber = secondNumber;
    }
    public void AddNumbers() {
        Result = firstNumber + secondNumber;
    }

    public int firstNumber;
    public int secondNumber;
    public int Result;
}
