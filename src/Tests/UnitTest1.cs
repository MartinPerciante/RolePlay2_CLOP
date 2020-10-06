using System;
using Xunit;
using RoleplayGame;

namespace Tests
{
    public class UnitTest1
    {
        Knight Paolo = new Knight("Paolo");
        Wizard Ragnar = new Wizard("Ragnar");
        [Fact]
        public void AtaqueEntrePersonajes() // Se prueba que los personajes reciban el daño establecido
        {
            Paolo.Sword = new Sword();
            Ragnar.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            book.Spells = new ISpell[]{ new Spell("Bola de fuego", 70, 10) };
            Ragnar.SpellsBook = book;
            int health = Ragnar.Health;
            health -= Paolo.AttackValue - Ragnar.DefenseValue;
            if (health > 100)
            {
                health = 100;
            }
            Ragnar.ReceiveAttack(Paolo.AttackValue);
            Assert.Equal(Ragnar.Health,health);
        }
        [Fact]
        public void Cure() // Se prueba que los personajes puedan curarse si su vida es mayor a 0
        {
            Ragnar.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            book.Spells = new ISpell[]{ new Spell("Congelar", 20, 20) };
            Ragnar.SpellsBook = book;
            Paolo.Shield = new Shield();
            Paolo.Armor = new Armor();
            Paolo.ReceiveAttack(Ragnar.AttackValue);
            int health;
            if (Paolo.Health == 0)
            {
                health = 0;
            }
            else
            {
                health = 100;
            }
            Paolo.Cure();
            Assert.Equal(Paolo.Health,health);
        }
        [Fact]
        public void AddCharacter() // Agregar el remove tambien
        {
            //AllCharacters.AddCharacter(Paolo);
        }
    }
}
