##Use and chain async extension method in LINQ (Langugage Integrated Query)##

## Download
Version | NuGet | NuGet Install
------------ | :-------------: | :-------------:
Z.Linq.AsyncExtensions | <a href="https://www.nuget.org/packages/Z.Linq.Async/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/v/Z.Linq.Async.svg?style=flat-square" /></a> <a href="https://www.nuget.org/packages/Z.Linq.Async/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/dt/Z.Linq.Async.svg?style=flat-square" /></a> | ```PM> Install-Package Z.Linq.Async```

Stay updated with latest changes

<a href="https://twitter.com/zzzprojects" target="_blank"><img src="http://www.zzzprojects.com/images/twitter_follow.png" alt="Twitter Follow" height="24" /></a>
<a href="https://www.facebook.com/zzzprojects/" target="_blank"><img src="http://www.zzzprojects.com/images/facebook_like.png" alt="Facebook Like" height="24" /></a>

## Features
- [LINQ Async Extensions](https://github.com/zzzprojects/LINQ-Async/wiki/LINQ-AsyncExtensions)
- [LINQ Async Predicate Extensions](https://github.com/zzzprojects/LINQ-Async/wiki/LINQ-AsyncPredicateExtensions)
- [LINQ Async Task Extensions](https://github.com/zzzprojects/LINQ-Async/wiki/LINQ-AsyncTaskExtensions)
- [LINQ Async Enumerable Task Extensions](https://github.com/zzzprojects/LINQ-Async/wiki/LINQ-AsyncEnumerableExtensions)

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
- StartPredicateConcurrently
- Default value when none is specified

```chsarp
// Using Z.Linq
LinqAsyncManager.DefautlValue.OrderByPredicateCompletion = true;
LinqAsyncManager.DefaultValue.StartPredicateConcurrently = false;

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
Async Task extension methods allow to perform operation on Task&lt;IEnumerable&lt;T&gt;&gt;.

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

## LINQ Async Enumerable Extensions
Async Task extension methods allow to perform operation on IEnumerable&lt;Task&lt;T&gt;&gt;.

**Support:**
- OrderByCompletion
- SelectResult
- SelectResultByCompletion

```chsarp
// Using Z.Linq

public async Task<List<Customer>> MyAsyncTaskMethod(CancellationToken cancellationToken)
{
    int customerID = 4;
    
    // GET customer from concurrent web service
    IEnumerable<Task<List<Customer>>> task =  WebService.GetCustomers(4);
    
    // GET the customer list from the first web service completed
    var taskFirstCompleted = task.SelectResultByCompletion()
                                 .First();
                   
    // GET the five first customers which the predicate has completed
    var task = taskFirstCompleted.WhereAsync(c => MyAsyncPredicate(DB.IsCustomerActiveAsync(c)))
                                 .OrderByPredicateCompletion()
                                 .Take(5)
                                 .ToList();
    
    // ... synchronous code ...
    
    return task;
}
```

**[Learn more](https://github.com/zzzprojects/LINQ-AsyncExtensions/wiki/LINQ-AsyncEnumerableExtensions)**

## Contributing
_You received support from us and/or the FREE version helped you?_

Contribute to keep us developing FREE features and to thank us for our support.

We'll never require donations, but we appreciate them greatly

<a href="http://www.zzzprojects.com/contribute/" target="_blank"><img src="http://www.zzzprojects.com/images/paypal-contribute.png" alt="Contribute" height="48"></a>

A **huge thanks** for your extra support.


## More Projects

**Entity Framework**
- [Entity Framework Extensions](http://www.zzzprojects.com/products/dotnet-development/entity-framework-extensions/)
- [Entity Framework Plus](https://github.com/zzzprojects/EntityFramework-Plus)

**Bulk Operations**
- [NET Entity Framework Extensions](http://www.zzzprojects.com/products/dotnet-development/entity-framework-extensions/)
- [NET Bulk Operations](http://www.zzzprojects.com/products/dotnet-development/bulk-operations/)

**Expression Evaluator**
- [Eval SQL.NET](https://github.com/zzzprojects/Eval-SQL.NET)
- [Eval Expression.NET](https://github.com/zzzprojects/Eval-Expression.NET)

**Others**
- [Extension Methods Library](https://github.com/zzzprojects/Z.ExtensionMethods/)
- [LINQ Async](https://github.com/zzzprojects/Linq-AsyncExtensions)

**Need more info?** info@zzzprojects.com

Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!
