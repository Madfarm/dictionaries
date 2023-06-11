namespace Dictionaries;

class NewThingy
{
    public static void goDictionaryGo()
    {
        Dictionary<int, string> myDic = new Dictionary<int, string>();

        myDic.Add(2, "raytrace");
        myDic.Add(1, "boomshaka");

        myDic[3] = "Wow";
        myDic[12] = "soupy";
        myDic[8] = "lemon pepper";

        myDic.Remove(3);
        // System.Console.WriteLine(myDic[3]);

        try
        {
            System.Console.WriteLine(myDic[3]);
        }
        catch (KeyNotFoundException)
        {
            System.Console.WriteLine("Key not found\n");
        }


        foreach (KeyValuePair<int, string> kvp in myDic)
        {
            System.Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }


        string output = "\n" + (myDic.ContainsKey(12) ? "We've got a match!" : "Sugma") + "\n";


        System.Console.WriteLine(output);

        output = "\n" + (myDic.Count > 3 ? "Damn my dict is big" : "Well at least she likes it") + "\n";

        System.Console.WriteLine($"There are {myDic.Count} keys in my dict. {output}");

        Dictionary<int, string>.KeyCollection keyColl = myDic.Keys;

        foreach (int i in keyColl)
        {
            System.Console.WriteLine(i);
        }

       
    }
}