class Program
{
    // Create a function (capToFront) that moves all capital letters to the front of a word.
    // Keep the original relative order of the upper and lowercase letters the same.
    static string capToFront(string input)
    {
        //"hApPy") == "APhpy"
        // todo: implement
        string uppercaseLetters = "";
        string lowercaseLetters = "";

        foreach(char c in input)
        {
            if (Char.IsLower(c))
            {
                lowercaseLetters += c.ToString();
            }
            else
            {
                uppercaseLetters += c.ToString();
            }


        }

        string returnString = uppercaseLetters + lowercaseLetters;

        return returnString;
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
        //[1,2,3]
        //[3,1,2]


        int tmp = input[input.Length - 1]; //3
        for(int i = 0; i < input.Length - 1; i++)
        {
            int internalTmp = input[i];
            input[i] = tmp;
            tmp = internalTmp;


        }
        input[input.Length - 1] = tmp;

        return input;
    }

    // Create a function (isPalindrome) which takes a string and returns true if it’s the same forwards or backwards.
    static bool isPalindrome(string input)
    {
        // todo: implement
        int mid = input.Length / 2;
        for(int i = 0; i< mid; i++)
        {
            if(input[i] != input[input.Length - i -1 ])
            {
                return false;
            }
        }


        return true;
    }

    // Create a function (fullAlphaRetainWords) which takes every letter in every word and puts it in alphabetical order, while retaining the original word lengths.
    static string fullAlphaRetainWords(string input)
    {
        // todo: implement
        //"hello world") == "dehll loorw" 

        //split into array into string[]

        //sort individual

        // rebuild

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
        static async Task Main(string[] args)
        {
             await logData("hello world");
        }
        public static async Task logData(string data)
        {
            string logfileName = Path.GetTempFileName();

            using (StreamWriter sw = new StreamWriter(logfileName))
            {
               await sw.WriteAsync(data);
                Console.WriteLine(data);
            }
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
        public string printAllNodes()
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

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }
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
    }
    /*
     * Implement the reverseLinkedList function.
     * This should mutate a LinkedList object in place such that the Nodes are output in the opposite order by printAllNodes().
     * Every LinkedList object has a “head” Node.
     * Each Node has a “data” property storing the value of the Node and a “next” property which is a pointer to the next Node in the LinkedList.
     * Example A → B → C → D → becomes D → C → B → A →
     */
    public static void reverseLinkedList(ref Node root)
    {
        // todo: implement
        Node previousNode = root; //A
        Node currentNode = root.next; //B
        while(currentNode != null)
        {
            Node tmp = currentNode.next; //C
            currentNode.next = previousNode; // B -> A
            previousNode = currentNode; // A set to B
            currentNode = tmp; // C

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
        reverseLinkedList(ref test1.head);
        Console.WriteLine(test1.printAllNodes() == "D -> C -> B -> A -> " ? "PASSED" : "FAILED");
    }
}