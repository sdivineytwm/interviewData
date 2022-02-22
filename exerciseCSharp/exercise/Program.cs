using System.Data;
using System.Data.SqlClient;

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
Console.WriteLine(test.GetCreatureTemplateByEntry(192).ToString() == "192 - Ice Troll (5000, 62)" ? "PASSED" : "FAILED");
Console.WriteLine(test.GetCreatureTemplateByEntry(510).ToString() == "510 - Water Elemental (2998, 70)" ? "PASSED" : "FAILED");
Console.WriteLine(test.GetCreatureTemplateByEntry(3443).ToString() == "3443 - Grub (270, 13)" ? "PASSED" : "FAILED");

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

    //var caps = new string[input.Length];
    //var inputs = input.Split("");
    //for (int i = 0; i < input.Length-1; i++) {
    //    if (Char.IsUpper((char)inputs[i].ToCharArray()[0])) {
    //        caps[i] = inputs[i];
    //        inputs[i] = "";
    //    }
    //}
    //// todo: implement
    //return $"{String.Join("", caps)}{String.Join("", inputs)}";
    return "";
}

bool getXO(string input)
{
    int x = 0, o = 0;

    var inputs = input.ToLowerInvariant().Split("");
    if (!inputs.Contains("x") || !inputs.Contains("o")) {
        return true;
    }
    for (int i = 0; i < inputs.Length - 1; i++) {
        if (inputs[i] == "x")
        {
            x++;
        }
        else if (inputs[i] == "o") {
            o++;
        }
         }
    return x == o && (x != 0);
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

class CreatureTemplate
{

    public int Entry;

    public string Name;

    public long Health;
    public int Level;
    // todo: implement
    public override string ToString()
    {
        // todo: implement
        return $"{this.Entry} - {this.Name} ({this.Health}, {this.Level})";
    }
}

class DbManager
{
    SqlConnection connection;
    SqlCommand command;
    
    public DbManager()
    {
        connection = new SqlConnection();
        connection.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=game;Data Source=Vm-test";
    }

    public CreatureTemplate GetCreatureTemplateByEntry(int entry)
    {
        CreatureTemplate newCreatureTemplate = new CreatureTemplate();
        try
        {
            command = new SqlCommand($"Select * from creature_template where entry={entry}");
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newCreatureTemplate.Name =  reader["Name"].ToString();
                    newCreatureTemplate.Health = (long)reader["Health"];
                    newCreatureTemplate.Level = (int)reader["Level"];
                     newCreatureTemplate.Health = (int)reader["Entry"];
                }
            }
        }
        catch(Exception q){
            Console.WriteLine($"{q.Message}: {(q.InnerException is null ? "" : q.InnerException.Message)}");
        }
        finally
        {
            connection.Close();
        }
        return newCreatureTemplate;
    }
}