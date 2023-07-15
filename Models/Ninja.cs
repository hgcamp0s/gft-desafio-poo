namespace dotnet_poo.Models
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Life, int MP, int Level, string HeroType)
        {
            this.Name = Name;
            this.Life = Life;
            this.MP = MP;
            this.Level = Level;
            this.HeroType = HeroType;   
        }

        public override string Attack()
        {
            return this.Name + " Atacou com a sua adaga";
        } 
    }
}