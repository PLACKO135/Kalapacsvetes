using Pars2012;

internal class Program
{
   

    private static void Main(string[] args)
    {
        List<Versenyző> list = new List<Versenyző>();

        foreach(var sor in File.ReadAllLines("Source\\Selejtezo2012.txt"))
        {
            list.Add(new Versenyző(sor));
        }
        //5.
        Console.WriteLine($"5.feladat: Versenyzők száma a selejtezőben: {list.Count} fő");

        //6.
        Console.WriteLine($"6.feladat: 78,00 méter feletti eredménnyel továbbjutott:{list.Count(x=>x.D1>78||x.D2>78)}  fő");

        //9.
        var legjobb=list.MaxBy(x => x.Eredmeny());
        Console.WriteLine(legjobb.Nev);
        Console.WriteLine(legjobb.Csoport);
        Console.WriteLine(legjobb.Nemzet);
        Console.WriteLine(legjobb.Kod);
        Console.WriteLine(legjobb.Eredmeny());

        


    }
}