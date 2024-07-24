namespace BTelliUnitTest.APP;

public class Calculator
{
    public int Add(int x,int y)
    {
        if (x == 0 || y == 0)
            return 0;
        return x + y;
    }
}
