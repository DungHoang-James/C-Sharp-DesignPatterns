using Builder.Entities;

namespace Builder.Builders
{
    public class LaptopBuilder : ILaptopBuilder
    {
        public int NumberOfRam { get; private set; }
        public string TypeScreen { get; private set; }
        public string Webcam { get; private set; }
        public int NumberOfDisk { get; private set; }
        public int NumberOfCpu { get; private set; }
        public int NumberOfGpu { get; private set; }

        public LaptopBuilder AddNumberOfCpu(int numberOfCpu)
        {
            NumberOfCpu = numberOfCpu;
            return this;
        }

        public LaptopBuilder AddNumberOfDisk(int numberOfDisk)
        {
            NumberOfDisk = numberOfDisk;
            return this;
        }

        public LaptopBuilder AddNumberOfGpu(int numberOfGpu)
        {
            NumberOfGpu = numberOfGpu;
            return this;
        }

        public LaptopBuilder AddNumberOfRam(int numberOfRam)
        {
            NumberOfRam = numberOfRam;
            return this;
        }

        public LaptopBuilder AddTypeScreen(string typeScreen)
        {
            TypeScreen = typeScreen;
            return this;
        }

        public LaptopBuilder AddWebcam(string webcam)
        {
            Webcam = webcam;
            return this;
        }

        public Laptop Build()
        {
            return new Laptop(NumberOfRam, TypeScreen, Webcam, NumberOfDisk, NumberOfCpu, NumberOfGpu);
        }
    }
}