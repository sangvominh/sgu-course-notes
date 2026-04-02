using System;

public class PhoneList
{
    public static void Run()
    {
        Contact[] friends = new Contact[8];
        friends[0] = new Contact("John", "Smith", "618-555-7384");
        friends[1] = new Contact("Sarah", "Barnes", "215-555-3827");
        friends[2] = new Contact("Mark", "Riley", "733-555-2969");
        friends[3] = new Contact("Laura", "Getz", "663-555-3984");
        friends[4] = new Contact("Larry", "Smith", "464-555-3489");
        friends[5] = new Contact("Frank", "Phelps", "322-555-2284");
        friends[6] = new Contact("Mario", "Guzman", "804-555-9066");
        friends[7] = new Contact("Marsha", "Grant", "243-555-2837");

        Console.WriteLine("=== Danh sach truoc khi sap xep ===");
        for (int i = 0; i < friends.Length; i++)
        {
            Console.WriteLine(friends[i]);
        }

        Sorting.selectionSort(friends);

        Console.WriteLine("\n=== Danh sach sau khi sap xep (Selection Sort) ===");
        for (int i = 0; i < friends.Length; i++)
        {
            Console.WriteLine(friends[i]);
        }
    }
}