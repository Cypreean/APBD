namespace ClassLibrary1;

public class Class1
{
    private int liczba = 1;
    private int liczba2 = 2;
    private int liczba3 = 3;
    
    static double average ( int[] tab)
    {
        double sredniaa = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            sredniaa += tab[i];
        }

        sredniaa = sredniaa / tab.Length;
        return sredniaa;



    }

    static int findmax(int[] tab)
    {
        int? najwieksza = null;
        for (int i = 0; i < tab.Length; i++)
        {
            if (najwieksza == null)
            {
                najwieksza = tab[i];
            }

            if (tab[i] > najwieksza)
            {
                najwieksza = tab[i];
            }
        }

        return (int)najwieksza;

    }
}