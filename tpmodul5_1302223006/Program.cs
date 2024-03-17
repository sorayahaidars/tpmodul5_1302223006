using System;
public class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        string nim = Console.ReadLine();
        DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);

        dataGeneric.PrintData();

    }
}