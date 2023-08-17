using ASM.asm3;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();


        account.Deposit(1000);
        account.Withdraw(500);


    }

}