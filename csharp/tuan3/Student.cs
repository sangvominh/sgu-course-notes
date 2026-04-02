// IComparable trong C# chỉ bắt buộc method CompareTo(object), không bắt buộc equals()


using System;

// Student implement IComparable de giao tiep voi Sorting
// Tuong duong Java: class Student implements Comparable
public class Student : IComparable
{
    private string name;
    private int age;
    private double gpa;

    public Student(string name, int age, double gpa)
    {
        this.name = name;
        this.age = age;
        this.gpa = gpa;
    }

    // Getter methods
    public string getName()
    {
        return name;
    }

    public int getAge()
    {
        return age;
    }

    public double getGpa()
    {
        return gpa;
    }

    // Setter methods
    public void setName(string value)
    {
        name = value;
    }

    public void setAge(int value)
    {
        age = value;
    }

    public void setGpa(double value)
    {
        gpa = value;
    }

    public override string ToString()
    {
        return name + "\t" + age + " tuoi\tGPA: " + gpa;
    }

    public bool equals(Student other)
    {
        return name.Equals(other.getName()) && age == other.getAge() && Math.Abs(gpa - other.getGpa()) < 0.001;
    }

    // CompareTo nhan vao object, ep kieu ve Student
    // So sanh theo GPA giam dan
    public int CompareTo(object obj)
    {
        Student other = (Student)obj;
        
        // Neu 2 Student bang nhau (dung equals), tra ve 0
        if (this.equals(other))
        {
            return 0;
        }
        
        // So sanh GPA giam dan (GPA cao hon dung truoc)
        if (gpa > other.getGpa())
        {
            return -1;  // this dung truoc
        }
        else if (gpa < other.getGpa())
        {
            return 1;   // other dung truoc
        }
        else
        {
            // Neu GPA bang nhau, sap xep theo ten tang dan
            return name.CompareTo(other.getName());
        }
    }
}
