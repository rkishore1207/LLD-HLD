# Low Level and High Level Design and LINQ

### LINQ Operators
    1. Aggregate Operators
    2. Grouping Operators
    3. Restriction Operators
    4. Projection Operators
    5. Set Operators
    6. Partitioning Operators
    7. Conversion Operators
    8. Generation Operators
    9. Query Operators
    10.Join Operators
    11.Custom Sequence Operators
    12.Quantifiers Operators
    13.Miscellaneous Operators

### LINQ Execution
    1. Deferred Execution - Does not execute on the defined place, it will execute on the iteratable of the result place.
    2. Immediate Execution - It will execute where exactly that LINQ defined.

```C#
    //Deferred Execution
    List<string> countries = new List<string>() { "India", "USA", "Germany", "UK", "Italy", "America"};
    IEnumerable<string> strings = countries.Where(country => country.Length > 2);
    countries.Add("Japan");
    foreach (var country in strings)
    {
        Console.WriteLine(country);
    }

    //Immediate Execution
    List<string> immediateExecution = new List<string>() { "India", "USA", "Germany", "UK", "Italy", "America" };
    int count = immediateExecution.Where(country => country.Length > 2).Count();
    immediateExecution.Add("Japan");
    Console.WriteLine(count);
```

### Cast and OfType Operator

![Linq Casting](https://github.com/user-attachments/assets/76802a4d-53bd-4a25-b264-53023ef0558c)

### AsEnumerable()
* If we are writing any LINQ in the api and let that execute on Server, then If we use AsEnumerable() then the part before the AsEnumerable() will execute on the server side and after the commands will execute in the api side itself.

### Group By
```C#
// Group By
var students = new Student().GetAllStudents().GroupBy(student => student.Country).
                            Select(x => 
                                        new { 
                                                StudentKey = x.Key, 
                                                Students = x.OrderBy(z => z.Name)
                                            }).OrderBy(y => y.StudentKey ).ToList();

foreach (var student in students)
{
    Console.WriteLine(student.StudentKey + "\t" + student.Students.Count());
    Console.WriteLine("---------------");
    foreach (var item in student.Students)
    {
        Console.WriteLine("{0} - {1}", item.Name, item.Country);
    }
    Console.WriteLine("\n");
}
```

## Element Operators

### First() and FirstOrDefault()
* First() will return the first element from the list, if there is no element in the list then it will throw an exception.
* FirstOrDefault() it is as same as the First(), but if there is no element in the list then it will return the Default value for the specified type.

### Single() and SingleOrDefault()
* Single() will return the single element from the list, if the list is having only one element. If the list doesn't have any element or doesn't match the specified condition, it will throw an exception.
* SingleOrDefault() same as the Single(), but won't throw an exception if there is no element in the list, but if the specified condition is match with more than one element then it would also throw an exception.

So, FirstOrDefault() return the first matched element even though if the list contains more matched elements, whereas SingleOrDefault() return the Single element only one element is match the condition, but will throw exception if multiple elements match the condition.

### ElementAt and ElementAtOrDefault()
* Will return the Element at the specified index, and return default if there is no matched element.

### DefaultIfEmpty()
* If the list doesn't have any elements, then it will return the defualt value as enumerable, we could able to specify the defualt value by ourself, if there is no element in the list.