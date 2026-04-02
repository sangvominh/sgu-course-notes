using System;

// Contact implement IComparable de giao tiep voi Sorting
// Tuong duong Java: class Contact implements Comparable
public class Contact : IComparable
{
    private string firstName;
    private string lastName;
    private string phone;

    public Contact(string first, string last, string telephone)
    {
        firstName = first;
        lastName = last;
        phone = telephone;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public string getPhone()
    {
        return phone;
    }

    public void setFirstName(string value)
    {
        firstName = value;
    }

    public void setLastName(string value)
    {
        lastName = value;
    }

    public void setPhone(string value)
    {
        phone = value;
    }

    public override string ToString()
    {
        return lastName + ", " + firstName + "\t" + phone;
    }

    public bool equals(Contact other)
    {
        return lastName.Equals(other.getLastName()) && firstName.Equals(other.getFirstName());
    }

    // Phai ep kieu ve Contact truoc khi so sanh
    public int CompareTo(object obj)
    {
        Contact other = (Contact)obj;
        
        if (this.equals(other))
        {
            return 0;
        }
        
        // So sanh theo lastName truoc
        int result = lastName.CompareTo(other.getLastName());
        
        // Neu lastName giong nhau, so sanh theo firstName
        if (result == 0)
        {
            result = firstName.CompareTo(other.getFirstName());
        }
        
        return result;
    }
}
