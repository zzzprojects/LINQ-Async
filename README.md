## Library Powered By

This library is powered by [Entity Framework Extensions](https://entityframework-extensions.net/?z=github&y=entityframework-plus)

<a href="https://entityframework-extensions.net/?z=github&y=entityframework-plus">
<kbd>
<img src="https://zzzprojects.github.io/images/logo/entityframework-extensions-pub.jpg" alt="Entity Framework Extensions" />
</kbd>
</a>

---

# What's LINQ-Async?

LINQ-Async allows you to **chain async task and orders async predicate with fluent API**.

## Features
- <a href="#linq-async-extensions">LINQ Async Extensions</a>
- <a href="#linq-async-predicate-extensions">LINQ Async Precicate Extensions</a>
   - OrderByPredicateCompletion
   - StartPredicateConcurrently
- <a href="#linq-async-task-extensions">LINQ Async Task Extensions</a>
- <a href="#linq-async-enumerable-task-extensions">LINQ Async Enumerable Task Extensions</a>
   - OrderByCompletion
   - SelectResult

## Download
<a href="https://www.nuget.org/packages/Z.Linq.Async/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/linq-async-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.Linq.Async/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/linq-async-d.svg" alt="" /></a>

```
PM> Install-Package Z.Linq.Async
```

## LINQ Async Extensions
##### Problem
You want to use LINQ methods asynchronously.

##### Solution
All LINQ extension methods and overloads are supported. You can easily create any asynchronous task.

```chsarp
// Using Z.Linq

public Task<IEnumerable<Customer>> MyAsyncMethod(CancellationToken cancellationToken)
{
    List<Customer> customers = DB.GetCustomers();
    var task = list.WhereAsync(c => /* long predicate */, cancellationToken);

    // ... synchronous code ...
    
    return task;
}
```

## LINQ Async Predicate Extensions
##### Problem
You want to resolve a predicate asynchronously and start all predicates concurrently and/or order them by completion.

##### Solution
All LINQ extension methods and overloads using a predicate are supported. You can easily use an asynchronously predicate and choose how the predicate will be resolved:
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

// Change global default value
LinqAsyncManager.DefautlValue.OrderByPredicateCompletion = false;
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
All LINQ extensions methods and overloads are supported. You can easily chain multiples LINQ methods before awaiting your final task.

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

## LINQ Async Enumerable Task Extensions
##### Problem
You want to use LINQ methods with enumerable tasks and order them by completion.

##### Solution

**Support:**
- OrderByCompletion
- SelectResult 

```chsarp
// Using Z.Linq

public async Task<List<Customer>> MyAsyncTaskMethod(CancellationToken cancellationToken)
{
    // GET customer from concurrent web service
    IEnumerable<Task<List<Customer>>> task =  WebService.GetCustomers();
    
    // GET the customer list from the first web service completed
    var taskFirstCompleted = task.SelectResultByCompletion()
                                 .SelectResult()
								 .First()
								 
                   
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

## Contribute

Want to help us? Your donation directly helps us maintain and grow ZZZ Free Projects. 

We can't thank you enough for your support 🙏.

👍 [One-time donation](https://zzzprojects.com/contribute)

❤️ [Become a sponsor](https://github.com/sponsors/zzzprojects) 

### Why should I contribute to this free & open-source library?
We all love free and open-source libraries! But there is a catch... nothing is free in this world.

We NEED your help. Last year alone, we spent over **3000 hours** maintaining all our open source libraries.

Contributions allow us to spend more of our time on: Bug Fix, Development, Documentation, and Support.

### How much should I contribute?
Any amount is much appreciated. All our free libraries together have more than **100 million** downloads.

If everyone could contribute a tiny amount, it would help us make the .NET community a better place to code!

Another great free way to contribute is  **spreading the word** about the library.

A **HUGE THANKS** for your help!

## More Projects

- [EntityFramework Extensions](https://entityframework-extensions.net/)
- [Dapper Plus](https://dapper-plus.net/)
- [C# Eval Expression](https://eval-expression.net/)
- and much more! 

To view all our free and paid projects, visit our [website](https://zzzprojects.com/).
