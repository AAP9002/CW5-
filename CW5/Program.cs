class Program
{
    //static List<string> P = new List<string>();
    static int count = 0;

    static int variations = 0;
    //static void Main(string[] args)
    //{
    //    string s = "abcde";
    //    function(s, 0, s.Length);

    //    foreach (string item in P)
    //    {
    //        Console.Write("{"+ item + "},");
    //    }
    //    Console.WriteLine(count);
    //}

    //static void function(string R, int Start, int End)
    //{
    //    count++;
    //    bool contains = false;
    //    foreach (string item in P)
    //    {
    //        if (item == R)
    //        {
    //            contains = true;
    //        }
    //    }

    //    if (!contains)
    //    {
    //        P.Add(R);
    //    }

    //    if (Start < End)
    //    {
    //        string T = "";
    //        for (int i = 0; i < R.Length; i++)
    //        {
    //            if (i != Start)
    //            {
    //                T=T+R[i];
    //            }
    //        }
    //        int L = T.Length;
    //        function(T, 0, L);
    //        function(R, Start + 1, End);
    //    }
    //}

    static void Main(string[] args)
    {
        function("", "1", 4);
        function("", "0", 4);
        Console.WriteLine("calls: "+count);
        Console.WriteLine("output:" +variations);
    }

    static void function(string str, string nextdigit, int max)
    {
        count++;
        string newstr = string.Concat(str, nextdigit);
        str = newstr;
        if (str.Length == max)
        {
            Console.Write("{" + str + "},");
            variations++;
        }
        else
        { 
            function(str, "1", max);
            function(str, "0", max);
        }
    }

}