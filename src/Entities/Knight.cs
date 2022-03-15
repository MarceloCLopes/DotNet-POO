namespace DotNet___POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
    }
}