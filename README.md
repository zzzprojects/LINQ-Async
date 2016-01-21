##Async extension methods for LINQ (Language Integrated Query)##

## Download
Version | NuGet | NuGet Install
------------ | :-------------: | :-------------:
Z.Linq.AsyncExtensions | <a href="https://www.nuget.org/packages/Z.Linq.Async/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/v/Z.Linq.Async.svg?style=flat-square" /></a> <a href="https://www.nuget.org/packages/Z.Linq.Async/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/dt/Z.Linq.Async.svg?style=flat-square" /></a> | ```PM> Install-Package Z.Linq.Async```

## Features
- LINQ Async Extensions
- LINQ Async Predicate Extensions
- LINQ Async Task Extensions

_All LINQ Enumerable extensions methods are supported._

## LINQ Async Extensions
Async extension methods allow to perform operation on LINQ to objects asynchronously.

```chsarp
// Using Z.Linq

public Task<IEnumerable<Customer>> MyAsyncMethod(CancellationToken cancellationToken)
{
    List<Customer> customers = DB.GetCustomers();
    var task = list.WhereAsync(c => c.IsActive, cancellationToken);

    // ... synchronous code ...
    
    return task;
}
```

> If a cancellationToken is used, "ThrowIfCancellationRequested()" is invoked in the Enumerator.MoveNext() method.

**[Learn more](https://github.com/zzzprojects/LINQ-AsyncExtensions/wiki/LINQ-AsyncExtensions)**

## LINQ Async Predicate Extensions
Async Predicate extension methods allow to perform operation using an async predicate on LINQ to objects asynchronously.

**Support:**
- OrderByPredicateCompletion
- StartAllPredicate

```chsarp
// Using Z.Linq
public Task<IEnumerable<Customer>> MyAsyncTaskMethod(CancellationToken cancellationToken)
{
    List<Customer> customers = DB.GetCustomers();
    
    // GET all customers by predicate completion
    var task = list.WhereAsync(c => MyAsyncPredicate(DB.IsCustomerActiveAsync(c)))
                         .OrderByPredicateCompletion();

    // ... synchronous code ...
    
    return task;
}
```

**[Learn more](https://github.com/zzzprojects/LINQ-AsyncExtensions/wiki/LINQ-AsyncPredicateExtensions)**

## LINQ Async Task Extensions
Async Task extension methods allow to perform operation on Task&lt;&lt;IEnumerable&lt;T&gt;&gt;&gt;.

```chsarp
// Using Z.Linq

public async Task<List<Customer>> MyAsyncTaskMethod(CancellationToken cancellationToken)
{
    // GET the five first customers which the predicate has completed
    var task = list.WhereAsync(c => MyAsyncPredicate(DB.IsCustomerActiveAsync(c)))
                         .OrderByPredicateCompletion()
                         .Take(5)
                         .ToList();


    // ... synchronous code ...
    
    return task;
}
```

**[Learn more](https://github.com/zzzprojects/LINQ-AsyncExtensions/wiki/LINQ-AsyncTaskExtensions)**

## More Projects
- Entity Framework
  - [NET Entity Framework Extensions](http://www.zzzprojects.com/products/dotnet-development/entity-framework-extensions/)
  - [EntityFramework Plus](https://github.com/zzzprojects/EntityFramework-Plus) _(Under development)_
- Bulk Operations
  - [NET Entity Framework Extensions](http://www.zzzprojects.com/products/dotnet-development/entity-framework-extensions/)
  - [NET Bulk Operations](http://www.zzzprojects.com/products/dotnet-development/bulk-operations/)
- Expression Evaluator
  - [Eval Expression.NET](https://github.com/zzzprojects/Eval-Expression.NET)
  - [Eval SQL.NET](https://github.com/zzzprojects/Eval-SQL.NET)
- Others
  - [Extension Methods Library](https://github.com/zzzprojects/Z.ExtensionMethods/)
  - [LINQ Async](https://github.com/zzzprojects/Linq-AsyncExtensions)

**Need more info?** info@zzzprojects.com

Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!
