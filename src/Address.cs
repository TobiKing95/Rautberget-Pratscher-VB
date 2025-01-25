namespace BankAccount.lib;

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

    public Address(string city, string street, string postalCode, string country) {
        _city = city;
        _street = street;
        _postalCode = postalCode;
        _country = country;
    }
}
