namespace RoleplayGame
{
    public interface ISpell
    {
        //Spell(string name, int attack, int defense);

        string Name { get; set; }
        int AttackValue {get;}

        int DefenseValue {get;}
    }
}