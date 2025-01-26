namespace BankAccount.lib;

/// <summary>
/// A class to represent a bank account with methods to deposit, withdraw and transfer currency.
/// </summary>
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

    /// <summary>
    /// The main Constructer of the class.
    /// </summary>
    /// <param name="accountNumber">The number of the account as a string.</param>
    /// <param name="holder">The person object of the account holder.</param>
    /// <param name="balance">The amount of balance at the creation of the object.</param>
    public BankAccount(string accountNumber, Person accountHolder, decimal balance) {
        _accountNumber = accountNumber;
        _accountHolder = accountHolder;
        _balance = balance;
    }

    /// <summary>
    /// Calculates if the account has Liquidity.
    /// </summary>
    /// <param name="ammount">The ammount to check with.</param>
    /// <returns>If the account has Liquidity.</returns>
    private bool CheckLiquidity(decimal ammount) {
        return (_balance - ammount) >= 0;
    }

    /// <summary>
    /// Adds the specified amount to the account balance.
    /// </summary>
    /// <param name="amount">The ammount to deposit.</param>
    public void Deposit(decimal ammount) {
        _balance += ammount;
    }

    /// <summary>
    /// Removes the specified ammount from the balance if it has Liquidity.
    /// </summary>
    /// <param name="ammount">The ammount to withdraw.</param>
    /// <returns>If the withdraw is succesful.</returns>
    public bool Withdraw(decimal ammount) {
        if(CheckLiquidity(ammount)) {
            _balance -= ammount;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Transfers a specified amount from one bank account to another.
    /// </summary>
    /// <param name="ammount">The ammount to transfer.</param>
    /// <param name="other">The bank account which will receive the ammount.</param>
    /// <returns>If the transfer is successful.</returns>
    public bool Transfer(BankAccount other, decimal ammount) {
        if(CheckLiquidity(ammount)) {
            other.Deposit(ammount);
            _balance -= ammount;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Prints the account info to the console.
    /// </summary>
    public void PrintAccount() {
        Console.WriteLine($"---{_accountNumber}---");
        Console.WriteLine($"Holder: {_accountHolder.GetFullName()}");
        Console.WriteLine($"Balance: {_balance}");
    }
}
