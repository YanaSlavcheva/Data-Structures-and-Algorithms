<<<<<<< HEAD
<!-- attr: { id:'title', class:'slide-title', hasScriptWrapper:true } -->
# Advanced Data Structures
## Wintellect Power Collections, C5 Collections

<div class="signature">
    <p class="signature-course">Data Structures and Algorithms</p>
    <p class="signature-initiative">Telerik Software Academy</p>
    <a href="http://academy.telerik.com" class="signature-link">http://academy.telerik.com</a>
</div>

<!-- attr: { class:'table-of-contents' } -->
=======
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Advanced Data Structures
##  Wintellect Power Collections, C5 Collections

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3
# Table of Contents
* Standard .NET Data Structures
  * Special .NET Collections
* Wintellect Power Collections
  * Installation
  * Power Collection Classes
  * Implementing Priority Queue
* C5 Collections
<<<<<<< HEAD

<!-- attr: { class:'table-of-contents', showInPresentation:true } -->
<!-- # Table of Contents -->
* Other Advanced Data Structures
  * Suffix trees
  * Interval trees
  * Ropes
  * Tries
  * Others


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true } -->
<!-- # Standard .NETData Structures
## Built-In .NET Data Structure Implementations -->


<!-- attr: { hasScriptWrapper:true } -->
=======
* Other Advanced Data Structures
  * Suffix trees, interval trees, ropes, tries, etc.

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Standard .NETData Structures
##  Built-In .NET Data Structure Implementations

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3
# .NET Data Structures
* Linear structures
  * Lists: `List<T>`, `LinkedList<T>`
  * Stacks: `Stack<T>`
  * Queues: `Queue<T>`
* Dictionaries (maps)
<<<<<<< HEAD
  * Dictionary<K,V>, `SortedDictionary<K,V>`
=======
  * `Dictionary<K,V>`, `SortedDictionary<K,V>`
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3
  * No standard multi-dictionary .NET class
* Balanced search tree structures
  * `SortedSet<T>`, `SortedDictionary<K,V>`

<<<<<<< HEAD

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.95em' } -->
<!-- # .NET Data Structures -->
* Sets and bags
  * Sets – `HashSet<T>`, `SortedSet<T>`
  * Bag – **no** standard .NET class
* Ordered sets, bags and dictionaries
* Priority queues / heaps &rarr; **no**
* Special tree structures &rarr; **no**
  * Suffix tree, interval tree, index tree, trie
* Graphs &rarr; **no**
  * Directed / undirected
  * Weighted /un-weighted
  * Connected/ non-connected


<!-- attr: { hasScriptWrapper:true } -->
# .NET Generic Collections
<img class="slide-image" src="imgs/generic-collections.png" style="width:75%; left:10%" />


<!-- attr: { hasScriptWrapper:true } -->
# .NET Untyped Collections
<img class="slide-image" src="imgs/untyped-collections.png" style="width:75%; left:10%" />


<!-- attr: { hasScriptWrapper:true, style:'font-size:0.9em' } -->
=======
<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# .NET Data Structures (2)
* Sets and bags
  * Sets – `HashSet<T>`, `SortedSet<T>`
  * Bag – no standard .NET class
* Ordered sets, bags and dictionaries
* Priority queues / heaps &rarr; no
* Special tree structures &rarr; no
  * Suffix tree, interval tree, index tree, trie
* Graphs &rarr; no
  * Directed / undirected, weighted /un-weighted, connected/ non-connected, …

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# .NET Generic Collections

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# .NET Untyped Collections

<!-- attr: { showInPresentation:true, style:'' } -->
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3
# Special .NET Collections
* `Collection<T>`
  * Inheritable `IList<T>`, virtual `Add()` / `Remove()`
* `ObservableCollection<T>`
<<<<<<< HEAD
* Event CollectionChanged
* `IReadOnlyCollection<T>`
  * Supports only `Count` and `GetEnumerator()`
* `IReadOnlyList<T>`
  * Supports only `Count`, `[]` and `GetEnumerator()`
* Concurrent collections (thread-safe)
  * `BlockingCollection<T>`
  * ` ConcurrentBag<T>`, …


<!-- attr: { class:'slide-section demo', showInPresentation:true } -->
<!-- # Special .NET Collections -->
##  [Demo]()


<!-- attr: { class:'slide-section', showInPresentation:true } -->
<!-- # Wintellect Power Collections
## Open Source C# Implementation of All Major Data Structures: Lists, Sets, Bags, Dictionaries, etc. -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Wintellect Power Collections
* Wintellect Power Collections is powerful open-source data structure library
* Download: http://powercollections.codeplex.com
* Installing Power Collections in Visual Studio
* Use NuGet package manager
=======
  * Event `CollectionChanged`
* `IReadOnlyCollection<T>`
    * Supports only `Count` and `GetEnumerator()`
* `IReadOnlyList<T>`
  * Supports only `Count`, `[]` and `GetEnumerator()`
* Concurrent collections (thread-safe)
  * `BlockingCollection<T>`, `ConcurrentBag<T>`, …

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Special .NET Collections
##  [Demo]()

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Wintellect Power Collections
##  Open Source C# Implementation of All Major Data Structures: Lists, Sets, Bags, Dictionaries, etc.

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Wintellect Power Collections
* Wintellect Power Collections is powerful open-source data structure library
  * Download: http://powercollections.codeplex.com
* Installing Power Collections in Visual Studio
  * Use NuGet package manager
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Power Collections Classes
<<<<<<< HEAD
* Bag<T>
* A bag (multi-set) based on hash-table
* Unordered collection (with duplicates)
* Add / Find / Remove work in time O(1)
* T should provide Equals() and GetHashCode()
* OrderedBag<T>
* A bag (multi-set) based on balanced search tree
* Add / Find / Remove work in time O(log(N))
* T should implement IComparable<T>


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Power Collections Classes (2)
* Set<T>
* A set based on hash-table (no duplicates)
* Add / Find / Remove work in time O(1)
* Like .NET’s HashSet<T>
* OrderedSet<T>
* A set based on balanced search tree (red-black)
* Add / Find / Remove work in time O(log(N))
* Like .NET’s SortedSet<T>
* Provides fast .Range(from, to) operation


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Power Collections Classes (3)
* MultiDictionary<TKey, TValue>
* A dictionary (map) implemented by hash-table
* Allows duplicates (configurable)
* Add / Find / Remove work in time O(1)
* Like Dictionary<TKey, List<TValue>>
* OrderedDictionary<TKey, TValue> / OrderedMultiDictionary<TKey, TValue>
* A dictionary based on balanced search tree
* Add / Find / Remove work in time O(log(N))
* Provides fast .Range(from, to) operation


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Power Collections Classes (4)
* Deque<T>
* Double-ended queue (deque)
* BigList<T>
* Editable sequence of indexed items
* Like List<T> but provides
* Fast Insert / Delete operations (at any position)
* Fast Copy / Concat / Sub-range operations
* Implemented by the data structure "Rope"
* Special kind of balanced binary tree: http://en.wikipedia.org/wiki/Rope_(data_structure)


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
## Wintellect Power Collections
# [Demo]()

=======
* `Bag<T>`
  * A bag (multi-set) based on hash-table
    * Unordered collection (with duplicates)
  * Add / Find / Remove work in time O(1)
  * `T` should provide `Equals()` and `GetHashCode()`
* `OrderedBag<T>`
  * A bag (multi-set) based on balanced search tree
  * Add / Find / Remove work in time O(log(N))
  * `T` should implement `IComparable<T>`

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Power Collections Classes (2)
* `Set<T>`
  * A set based on hash-table (no duplicates)
  * Add / Find / Remove work in time O(1)
  * Like .NET’s `HashSet<T>`
* `OrderedSet<T>`
  * A set based on balanced search tree (red-black)
  * Add / Find / Remove work in time O(log(N))
  * Like .NET’s `SortedSet<T>`
  * Provides fast `.Range(from, to)` operation

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Power Collections Classes (3)
* `MultiDictionary<TKey, TValue>`
  * A dictionary (map) implemented by hash-table
  * Allows duplicates (configurable)
  * Add / Find / Remove work in time O(1)
  * Like `Dictionary<TKey, List<TValue>>`
* `OrderedDictionary<TKey, TValue>` / `OrderedMultiDictionary<TKey, TValue>`
  * A dictionary based on balanced search tree
  * Add / Find / Remove work in time O(log(N))
  * Provides fast `.Range(from, to)` operation

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Power Collections Classes (4)
* `Deque<T>`
  * Double-ended queue (deque)
* `BigList<T>`
    * Editable sequence of indexed items
    * Like `List<T>` but provides
      * Fast `Insert` / `Delete` operations (at any position)
      * Fast `Copy` / `Concat` / `Sub-range` operations
    * Implemented by the data structure "`Rope`"
      * Special kind of balanced binary tree: http://en.wikipedia.org/wiki/Rope_(data_structure)

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
##  [Demo]()
# Wintellect Power Collections
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Priority Queue
<<<<<<< HEAD
* What is a "priority queue"?
* Data structure to efficiently support finding the item with the highest priority
* Like a queue, but with priorities
*  The basic operations
* Enqueue(T element)
* Dequeue() &rarr; T
* There is no build-in priority queue in .NET
* See the data structure "binary heap"
* Can be implemented also by OrderedBag<T>


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Priority Queue Implementation
class PriorityQueue<T> where T : IComparable<T>
{
   private OrderedBag<T> queue;
   public int Count 
   {
      get { return this.queue.Count; }
   }
   public PriorityQueue()
   {
      this.queue = new OrderedBag<T>();   
   }
   public void Enqueue(T element)
   {
      this.queue.Add(element);
   }
   public T Dequeue()
   {
      return this.queue.RemoveFirst();
   }
}


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Priority Queue
## Live Demo

=======
* What is a "`priority` `queue`"?
  * Data structure to efficiently support finding the item with the highest priority
  * Like a queue, but with priorities
  *  The basic operations
    * `Enqueue(T element)`
    * `Dequeue() &rarr; T`
* There is no build-in `priority` `queue` in .NET
  * See the data structure "binary heap"
  * Can be implemented also by `OrderedBag<T>`

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Priority Queue Implementation
* class PriorityQueue<T> where T : IComparable<T>
* {
*    private OrderedBag<T> queue;
*    public int Count 
*    {
*       get { return this.queue.Count; }
*    }
*    public PriorityQueue()
*    {
*       this.queue = new OrderedBag<T>();   
*    }
*    public void Enqueue(T element)
*    {
*       this.queue.Add(element);
*    }
*    public T Dequeue()
*    {
*       return this.queue.RemoveFirst();
*    }
* }

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Priority Queue
##  [Demo]()
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Advanced Data Structures
<<<<<<< HEAD
## Suffix Trees, Interval Trees, Tries, Ropes, Heaps, …

=======
##  Suffix Trees, Interval Trees, Tries, Ropes, Heaps, …
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Advanced Data Structures
* Suffix tree (position tree)
<<<<<<< HEAD
* Represents the suffixes of given string
* Used to implement fast search in string
* Trie (prefix tree)
* Special tree structure used for fastmulti-pattern matching
* Rope
* Balanced tree structure for indexeditems with fast inserts / delete
* Allows fast string edit operations


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Advanced Data Structures (2)
* Interval tree
* Keeps intervals [a…b] in ordered balanced tree
* Allows to efficiently find all intervals that overlap with any given interval or point
* Binary heap, Fibonacci heap
* Special tree-like data structures toefficiently implement a priority queue
* Index trees
* Used to keep sorted indices of database records
* B-tree, B+ tree, T-tree


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
=======
  * Represents the suffixes of given string
  * Used to implement fast search in string
* Trie (prefix tree)
  * Special tree structure used for fastmulti-pattern matching
* Rope
  * Balanced tree structure for indexeditems with fast inserts / delete
  * Allows fast string edit operations

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Advanced Data Structures (2)
* Interval tree
  * Keeps intervals [a…b] in ordered balanced tree
  * Allows to efficiently find all intervals that overlap with any given interval or point
* Binary heap, Fibonacci heap
  * Special tree-like data structures toefficiently implement a priority queue
* Index trees
  * Used to keep sorted indices of database records
  * B-tree, B+ tree, T-tree

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3
# C5 Collections
##  Open Source Generic Collection Library for C#

<!-- attr: { showInPresentation:true, style:'' } -->
# C5 Collections
* What are "C5 Collections"?
<<<<<<< HEAD
* C5 Generic Collection Library for C# and CLI
* Open-Source Data Structures Library for .NET
* http://www.itu.dk/research/c5/
* Have solid documentation (book) – http://www.itu.dk/research/c5/latest/ITU-TR-2006-76.pdf
* The C5 library defines its own interfaces like IEnumerable<T>, IIndexed<T>, IIndexedSorted<T>, etc.


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# C5 Collection Classes

=======
  * C5 Generic Collection Library for C# and CLI
  * Open-Source Data Structures Library for .NET
  * http://www.itu.dk/research/c5/
  * Have solid documentation (book) – http://www.itu.dk/research/c5/latest/ITU-TR-2006-76.pdf
  * The C5 library defines its own interfaces like `IEnumerable<T>`, `IIndexed<T>`, `IIndexedSorted<T>`, etc.

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# C5 Collection Classes
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3

<!-- attr: { showInPresentation:true, style:'' } -->
# C5 Collection Classes
* Classical collection classes
<<<<<<< HEAD
* ArrayList<T>, LinkedList<T>, CircularQueue<T>, HashSet<T>, TreeSet<T>, HashBag<T>, TreeBag<T>
* HashedArrayList<T>
* Combination of indexed list + hash-table
* Fast Add / Find / indexer [] &rarr; O(1)
* IntervalHeap<T>
* Efficient double-ended priority queue


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Advanced Data Structures
* http://academy.telerik.com

=======
  * `ArrayList<T>`, `LinkedList<T>`, `CircularQueue<T>`, `HashSet<T>`, `TreeSet<T>`, `HashBag<T>`, `TreeBag<T>`
* `HashedArrayList<T>`
  * Combination of indexed list + hash-table
  * Fast `Add` / `Find` / `indexer []` &rarr; O(1)
* `IntervalHeap<T>`
  * Efficient double-ended priority queue

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Advanced Data Structures
* http://academy.telerik.com
>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3

<!-- attr: { showInPresentation:true, style:'' } -->
# Exercises
<<<<<<< HEAD
* Implement a class PriorityQueue<T> based on the data structure "binary heap".
* Write a program to read a large collection of products (name + price) and efficiently find the first 20 products in the price range [a…b]. Test for 500 000 products and 10 000 price searches.
* Hint: you may use OrderedBag<T> and sub-ranges.
* Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file). Print how many times each word occurs in the text.
* Hint: you may find a C# trie in Internet.
=======
* Implement a class `PriorityQueue<T>` based on the data structure "binary heap".
* Write a program to read a large collection of products (name + price) and efficiently find the first 20 products in the price range [a…b]. Test for 500 000 products and 10 000 price searches.
* Hint: you may use `OrderedBag<T>` and sub-ranges.
* Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file). Print how many times each word occurs in the text.
* Hint: you may find a C# trie in Internet.

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Free Trainings @ Telerik Academy
* C# Programming @ Telerik Academy
    * csharpfundamentals.telerik.com
  * Telerik Software Academy
    * academy.telerik.com
  * Telerik Academy @ Facebook
    * facebook.com/TelerikAcademy
  * Telerik Software Academy Forums
    * forums.academy.telerik.com

>>>>>>> 65398845faa5f226f36e77af31892a91f826cbf3
