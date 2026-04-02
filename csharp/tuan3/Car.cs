using System;

// Car implement IComparable de giao tiep voi Sorting
// Tuong duong Java: class Car implements Comparable
public class Car : IComparable
{
    private string brand;
    private string model;
    private int year;
    private double price;

    public Car(string brand, string model, int year, double price)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.price = price;
    }

    // Getter methods
    public string getBrand()
    {
        return brand;
    }

    public string getModel()
    {
        return model;
    }

    public int getYear()
    {
        return year;
    }

    public double getPrice()
    {
        return price;
    }

    // Setter methods
    public void setBrand(string value)
    {
        brand = value;
    }

    public void setModel(string value)
    {
        model = value;
    }

    public void setYear(int value)
    {
        year = value;
    }

    public void setPrice(double value)
    {
        price = value;
    }

    public override string ToString()
    {
        return brand + " " + model + " (" + year + ")\t$" + price;
    }

    public bool equals(Car other)
    {
        return brand.Equals(other.getBrand()) && model.Equals(other.getModel()) && year == other.getYear();
    }

    // CompareTo nhan vao object, ep kieu ve Car
    // So sanh theo gia tang dan
    public int CompareTo(object obj)
    {
        Car other = (Car)obj;
        
        // Neu 2 Car bang nhau (dung equals), tra ve 0
        if (this.equals(other))
        {
            return 0;
        }
        
        // So sanh gia tang dan
        if (price < other.getPrice())
        {
            return -1;  // this dung truoc
        }
        else if (price > other.getPrice())
        {
            return 1;   // other dung truoc
        }
        else
        {
            // Neu gia bang nhau, sap xep theo nam moi hon truoc
            return other.getYear() - year;
        }
    }
}
