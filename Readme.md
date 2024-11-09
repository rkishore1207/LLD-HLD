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

```SQL
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

