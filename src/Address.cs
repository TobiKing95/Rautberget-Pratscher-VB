namespace BankAccount.lib;

/// <summary>
/// A class that represents a Address with a street, city, state and postal code.
/// </summary>
public class Address {
    private string _city;
    private string _street;
    private string _postalCode;
    private string _country;

    public string City {
        get => _city;
    }

    public string Street {
        get => _street;
    }

    public string PostalCode {
        get => _postalCode;
    }

    public string Country {
        get => _country;
    }

    /// <summary>
    /// The main constructer of the Address object.
    /// </summary>
    /// <param name="street">The name of the street.</param>
    /// <param name="city">The name of the city.</param>
    /// <param name="state">The name of the state.</param>
    /// <param name="code">The postal code of the area.</param>
    public Address(string city, string street, string postalCode, string country) {
        _city = city;
        _street = street;
        _postalCode = postalCode;
        _country = country;
    }
}
