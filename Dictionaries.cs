namespace Dictionaries;

class NewThingy
{
    public static void goDictionaryGo()
    {
        System.Console.WriteLine("Woot doots");
        Dictionary<int, string> myDic = new Dictionary<int, string>();

        myDic.Add(2, "raytrace");
        myDic.Add(1, "boomshaka");
    }
}