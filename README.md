##Async extension methods for LINQ (Language Integrated Query)##

## Download
Version | NuGet | NuGet Install
------------ | :-------------: | :-------------:
Z.Linq.AsyncExtensions | <a href="https://www.nuget.org/packages/Z.Linq.AsyncExtensions/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/v/Z.Linq.AsyncExtensions.svg?style=flat-square" /></a> <a href="https://www.nuget.org/packages/Z.Linq.AsyncExtensions/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/dt/Z.Linq.AsyncExtensions.svg?style=flat-square" /></a> | ```PM> Install-Package Z.Linq.AsyncExtensions```

## Features
- LINQ Async Extensions
- LINQ Async Task Extensions

_All LINQ Enumerable extensions methods are supported._

## LINQ Async Extensions
**Async Extension methods to perform operation on LINQ to objects asynchronously.**

```chsarp
// Using Z.Linq

public async Task<IEnumerable<Customer>> MyAsyncMethod(CancellationToken cancellationToken)
{
    List<Customer> customers = DB.GetCustomers();
    var taskFilter = list.WhereAsync(c => c.IsActive, cancellationToken);

    ... code ...
    
    return await taskFilter;
}
```

> If a cancellationToken is used, "ThrowIfCancellationRequested()" is invoked in the Enumerator.MoveNext() method.

## LINQ Async Task Extensions
**Async Task Extension methods to perform operation on LINQ to objects asynchronously (Task&lt;&lt;IEnumerable&lt;T&gt;&gt;&gt;).**

```chsarp
// Using Z.Linq

public async Task<List<Customer>> MyAsyncTaskMethod(CancellationToken cancellationToken)
{
    Task<IEnumerable<Customer>> task = MyAsyncMethod(cancellationToken);

    // WITH LINQ Task Extensions
    Task<IEnumerable<Customer>> taskFilter = task.WhereAsync(x => x.HasPhone, cancellationToken);
    Task<List<Customer>> taskList = taskFilter.ToListAsync(cancellationToken);

    ... code ...
    
    return await taskList;
    
    // Use AsEnumerableAsync to convert Task<List<T>>, Task<IList<T>>, etc.. to Task<IEnumerable<T>>
    // Task<IEnumerable<int>> task = MyAsyncMethod(cancellationToken).AsEnumerableAsync(cancellationToken);
}
```

## Support
Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!

- [Documentation](https://github.com/zzzprojects/LINQ-AsyncExtensions/wiki)
- sales@zzzprojects.com

## More Projects
- Entity Framework
  - [NET Entity Framework Extensions](http://www.zzzprojects.com/products/dotnet-development/entity-framework-extensions/)
  - [EntityFramework Plus](https://github.com/zzzprojects/EntityFramework-Plus) _(Under development)_
- Bulk Operations
  - [NET Entity Framework Extensions](http://www.zzzprojects.com/products/dotnet-development/entity-framework-extensions/)
  - [NET Bulk Operations](http://www.zzzprojects.com/products/dotnet-development/bulk-operations/)
- Expresssion Evaluator
  - [Eval Expression.NET](https://github.com/zzzprojects/Eval-Expression.NET)
  - [Eval SQL.NET](https://github.com/zzzprojects/Eval-SQL.NET)
- Others
  - [Extension Methods Library](https://github.com/zzzprojects/Z.ExtensionMethods/)
  - [Linq AsyncExtensions](https://github.com/zzzprojects/Linq-AsyncExtensions)
