namespace Prototype
{
    public abstract class AbstractPrototype
    {
        public abstract AbstractPrototype ShallowCopy();
        public abstract AbstractPrototype DeepCopy();
    }
}