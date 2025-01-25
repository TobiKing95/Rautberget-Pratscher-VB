namespace BankAccount.lib;

/// <summary>
/// a class to calculate the data for person
/// </summary>
public class Person {
    private string _firstName;
    private string _lastName;
    private Address _address;
    private DateTime _birthday;

    /// <summary>
    /// the constructor for Person
    /// </summary>
    /// <param name="firstname"></param>
    /// <param name="lastname"></param>
    /// <param name="adress"></param>
    /// <param name="birthday"></param>
    public Person(string firstName, string lastName, Address address, DateTime birthday) {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
        _birthday = birthday;
    }

    /// <summary>
    /// Adds the first and last name of the person together.
    /// </summary>
    /// <returns>The full name.</returns>
    public string GetFullName() {
        return _firstName + ' ' + _lastName;
    }

    /// <summary>
    /// calculates the age with the date
    /// </summary>
    /// <returns>the age</returns>
    public int GetAge() {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - _birthday.Year;

        if(_birthday > currentDate.AddYears(-age)) {
            age--;
        }

        return age;
    }
}
