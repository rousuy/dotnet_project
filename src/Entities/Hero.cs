namespace projeto_dotnet.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name { get; set; } 
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(){
        
        }


        public override string ToString(){
            return $"{this.Name} {this.Level} {this.HeroType}";
        }

        public virtual string Attack(){
            return $"{this.Name} attacked.";
        }

    }
}