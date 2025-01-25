namespace Sample1;

using BankAccount.lib;

class Programm {
    public static void Main() {
        Address addr = new Address("Rinnegg", "Hohenbergstrase 11", "8061", "France");
        DateTime bday = new DateTime(2009, 2, 26);
        Person person = new Person("markus", "raudberget", addr, bday);

        BankAccount acc = new BankAccount("423097", person, 2000);
        BankAccount acc2 = new BankAccount("47389", person, 1000);

        acc.PrintAccount();
        acc2.PrintAccount();

        acc2.Transfer(acc, 1000);

        acc.PrintAccount();
        acc2.PrintAccount();

        acc2.Transfer(acc, 1000);

        acc.PrintAccount();
        acc2.PrintAccount();
    }
}
