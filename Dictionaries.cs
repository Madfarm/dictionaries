namespace Dictionaries;

class NewThingy
{
    public static void goDictionaryGo()
    {
        Dictionary<int, string> myDic = new Dictionary<int, string>();

        myDic.Add(2, "raytrace");
        myDic.Add(1, "boomshaka");

        myDic[3] = "Wow";

        // System.Console.WriteLine(myDic[3]);

        try
        {
            System.Console.WriteLine(myDic[6]);
        }
        catch (KeyNotFoundException)
        {
            System.Console.WriteLine("Key not found");
        }


        foreach (KeyValuePair<int, string> kvp in myDic)
        {
            System.Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }
    }
}