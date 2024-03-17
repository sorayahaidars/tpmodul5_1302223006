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


public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        string nim = Console.ReadLine();
        DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);

        dataGeneric.PrintData();

        HaloGeneric halo = new HaloGeneric();
        string namaPanggilan = Console.ReadLine();
        halo.SapaUser(namaPanggilan);
    }
}
