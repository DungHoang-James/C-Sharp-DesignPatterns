using Builder.Entities;

namespace Builder.Builders
{
    public interface ILaptopBuilder
    {
        LaptopBuilder AddNumberOfRam(int numberOfRam);
        LaptopBuilder AddTypeScreen(string typeScreen);
        LaptopBuilder AddWebcam(string webcam);
        LaptopBuilder AddNumberOfDisk(int numberOfDisk);
        LaptopBuilder AddNumberOfCpu(int numberOfCpu);
        LaptopBuilder AddNumberOfGpu(int numberOfGpu);
        Laptop Build();
    }
}