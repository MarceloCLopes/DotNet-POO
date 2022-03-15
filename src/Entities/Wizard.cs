namespace DotNet___POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string Attack(){
           return $"{Name} lançou magia";
        }

        public string Attack(int Bonus){

            if(Bonus > 6){
                return $"{Name} lançou magia super efetiva com bonus de {Bonus}";
            } else{
                return $"{Name} lançou uma magia com força fraca com bonus de {Bonus}"; 
            }

        }
    }
}