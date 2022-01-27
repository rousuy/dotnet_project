namespace projeto_dotnet.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return $"{this.Name} cast magic";
        }

        public string Attack(int Bonus){
            if (Bonus > 6){
                return $"{this.Name} cast super effective black magic with attack bonus of {Bonus} points.";
            }
            else{
                return $"{this.Name} cast normal black magic with attack bonus of {Bonus} points.";
            }
            
        }
    
    }
}
