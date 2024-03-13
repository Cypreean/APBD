namespace ClassLibrary1;

public class Class1
{
    private int liczba = 1;
    private int liczba2 = 2;
    private int liczba3 = 3;
    
    static double average ( int[] tab)
    {
        double srednia = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            srednia += tab[i];
        }

        srednia = srednia / tab.Length;
        return srednia;



    }
}