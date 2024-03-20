using Lab4.Interfaces;

namespace Lab4.Implementation.Factories
{
    public class RoomFactorySingleton
    {
        private static RoomFactorySingleton _instance;
        private readonly Dictionary<string, IRoomFactory> _factories;

        private RoomFactorySingleton()
        {
            _factories = new Dictionary<string, IRoomFactory>
                        {
                            { "Standart", new StandardRoomFactory() },
                            { "Suite", new SuiteRoomFactory() }
                        };
        }

        public static RoomFactorySingleton Instance => _instance ??= new RoomFactorySingleton();

        public IRoomFactory GetFactory(string type)
        {
            if (_factories.ContainsKey(type))
            {
                return _factories[type];
            }
            throw new ArgumentException("Invalid room type.");
        }
    }

}
