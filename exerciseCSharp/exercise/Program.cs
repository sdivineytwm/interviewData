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

string capToFront(string input)
{
    // todo: implement
    return "";
}

bool getXO(string input)
{
    // todo: implement
    return false;
}

bool checkTitle(string input)
{
    // todo: implement
    return false;
}

int[] rotateRight(int[] input)
{
    // todo: implement
    return new int[1];
}

bool isPalindrome(string input)
{
    // todo: implement
    return false;
}

string fullAlphaRetainWords(string input)
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