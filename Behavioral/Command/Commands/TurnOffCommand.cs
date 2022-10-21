using Command.Entities;

namespace Command.Commands
{
    public class TurnOffCommand : ICommand
    {
        private LightBulb lightBulb;

        public TurnOffCommand(LightBulb light)
        {
            lightBulb = light;
        }

        public void Execute()
        {
            lightBulb.TurnOff();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}