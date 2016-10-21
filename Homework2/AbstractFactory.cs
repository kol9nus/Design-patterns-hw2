namespace Homework2
{
    public interface ICarFactory
    {
        ICarcass CreateCarcass();
        ICabin CreateCabin();
        IEngine CreateEngine();
    }

    public interface ICarcass
    {
        string Name { get; }
    }

    public interface IEngine
    {
        string Name { get; }
    }

    public interface ICabin
    {
        string Name { get; }
    }

    public class BMWFactory : ICarFactory
    {
        public ICarcass CreateCarcass()
        {
            return new PlasticCarcass();
        }

        public ICabin CreateCabin()
        {
            return new LeatherCabin();
        }

        public IEngine CreateEngine()
        {
            return new PowerfulEngline();
        }
    }

    public class PlasticCarcass : ICarcass
    {
        public string Name => "Пластиковый кузов";
    }

    public class LeatherCabin : ICabin
    {
        public string Name => "Моднючий кожанный салон";
    }

    public class PowerfulEngline : IEngine
    {
        public string Name => "Зверский движок";
    }

    public class AudiFactory : ICarFactory
    {
        public ICarcass CreateCarcass()
        {
            return new PlasticCarcass();
        }

        public ICabin CreateCabin()
        {
            return new NormalCabin();
        }

        public IEngine CreateEngine()
        {
            return new NormalEngine();
        }
    }

    public class NormalEngine : IEngine
    {
        public string Name => "Обычный двигатель";
    }

    public class NormalCabin : ICabin
    {
        public string Name => "Обычный салон";
    }
}
