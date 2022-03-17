class Program
{
    // Create a function (capToFront) that moves all capital letters to the front of a word.
    // Keep the original relative order of the upper and lowercase letters the same.
    static string capToFront(string input)
    {
        // todo: implement
        return "";
    }

    // Create a function(getXO) that takes a string, checks if it has the same number of x’s and o’s and returns either true or false.
    // Return a boolean value. Return true if the amount of x’s and o’s are the same. Return false if they aren’t the same amount.
    // The string can contain any character.
    // When “x” and “o” are not in the string, return true.
    static bool getXO(string input)
    {
        // todo: implement
        return false;
    }

    // Create a function (checkTitle) for checking if a string title is a title string or not.
    // A title string is one which has all the words in the string start with an uppercase letter.
    static bool checkTitle(string input)
    {
        // todo: implement
        return false;
    }

    // Implement a function (rotateRight) which takes an array of integers and shifts each element one position to the right in a circular fashion.
    static int[] rotateRight(int[] input)
    {
        // todo: implement
        return new int[1];
    }

    // Create a function (isPalindrome) which takes a string and returns true if it’s the same forwards or backwards.
    static bool isPalindrome(string input)
    {
        // todo: implement
        return false;
    }

    // Create a function (fullAlphaRetainWords) which takes every letter in every word and puts it in alphabetical order, while retaining the original word lengths.
    static string fullAlphaRetainWords(string input)
    {
        // todo: implement
        return "";
    }

    // Implement the GetCustomerByCustomerKey data layer function.
    // It should fetch data from the dbo.DimCustomer table.
    // When ToString is called on the Customer object, data should be displayed in the following format:
    // “CustomerKey - Title FirstName MiddleName LastName”.
    // Note that Title and MiddleName may be null. If this is the case, there should still only be 1 space between each field in the ToString output.
    class Customer
    {
        // todo: implement
        public override string ToString()
        {
            // todo: implement
            return "";
        }
    }

    class DbManager
    {
        public Customer GetCustomerByCustomerKey(int customerKey)
        {
            // todo: implement
            return new Customer();
        }

        // Follow up - implement GetCustomersWithBirthDateBeforeDate.
        // Passed a single parameter with Date type and returns a collection of all customers whose BirthDate occurs earlier in time than the param.
        // GetCustomersWithBirthDateBeforeDate(DateTime beforeDate)
    }

    // Transform the Sync class into a version that is asynchronous
    class Sync
    {
        static void Main(string[] args)
        {
            logData("hello world");
        }
        public static void logData(string data)
        {
            string logfileName = Path.GetTempFileName();
            using (StreamWriter sw = new StreamWriter(logfileName))
            {
                sw.WriteLine(data);
                Console.WriteLine(data);
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("capToFront tests:");
        Console.WriteLine(capToFront("hApPy") == "APhpy" ? "PASSED" : "FAILED");
        Console.WriteLine(capToFront("moveMENT") == "MENTmove" ? "PASSED" : "FAILED");
        Console.WriteLine(capToFront("shOrtCAKE") == "OCAKEshrt" ? "PASSED" : "FAILED");

        Console.WriteLine("checkTitle tests:");
        Console.WriteLine(checkTitle("Total Wine And More") == true ? "PASSED" : "FAILED");
        Console.WriteLine(checkTitle("Water is transparent") == false ? "PASSED" : "FAILED");

        Console.WriteLine("getXO tests:");
        Console.WriteLine(getXO("ooxx") == true ? "PASSED" : "FAILED");
        Console.WriteLine(getXO("xooxx") == false ? "PASSED" : "FAILED");
        Console.WriteLine(getXO("ooxXm") == true ? "PASSED" : "FAILED"); // case insensitive
        Console.WriteLine(getXO("zpzpzpp") == true ? "PASSED" : "FAILED"); // returns true if no x and o
        Console.WriteLine(getXO("zzoo") == false ? "PASSED" : "FAILED");

        DbManager test = new DbManager();
        Console.WriteLine("DBManager tests:");
        Console.WriteLine(test.GetCustomerByCustomerKey(133).ToString() == "133 - Melissa E Richardson" ? "PASSED" : "FAILED");
        Console.WriteLine(test.GetCustomerByCustomerKey(150).ToString() == "150 - Theodore Gill" ? "PASSED" : "FAILED");
        Console.WriteLine(test.GetCustomerByCustomerKey(953).ToString() == "953 - Ms. Dorothy B. Robinson" ? "PASSED" : "FAILED");

        Console.WriteLine("rotateRight tests:");
        Console.WriteLine(Enumerable.SequenceEqual(rotateRight(new int[] { 1, 2, 3, 4, 5 }), new int[] { 5, 1, 2, 3, 4 }) ? "PASSED" : "FAILED");
        Console.WriteLine(Enumerable.SequenceEqual(rotateRight(new int[] { 6, 7, 8 }), new int[] { 8, 6, 7 }) ? "PASSED" : "FAILED");

        Console.WriteLine("isPalindrome tests:");
        Console.WriteLine(isPalindrome("racecar") == true ? "PASSED" : "FAILED");
        Console.WriteLine(isPalindrome("noon") == true ? "PASSED" : "FAILED");
        Console.WriteLine(isPalindrome("kayaks") == false ? "PASSED" : "FAILED");

        Console.WriteLine("fullAlphaRetainWords tests:");
        Console.WriteLine(fullAlphaRetainWords("hello world") == "dehll loorw" ? "PASSED" : "FAILED");
        Console.WriteLine(fullAlphaRetainWords("total wine and more") == "aadee ilmn noo rttw" ? "PASSED" : "FAILED");
        Console.WriteLine(fullAlphaRetainWords("have a nice day") == "aaac d eehi nvy" ? "PASSED" : "FAILED");
        
        Sync.logData("hello world");

        LinkedList test1 = new LinkedList();
        test1.AddLast("A");
        test1.AddLast("B");
        test1.AddLast("C");
        test1.AddLast("D");
        Console.WriteLine("reverseLinkedList tests:");
        test1.Reverse();
        Console.WriteLine(test1.PrintAllNodes() == "D -> C -> B -> A -> " ? "PASSED" : "FAILED");

        Console.WriteLine("invertBTree tests:");
        BTree btr = new BTree();
        btr.Add(6);
        btr.Add(2);
        btr.Add(3);
        btr.Add(11);
        btr.Add(30);
        btr.Add(9);
        btr.Add(13);
        btr.Add(18);
        BTreePrinter.Print(btr._root);
        btr.Invert(ref btr._root);
        BTreePrinter.Print(btr._root);
    }
}

public class Node
{
    public Node? next;
    public Object? data;
}
public class LinkedList
{
    public Node head;
    // This should loop through the LinkedList starting from the first element and output the value of each Node separated by the string, “ -> “
    public string PrintAllNodes()
    {
        string output = "";
        Node current = head;
        while (current != null)
        {
            output += current.data + " -> ";
            current = current.next;
        }
        return output;
    }
    // Inserts a new element as the first Node of the list.
    public void AddFirst(Object data)
    {
        Node toAdd = new Node();
        toAdd.data = data;
        toAdd.next = head;
        head = toAdd;
    }
    // Appends a new element as the last Node of the list.
    public void AddLast(Object data)
    {
        if (head == null)
        {
            head = new Node();
            head.data = data;
            head.next = null;
        }
        else
        {
            Node toAdd = new Node();
            toAdd.data = data;
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = toAdd;
        }
    }
    // Should mutate a LinkedList object in place such that the Nodes are output in the opposite order by PrintAllNodes().
    // Example A → B → C → D → becomes D → C → B → A →
    public void Reverse()
    {
        // todo: implement
    }
}
public class BTree
{
    public BNode _root;
    private int _count;
    private IComparer<int> _comparer = Comparer<int>.Default;
    public class BNode
    {
        public int Value;
        public BNode LeftChild;
        public BNode RightChild;
        public BNode(int value)
        {
            this.Value = value;
        }
    }

    public BNode Invert(ref BNode node)
    {
        // todo: implement
        return node;
    }

    public bool Add(int Item)
    {
        if (_root == null)
        {
            _root = new BNode(Item);
            _count++;
            return true;
        }
        else
        {
            return Add_Sub(_root, Item);
        }
    }

    private bool Add_Sub(BNode Node, int Item)
    {
        if (_comparer.Compare(Node.Value, Item) < 0)
        {
            if (Node.RightChild == null)
            {
                Node.RightChild = new BNode(Item);
                _count++;
                return true;
            }
            else
            {
                return Add_Sub(Node.RightChild, Item);
            }
        }
        else if (_comparer.Compare(Node.Value, Item) > 0)
        {
            if (Node.LeftChild == null)
            {
                Node.LeftChild = new BNode(Item);
                _count++;
                return true;
            }
            else
            {
                return Add_Sub(Node.LeftChild, Item);
            }
        }
        else
        {
            return false;
        }
    }
}

public static class BTreePrinter
{
    class NodeInfo
    {
        public BTree.BNode Node;
        public string Text;
        public int StartPos;
        public int Size { get { return Text.Length; } }
        public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
        public NodeInfo Parent, Left, Right;
    }

    public static void Print(this BTree.BNode root, int topMargin = 2, int leftMargin = 2)
    {
        if (root == null) return;
        int rootTop = Console.CursorTop + topMargin;
        var last = new List<NodeInfo>();
        var next = root;
        for (int level = 0; next != null; level++)
        {
            var item = new NodeInfo { Node = next, Text = next.Value.ToString(" 0 ") };
            if (level < last.Count)
            {
                item.StartPos = last[level].EndPos + 1;
                last[level] = item;
            }
            else
            {
                item.StartPos = leftMargin;
                last.Add(item);
            }
            if (level > 0)
            {
                item.Parent = last[level - 1];
                if (next == item.Parent.Node.LeftChild)
                {
                    item.Parent.Left = item;
                    item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos);
                }
                else
                {
                    item.Parent.Right = item;
                    item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos);
                }
            }
            next = next.LeftChild ?? next.RightChild;
            for (; next == null; item = item.Parent)
            {
                Print(item, rootTop + 2 * level);
                if (--level < 0) break;
                if (item == item.Parent.Left)
                {
                    item.Parent.StartPos = item.EndPos;
                    next = item.Parent.Node.RightChild;
                }
                else
                {
                    if (item.Parent.Left == null)
                        item.Parent.EndPos = item.StartPos;
                    else
                        item.Parent.StartPos += (item.StartPos - item.Parent.EndPos) / 2;
                }
            }
        }
        Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
    }

    private static void Print(NodeInfo item, int top)
    {
        SwapColors();
        Print(item.Text, top, item.StartPos);
        SwapColors();
        if (item.Left != null)
            PrintLink(top + 1, "┌", "┘", item.Left.StartPos + item.Left.Size / 2, item.StartPos);
        if (item.Right != null)
            PrintLink(top + 1, "└", "┐", item.EndPos - 1, item.Right.StartPos + item.Right.Size / 2);
    }

    private static void PrintLink(int top, string start, string end, int startPos, int endPos)
    {
        Print(start, top, startPos);
        Print("─", top, startPos + 1, endPos);
        Print(end, top, endPos);
    }

    private static void Print(string s, int top, int left, int right = -1)
    {
        Console.SetCursorPosition(left, top);
        if (right < 0) right = left + s.Length;
        while (Console.CursorLeft < right) Console.Write(s);
    }

    private static void SwapColors()
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = Console.BackgroundColor;
        Console.BackgroundColor = color;
    }
}