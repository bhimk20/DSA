using Tries;

Node root = new();

void Insert(string input)
{
    Node node = root;
    for (int i = 0; i < input.Length; i++)
    {
        char ch = input[i];
        if (!node.ContainsChar(ch))
        {
            node.Insert(ch, new());
        }
        node = node.Get(ch);
    }

    node.SetEnd(); 
}

bool Search(string input)
{
    Node node = root;
    for (int i = 0; i < input.Length; i++)
    {
        char ch = input[i];
        if (!node.ContainsChar(ch))
        {
            return false;
        }
        node = node.Get(ch);
    }

    return node.IsEnd();
}

bool StartsWith(string input)
{
    Node node = root;
    for (int i = 0; i < input.Length; i++)
    {
        char ch = input[i];
        if (!node.ContainsChar(ch))
        {
            return false;
        }
        node = node.Get(ch);
    }

    return true;
}


Insert("bhim");
Console.WriteLine(Search("bhim"));
Console.WriteLine(StartsWith("i"));