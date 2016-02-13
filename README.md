## C# LINQ Async extension methods library for async/await task

## Features
- <a href="#linq-async-extensions">LINQ Async Extensions</a>
- <a href="#linq-async-predicate-extensions">LINQ Async Precicate Extensions</a>
   - OrderByPredicateCompletion
   - StartPredicateConcurrently
- <a href="#linq-async-task-extensions">LINQ Async Task Extensions</a>
- <a href="#linq-async-enumerable-task-extensions">LINQ Async Enumerable Task Extensions</a>
   - OrderByCompletion

## Download
<a href="https://www.nuget.org/packages/Z.Linq.Async/" target="_blank"><img src="http://entityframework-plus.net/images/nuget/linq-async-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.Linq.Async/" target="_blank"><img src="http://entityframework-plus.net/images/nuget/linq-async-d.svg" alt="" /></a>

```
PM> Install-Package Z.Linq.Async
```

Stay updated with latest changes

<a href="https://twitter.com/zzzprojects" target="_blank"><img src="http://www.zzzprojects.com/images/twitter_follow.png" alt="Twitter Follow" height="24" /></a>
<a href="https://www.facebook.com/zzzprojects/" target="_blank"><img src="http://www.zzzprojects.com/images/facebook_like.png" alt="Facebook Like" height="24" /></a>

## LINQ Async Extensions
##### Problem
You want to use LINQ methods asynchronously.

##### Solution
All LINQ extensions methods and overloads are supported. You can easily create any asynchronous task.

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

## LINQ Async Predicate Extensions
##### Problem
You want to resolve a predicate asynchronously and start all predicates concurrently and/or order them by completion.

##### Solution
All LINQ extensions methods and overloads using a predicate is supported. You can easily use an asynchronously predicate and choose how the predicate will be resolved:
 - OrderByPredicateCompletion(bool)
 - StatePredicateConcurrently(bool)

**Support:**
- Deferred
   - SkipWhile
   - Where
- Immediate
   - All
   - Any
   - Count
   - First
   - FirstOrDefault
   - LongCount
   - Single
   - SingleOrDefault

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
##### Problem
You want to chain LINQ methods with Task&lt;IEnumerable&lt;T&gt;&gt;.

##### Solution
All LINQ extensions methods and overloads are supported, you can easily chain multiples LINQ methods before awaiting your final task.

**Support:**
 - Array
 - Enumerable
 - List

_Other types must use "AsEnumerable()" method to allow to chain LINQ methods._

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
##### Problem
You want to use LINQ methods with enumerable task and order them by completion.

##### Solution
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

## Contribution

Supporting & developing FREE features takes **hundreds** and **thousands** of hours! If you like our product please consider making a donation to keep us running.

<a href="http://www.zzzprojects.com/contribute/" target="_blank"><img src="http://www.zzzprojects.com/images/paypal-contribute-2.png" alt="Contribute" height="48"></a>

Contribution isn't all about money!
 - Blog it
 - Comment it
 - Fork it
 - Star it
 - Share it

A **HUGE thanks** for your extra support.

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
