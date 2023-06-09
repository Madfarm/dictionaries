namespace Dictionaries;

class NewThingy
{
    public static void goDictionaryGo()
    {
        Dictionary<int, string> myDic = new Dictionary<int, string>();

        myDic.Add(2, "raytrace");
        myDic.Add(1, "boomshaka");

        myDic[3] = "Wow";

        System.Console.WriteLine(myDic[3]);
    }
}