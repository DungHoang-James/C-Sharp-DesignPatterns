namespace Facade;

public class ServiceFacade : IServiceFacade
{
    private readonly ServiceA _serviceA;
    private readonly ServiceB _serviceB;
    private readonly ServiceC _serviceC;

    public ServiceFacade()
    {
        _serviceA = new();
        _serviceB = new();
        _serviceC = new();
    }

    public void FutureA()
    {
        _serviceA.MethodInServiceA();
        _serviceB.MethodInServiceB();
        _serviceC.MethodInServiceC();
    }
}