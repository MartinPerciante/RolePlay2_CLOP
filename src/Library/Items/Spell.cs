namespace RoleplayGame
{
    public class Spell : ISpell
    {

        public Spell(string name, int attack, int defense)
        {
            this.Name = name;
            this.AttackValue = attack;
            this.DefenseValue = defense;
        }

        public string Name { get; set; }

       
        public int AttackValue { get; }

        public int DefenseValue { get; }
    }
}