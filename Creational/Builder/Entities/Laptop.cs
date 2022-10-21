namespace Builder.Entities
{
    public class Laptop
    {
        public int NumberOfRam { get; private set; }
        public string TypeScreen { get; private set; }
        public string Webcam { get; private set; }
        public int NumberOfDisk { get; private set; }
        public int NumberOfCpu { get; private set; }
        public int NumberOfGpu { get; private set; }

        public Laptop(int numberOfRam,
                    string typeScreen,
                    string webcam,
                    int numberOfDisk,
                    int numberOfCpu,
                    int numberOfGpu)
        {
            NumberOfRam = numberOfRam;
            TypeScreen = typeScreen;
            Webcam = webcam;
            NumberOfDisk = numberOfDisk;
            NumberOfCpu = numberOfCpu;
            NumberOfGpu = numberOfGpu;
        }
    }
}