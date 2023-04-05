namespace GenericsMyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> takımlar = new MyDictionary<int,string> ();

            takımlar.Add(1905, "Galatasaray");
            takımlar.Add(1907, "Fenerbahçe");
            takımlar.Add(1903, "Beşiktaş");
            takımlar.Add(1899, "FC Barcelona");


        }
    }
}