# What is LINQ?
The LINQ (**Language Integrated Query**) is a part of a language but not a complete language. It was introduced by Microsoft with .NET Framework 3.5 and C# 3.0 and is available in System.Linq 
namespace.

LINQ provides us with common query syntax which allows us to query the data from various data sources. That means using a single query we can get or set the data from various data sources such as 
SQL Server database, XML documents, ADO.NET Datasets, and any other in-memory objects such as Collections, Generics, etc.

![image linq](https://dotnettutorials.net/wp-content/uploads/2019/04/Linq-applying-on-different-data-sources.png)

## Why use LINQ?
So, LINQ provides a **uniform programming model which will make it easy to work with different data sources by using a standard coding style. That means we don't require different syntaxes to 
query different data sources.

Below we can see that you can write the LINQ quiries using any .NET-supported programming languages such as C#, VB.NET, J#, F#, etc.
![structure](https://dotnettutorials.net/wp-content/uploads/2019/04/Why-should-we-use-linq-in-C.png)


## What are LINQ Providers?
A LINQ provider is a software that implements the IQueryProvider and IQueryable interface for a particular data source. In other words, it allows us to write LINQ queries against that data source. 
Without LINQ Provider we cannot execute our LINQ Queries.

**Let us discuss some of the LINQ Providers and how they work internally.**

### LINQ to Objects:
The LINQ to Objects provider allows us to query an in-memory object such as an array, collection, and generics types. It provides many built-in functions that we can use to perform many useful 
operations such as filtering, ordering, and grouping with minimum code.

### LINQ to SQL (DLINQ):
The LINQ to SQL Provider is designed to work with only the SQL Server database. You can consider this as an object-relational mapping (ORM) framework which allows one-to-one mapping between the 
SQL Server database and related .NET Classes. These .NET classes are going to be created automatically by the wizard based on the database table.

### LINQ to Datasets:
The LINQ to Datasets provider provides us the flexibility to query data cached in a Dataset in an easy and faster way. It also allows us to do further data manipulation operations such as 
searching, filtering, sorting, etc. on the Dataset using the LINQ Syntax.

### LINQ to Entities:
The LINQ to Entities provider looks like LINQ to SQL. It means it is also an object-relational mapping (ORM) framework that allows one-to-one, one-to-many, and many-to-many mapping between the 
database tables and .NET Classes. The point that you need to remember is that it is used to query any database such as SQL Server, Oracle, MySQL, DB2, etc. Now, it is called ADO.NET Entity 
Framework.

### LINQ to XML (XLINQ):
The LINQ to XML provider is basically designed to work with an XML document. So, it allows us to perform different operations on XML data sources such as querying or reading, manipulating, 
modifying, and saving the changes to XML documents. The System.Xml.Linq namespace contains the required classes for LINQ to XML.

### Parallel LINQ (PLINQ):
The Parallel LINQ or PLINQ was introduced with .NET Framework 4.0. This provider provides the flexibility of parallel implementation of LINQ to Objects. The PLINQ was designed in such a way 
that it uses the power of parallel programming which targets the Task Parallel Library. So if you want to execute your LINQ query simultaneously or parallel on different processors then you 
need to write the query using PLINQ.


## What are the different things required to write a LINQ Query?
In order to write a LINQ query, we need the following three things

1. Data Source (in-memory objects, SQL, XML)
2. Query
3. Execution of the query


## What is a Query?
A query is a set of instructions that are applied to a data source (i.e. in-memory objects, SQL, XML, etc.) to perform certain operations (i.e. CRUD operations) and then tells the shape of the 
output from that query.

**Each query is a combination of three things. They are as follows:**

1. Initialization (to work with a particular data source)
2. Condition (where, filter, sorting condition)
3. Selection (single selection, group selection, or joining)

What are the different ways to write a LINQ query?

We can write the LINQ query in three different ways. They are as follows

1. Query Syntax
2. Method Syntax
3. Mixed Syntax (Query + Method)

*Note:* From the performance point of view there is no difference between the above three approaches. So, which you need to use, it totally depends on your personal preference. 
But the point that you need to keep in mind is, behind the scene, the LINQ queries written using query syntax are translated into their lambda expressions before they are compiled. Thus I will 
focus more only on **Method Query**

## LINQ Method Syntax:
Method syntax becomes most popular now a day to writing LINQ queries. It uses a lambda expression to define the condition for the query. Method syntaxes are easy to write simple queries to 
perform read-write operations on a particular data source. But for complex queries Method syntaxes are a little hard to write as compared to query syntax.

In this approach, the LINQ query is written by using multiple methods by combining them with a dot (.). The Syntax is given below:

![Method Syntax](https://dotnettutorials.net/wp-content/uploads/2019/04/c-users-pranaya-pictures-linq-method-syntax-png.png)


*Example:* We have an integer list and we need to write a LINQ query that will return all the integers which are greater than 5.

```
using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //LINQ Query using Method Syntax
            var MethodSyntax = integerList.Where(obj => obj > 5).ToList();
            //Execution
            foreach(var item in MethodSyntax)
            {
                Console.Write(item + " ");
            }
            
            Console.ReadKey();
        }
    }
}
```
Let us have a look at the following diagram to understand Method Syntax.

![Method Syntax Diagram](https://dotnettutorials.net/wp-content/uploads/2019/04/c-users-pranaya-pictures-method-syntax-png.png)
