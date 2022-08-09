static void Sorted(string[] any)
{
    for (int i = 0; i < any.Length; i++)
    {
        string a = any[i];
        char[] sumstring = a.ToCharArray();
        if (sumstring.Length <= 3)
        {
            string newSymbols = new string (sumstring);
            Console.Write(newSymbols);
            Console.Write(", ");
        }
    }
    Console.Write("\b \b");
    Console.Write("\b \b");
}        

string[] symbols = {"hello", "2", "world", ":-)", "наконец-то", "пол", "учи", "лос", "ь!!", "?"};
Sorted(symbols);
