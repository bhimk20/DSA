using Tries;

Trie root = new();

root.Insert("bhim");
Console.WriteLine(root.Search("bhim"));
Console.WriteLine(root.RecursiveSearch("..m"));
Console.WriteLine(root.StartsWith("bhi"));