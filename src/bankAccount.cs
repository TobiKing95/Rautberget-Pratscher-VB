namespace BankAccount.lib;

public class BankAccount {
    private string _accountNumber;
    private Person _accountHolder;
    private decimal _balance;

    public string AccountNumber {
        get => _accountNumber;
    }

    public Person AccountHolder {
        get => _accountHolder;
    }

    public decimal Balance {
        get => _balance;
    }

    public BankAccount(string accountNumber, Person accountHolder, decimal balance) {
        _accountNumber = accountNumber;
        _accountHolder = accountHolder;
        _balance = balance;
    }

    private bool CheckLiquidity(decimal ammount) {
        return (_balance - ammount) >= 0;
    }

    public void Deposit(decimal ammount) {
        _balance += ammount;
    }

    public bool Withdraw(decimal ammount) {
        if(CheckLiquidity(ammount)) {
            _balance -= ammount;
            return true;
        }

        return false;
    }

    public bool Transfer(BankAccount other, decimal ammount) {
        if(CheckLiquidity(ammount)) {
            other.Deposit(ammount);
            _balance -= ammount;
            return true;
        }

        return false;
    }

    public void PrintAccount() {
        Console.WriteLine($"---{_accountNumber}---");
        Console.WriteLine($"Holder: {_accountHolder.GetFullName()}({_accountHolder.GetAge()})");
        Console.WriteLine($"Balance: {_balance}");
    }
}
