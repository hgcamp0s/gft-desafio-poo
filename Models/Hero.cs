namespace dotnet_poo.Models
{
    public abstract class Hero
    {
        public Hero(string Name, int Life, int MP, int Level, string HeroType)
        {
            this.Name = Name;
            this.Life = Life;
            this.MP = MP;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero()
        {

        }

        public string Name { get; set; }
        public int Life { get; set; }
        public int MP { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return "Character:" + this.Name + " Level:" + this.Level + " Life:" + this.Life + " MP:" + this.MP + " Class:" + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou";
        }
    }
}