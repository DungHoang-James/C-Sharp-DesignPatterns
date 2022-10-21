using Command.Entities;

namespace Command.Commands
{
    public class TurnOnCommand : ICommand
    {
        private LightBulb lightBulb;

        public TurnOnCommand(LightBulb light)
        {
            lightBulb = light;
        }

        public void Execute()
        {
            lightBulb.TurnOn();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}