namespace dotnet_poo.Models
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Life, int MP, int Level, string HeroType)
        {
            this.Name = Name;
            this.Life = Life;
            this.MP = MP;
            this.Level = Level;
            this.HeroType = HeroType;   
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bônus de " + Bonus;
            }
        }
    }
}