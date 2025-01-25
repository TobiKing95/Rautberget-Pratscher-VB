namespace BankAccount.lib;

public class Person {
    private string _firstName;
    private string _lastName;
    private Address _address;
    private DateTime _birthday;

    public Person(string firstName, string lastName, Address address, DateTime birthday) {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
        _birthday = birthday;
    }

    public string GetFullName() {
        return _firstName + ' ' + _lastName;
    }

    public int GetAge() {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - _birthday.Year;

        if(_birthday > currentDate.AddYears(-age)) {
            age--;
        }

        return age;
    }
}
