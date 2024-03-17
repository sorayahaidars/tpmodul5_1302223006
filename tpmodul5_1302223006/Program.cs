using System;
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
        HaloGeneric halo = new HaloGeneric();
        string namaPanggilan = Console.ReadLine();
        halo.SapaUser(namaPanggilan);
    }
}
