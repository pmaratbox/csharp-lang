var account = new Account(100);
account.Deposit(50);
Console.WriteLine(account.Balance);

class Account
{
    private int balance;

    public Account(int initial) => balance = initial;

    public void Deposit(int amount) => balance += amount;

    public int Balance => balance;
}
