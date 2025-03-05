# REGEX 
1. \A - Matches if the specified characters are at the start of a string 
2. \b - Matches if the specified characters are at the beginning or end of a word 
3. \d - Matches any decimal digit equivalent to 0 - 9

# What is collection in C#?
Collection are specialized classes used to store and manage group of objects. 
There are two types of collections:

1. Generic Collection
Generic Collections are strongly typed collections, means they enforce typesafety at compile time and derived from 
`System.Collections.Generic`
Generic Collections was introduced in DotNet version 2.0

Features of Generic Collections
- Type Safety (Only a specified date type can be stored, that minimizes the typecasting erors)
- Performance (Faster cause of efficient type casting)
- Compile Time checking (error gets caught during compilation reducing runtime exceptions)

Following are the list of Generic Collection Classes: 
- List<T>
    A Dynamic Array storing elements of a specified type
- Dictionary<TKey, TValue>
    Stores key value pairs with unique keys
- Queue<T>
   Implements FIFO (First in first out) Structure     
- Stack<T>
   Implements LIFO (Last in First out) Structure 
- HashSet<T>
    Storing unique elements elementing duplicates
- StoredList<TKey, Tvalue>
    Stores key value pair sorted by keys

2. Non-Generic Collection
None generic collection can store elements of any data types as they use the base object type
These collection belongs to 
`System.Collections` were widely used before before Generic Collections

Features
- No Type Safety (Elements must be cast to their orginal types when retrived) 
- Less Performance 
- Flexibility Issues (because it can store mixed data types)

Following are the list of Non-Generic Collection Classes: 
- ArrayList
    A resizable array that can store elements of any types 
- Hashtable
    Stores key value pairs but doesnt enforce strong typing on key and values    
- Queue
    Implements FIFO structure but allows mixed types
- Stack
    Implements LIFO sturcture but allows mixed types
- StoredList
    Stores key value pairs sorted by keys without strong typing
- BitArray
    Manages compact Array ----- i.e. true, false

Differences between Generic and Non-Generic Collection
|Generic | Non-Generic|
|---|---|
|Belongs to System.Collections.Generic Namespace|Belongs to System.Collection Namespace|
|Strongly Typed|Loosly Typed|
|High Performance| Low Performance|
|Compile Time error handling mechanism|Run Time error versilities|
|Can be used for Modern applications|Legacy Coding Standard for Mixed Type|

