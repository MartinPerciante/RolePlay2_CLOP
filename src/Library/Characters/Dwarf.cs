namespace RoleplayGame
{
    public class Dwarf : ICharacter
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public IAttackItem Axe { get; set; }

        public IDefenseItem Shield { get; set; }

        public IDefenseItem Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                return Axe.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Shield.DefenseValue + Helmet.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            if (this.Health != 0)
            {
                this.Health = 100;
            }
        }
    }
}