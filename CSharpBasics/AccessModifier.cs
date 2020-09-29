namespace AccessModifierAndMethods
{
class AccessModifier
{
    internal int x;
    public int y;

    internal void DoSomething()
    {

    }

    int CalculateAverage(int[] numbers)
    {
        DoSomething();
        //Calculate average
        return 0;
    }
}
}