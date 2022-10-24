namespace Proxy;

public class LazyRemoteProxy : IRemote
{
    private IRemote _remote;

    public void SetupRGB()
    {
        if (_remote == null)
        {
            _remote = new Remote();
        }
        _remote.SetupRGB();
    }
}
