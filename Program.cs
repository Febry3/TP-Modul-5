﻿internal class Program

{   
    public class HaloGeneric
    {
        public static void  SapaUser<T>(T data)
        {
            Console.WriteLine("Halo User " + data);
        }
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<String>("Febry");
        DataGeneric<String> test = new DataGeneric<String>("1302220084");
        test.PrintInfo();
    }


   
}