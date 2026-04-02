using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            ShowMenu();
            Console.Write("Chon chuc nang (0-5): ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    TestContact();
                    break;
                case 2:
                    TestStudent();
                    break;
                case 3:
                    TestCar();
                    break;
                case 4:
                    TestBook();
                    break;
                case 5:
                    TestAll();
                    break;
                case 0:
                    Console.WriteLine("Cam on ban da su dung chuong trinh!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            if (choice != 0)
            {
                Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (choice != 0);
    }

    static void ShowMenu()
    {
        Console.WriteLine("=== MENU CHUONG TRINH ===");
        Console.WriteLine("1. Test Contact (sap xep theo ten)");
        Console.WriteLine("2. Test Student (sap xep theo GPA)");
        Console.WriteLine("3. Test Car (sap xep theo gia)");
        Console.WriteLine("4. Test Book (sap xep theo ten sach)");
        Console.WriteLine("5. Test tat ca");
        Console.WriteLine("0. Thoat");
        Console.WriteLine("========================");
    }

    static void TestContact()
    {
        Console.WriteLine("=== TEST CONTACT ===\n");
        PhoneList.Run();
    }

    static void TestStudent()
    {
        Console.WriteLine("=== TEST STUDENT ===\n");
        Student[] students = new Student[5];
        students[0] = new Student("Nguyen Van A", 20, 3.2);
        students[1] = new Student("Tran Thi B", 21, 3.8);
        students[2] = new Student("Le Van C", 19, 3.5);
        students[3] = new Student("Pham Thi D", 22, 3.8);
        students[4] = new Student("Hoang Van E", 20, 2.9);

        Console.WriteLine("Truoc khi sap xep:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }

        Sorting.selectionSort(students);

        Console.WriteLine("\nSau khi sap xep:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }
    }

    static void TestCar()
    {
        Console.WriteLine("=== TEST CAR ===\n");
        Car[] cars = new Car[4];
        cars[0] = new Car("Toyota", "Camry", 2022, 25000);
        cars[1] = new Car("Honda", "Civic", 2023, 22000);
        cars[2] = new Car("BMW", "X5", 2021, 55000);
        cars[3] = new Car("Ford", "Mustang", 2023, 45000);

        Console.WriteLine("Truoc khi sap xep:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        Sorting.insertionSort(cars);

        Console.WriteLine("\nSau khi sap xep:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }

    static void TestBook()
    {
        Console.WriteLine("=== TEST BOOK ===\n");
        Book[] books = new Book[5];
        books[0] = new Book("Java Programming", "John Smith", 450, 59.99);
        books[1] = new Book("C# Fundamentals", "Mary Johnson", 380, 49.99);
        books[2] = new Book("Data Structures", "Bob Wilson", 520, 79.99);
        books[3] = new Book("Algorithms", "Alice Brown", 600, 89.99);
        books[4] = new Book("C# Fundamentals", "Tom Davis", 420, 54.99);

        Console.WriteLine("Truoc khi sap xep:");
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i]);
        }

        Sorting.selectionSort(books);

        Console.WriteLine("\nSau khi sap xep:");
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i]);
        }
    }

    static void TestAll()
    {
        TestContact();
        Console.WriteLine("\n" + new string('=', 50) + "\n");
        TestStudent();
        Console.WriteLine("\n" + new string('=', 50) + "\n");
        TestCar();
        Console.WriteLine("\n" + new string('=', 50) + "\n");
        TestBook();
    }
}
