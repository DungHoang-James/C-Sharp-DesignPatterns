namespace Flyweight;

public interface IDrinkFlyweight
{
    // intrinsic state - shared/readonly
    string Name { get; }

    // extrinsic state
    void Serve(string size);
}
