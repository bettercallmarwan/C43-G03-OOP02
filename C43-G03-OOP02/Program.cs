namespace C43_G03_OOP02;

#region 1.Design and implement a Class for the employees in a company.

public enum SecurityLevel
{
    Guest, Developer, Secretary, DBA
}

public enum Gender
{
    Male, Female
}

public class Employee
{
    private int Id { get; set; }
    private string Name { get; set; }
    private decimal Salary { get; set; }
    private DateTime HireDate { get; set; }
    private Gender Gender { get; set; }
    private SecurityLevel SecurityLevel { get; set; }

    public Employee(int id, string name, decimal salary, DateTime hireDate, Gender gender, SecurityLevel securityLevel)
    {
        Id = id;
        Name = name;
        Salary = salary;
        HireDate = hireDate;
        Gender = gender;
        SecurityLevel = securityLevel;
    }

    public override string ToString()
    {
        return String.Format(
            "Employee ID: {0}\n" +
            "Name: {1}\n" +
            "Security Level: {2}\n" +
            "Salary: {3:C}\n" +
            "Hire Date: {4:d}\n" +
            "Gender: {5}",
            Id,
            Name,
            SecurityLevel,
            Salary,
            HireDate,
            Gender
        );
    }
}
#endregion

#region 2.Develop a Class to represent the Hiring Date Data

public class HiringDate
{
    private int day;
    private int month;
    private int year;

    public int Day
    {
        get { return day; }
        set
        {
            if(value < 1 || value > 31)
                throw new ArgumentException("day has to be between 1 and 31");
            day = value;
        }
    }
    
    public int Month
    {
        get { return month; }
        set
        {
            if (value < 1 || value > 12)
                throw new ArgumentException("month has to be between 1 and 31");
            month = value;
        }
    }
    
    public int Year
    {
        get { return year; }
        set
        {
            if (value < 1900)
                throw new ArgumentException("year must be more than 1980");
            year = value;
        }
    }

    public HiringDate(int day, int month, int year)
    {
        day = day;
        month = month;
        year = year;
    }

    public override string ToString()
    {
        return $"{day}-{month}-{year}";
    }
    
}

#endregion

#region 3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

class Program
{
    static void Main(string[] args)
    {
        Employee[] EmpArr = new Employee[3];


        try
        {
            EmpArr[0] = new Employee(1, "marwan", 5000, new DateTime(2025, 1, 1), Gender.Male, SecurityLevel.Developer);
            EmpArr[1] = new Employee(2, "Ahnmed", 2000, new DateTime(2025, 1, 5), Gender.Male, SecurityLevel.Guest);
            EmpArr[2] = new Employee(3, "sara", 2500, new DateTime(2023, 5, 2), Gender.Female, SecurityLevel.DBA);
            
            

        }catch (ArgumentException ex)
        {
            Console.WriteLine($"error making employee: {ex.Message}");
        }

        try
        {
            foreach (Employee e in EmpArr)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("************************");
                Console.WriteLine("************************");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"error displaying employees data: {ex.Message}");
        }
    }
}

#endregion

#region 4.Sort the employees based on their hire date then Print the sorted array.



#endregion

#region 5-Design a program for a library management system where:

/// <summary>
/// in this example, inheritance simplifies the design, as it prevents us from code redundancy.
/// so, in our example we have three classes (book, ebook and printed book),
/// since we used inheritance, i didnt have to write the basic attributes for ebook and printed book(title, author, isavailable, isbn) because they all inherit from the base class (book), so they will have the same attributed
/// then ofc, i can add the special attributes for each class (filesize and page count)
/// also inheritance allowed us (with the use of abstraction) to ensure that every child class contains some functions as (display), and it also forces us to implement this function according to the class
/// 
/// </summary>

public abstract class Book
{

    
    public string Title { get; private protected set; }
    public string Author { get; private protected set; }
    public bool IsAvailable { get; private protected set; }
    public string Isbn { get; private protected set; }

    protected Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
        IsAvailable = true;
    }

    public abstract void Display();

}

public class Ebook : Book
{
    private double fileSize;

    public double FileSize { get; protected set; }

    public Ebook(String title, string author, string isbn, double fileSize) : base(title, author, isbn)
    {
        FileSize = fileSize;
    }

    public override void Display()
    {
        Console.WriteLine($"title: {Title}");
        Console.WriteLine($"author: {Author}");
        Console.WriteLine($"isbn: {isbn}");
        Console.WriteLine($"Available: {(IsAvailable ? "Yes" : "No")}");
        Console.WriteLine($"File Size: {FileSize} MB");
    }

}


public class PrintedBook : Book
{
    private int pageCount;
    
    public int PageCount { get; protected set; }

    public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
    {
        PageCount = pageCount;
    }
    
    
    public override void Display()
    {
        Console.WriteLine($"title: {Title}");
        Console.WriteLine($"author: {Author}");
        Console.WriteLine($"isbn: {isbn}");
        Console.WriteLine($"Available: {(IsAvailable ? "Yes" : "No")}");
        Console.WriteLine($"pagw count: {PageCount} MB");
    }
    
    
}

#endregion
