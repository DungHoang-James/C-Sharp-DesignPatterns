
using Builder.Builders;

internal class Program
{
    private static void Main(string[] args)
    {
        var laptop = new LaptopBuilder()
                        .AddNumberOfCpu(1)
                        .AddNumberOfDisk(2)
                        .AddNumberOfGpu(1)
                        .AddNumberOfRam(4)
                        .AddTypeScreen("IPS")
                        .AddWebcam("FullHD")
                        .Build();


    }
}