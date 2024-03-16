internal class Program
{   
    public class HaloGeneric
    {
        public static void  SapaUser<T>(T data)
        {
            Console.WriteLine("Halo User " + data);
        }
    }

    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<String>("Febry");
    }
}