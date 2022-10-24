
using Composites;

internal class Program
{
    private static void Main(string[] args)
    {
        Composite root = new("Root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));

        Composite comp1 = new("Composite C1");
        comp1.Add(new Leaf("Leaf C1-A"));
        comp1.Add(new Leaf("Leaf C1-B"));

        Composite comp2 = new("Composite C2");
        comp2.Add(new Leaf("Lead C2-A"));

        comp1.Add(comp2);

        root.Add(comp1);
        root.Add(new Leaf("Lead D"));

        root.PrimaryOperation(1);
    }
}