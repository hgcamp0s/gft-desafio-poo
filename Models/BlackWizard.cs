namespace dotnet_poo.Models
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Life, int MP, int Level, string HeroType)
        {
            this.Name = Name;
            this.Life = Life;
            this.MP = MP;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia de fogo";
        }
    }
}