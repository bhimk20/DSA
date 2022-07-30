
using Practice;

string[] input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

IList<IList<string>> output = GroupAnagrams(input);

IList<IList<string>> GroupAnagrams(string[] strs)
{
    IList<IList<string>> output = new List<IList<string>>();
    if (strs.Length == 0)
    {
        return output;
    }

    Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
    string sortedString = SortString(strs[0]);

    anagrams.Add(sortedString, new List<string>(new string[] { strs[0] }));
    output.Add(anagrams[sortedString]);
    for(int i = 1; i < strs.Length; i++)
    {
        bool isKey = true;

        sortedString = SortString(strs[i]);
        foreach (string key in anagrams.Keys.ToList())
        {
            if (key.Equals(sortedString))
            {
                anagrams[key].Add(strs[i]);
                isKey = false;
                break;
            }
        }
        if (isKey)
        {
            anagrams.Add(sortedString, new List<string>{ strs[i] });
            output.Add(anagrams[sortedString]);
        }
    }

    return output;
}

String SortString(string input)
{
    char[] chars = input.ToCharArray();

    Array.Sort(chars);
    return new String(chars);
}

var charList = new char[26];
foreach (char c in "tea")
{
    charList[c - 'a']++;
    Console.WriteLine(charList[c - 'a']);
}

var key = new string(charList);
Console.WriteLine("tea".Equals("tea"));

TreeNode Root = new(10);
Queue<TreeNode> qu = new();

qu.Enqueue(Root);
while(qu.Count > 0)
{
    TreeNode node = qu.Dequeue();
    if(node.Left != null)
        qu.Enqueue(node.Left);
    if(node.Right != null)
        qu.Enqueue(node.Right);

    TreeNode? right = node.Right;
    node.Right = node.Left;
    node.Left = right;
}


bool isSameTree(TreeNode p, TreeNode q)
{

    if (p is null && q is null)
    {
            return true;
    }

    if (p is not null || q is not null)
    {
        return false;
    }

    if (p.Value != q.Value)
    { 
        return false;
    }

    return (isSameTree(p.Left, q.Left) && isSameTree(p.Right, q.Right));
}

int height;

bool IsBalanced(TreeNode root)
{
    if (root is null)
        return true;

    int left = 0;
    int right = 0;

    height = 0;
    if(IsBalanced(root.Left) is true)
    {
        return false;
    }
    left = height;

    height = 0;
    if (IsBalanced(root.Right) is false)
    {
        return false;
    }
    right = height;

    if (Math.Abs(left - right) > 1)
        return false;

    height = Math.Max(left, right) + 1;

    return true;
}
