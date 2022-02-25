class Program
{
    static string capToFront(string input)
    {
        var upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        char[] characters = input.ToCharArray();

        var result = string.Empty;

        foreach (var character in characters)
        {
            if (upperCaseLetters.Contains(character))
            {
                result += character;
            }
        }

        foreach (var character in characters)
        {
            if (!upperCaseLetters.Contains(character))
            {
                result += character;
            }
        }

        // todo: implement
        return result;
    }

    static bool getXO(string input)
    {
        // todo: implement
        return false;
    }

    static bool checkTitle(string input)
    {
        // todo: implement
        return false;
    }

    static int[] rotateRight(int[] input)
    {

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1)
                input[i + 1] = input[i];
            else
                input[0] = input[i];
        }

        // todo: implement
        return input;
    }

    static bool isPalindrome(string input)
    {
        char[] characters = input.ToCharArray();

        Array.Reverse(characters);

        var reverStr = "";

        for (int i = 0; i < characters.Length; i++)
        {
            reverStr += characters[i];
        }
        
        // todo: implement
        return input == reverStr;
    }

    static string fullAlphaRetainWords(string input)
    {
        // todo: implement
        return "";
    }

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

        // GetCustomersWithBirthDateBeforeDate(DateTime beforeDate)
    }

    // Transform into Async version
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
        Console.WriteLine(test.GetCustomerByCustomerKey(133).ToString() == "133 - Melissa E Richardson (F)" ? "PASSED" : "FAILED");
        Console.WriteLine(test.GetCustomerByCustomerKey(150).ToString() == "150 - Theodore Gill (M)" ? "PASSED" : "FAILED");
        Console.WriteLine(test.GetCustomerByCustomerKey(953).ToString() == "953 - Ms. Dorothy B. Robinson (M)" ? "PASSED" : "FAILED");

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
    }
}