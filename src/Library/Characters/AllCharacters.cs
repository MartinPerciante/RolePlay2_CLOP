using System.Collections.Generic;
namespace RoleplayGame
{
    public class AllCharacters
    {
        private List <ICharacter> characters;

        public void AddCharacter(ICharacter character)
        {
            this.characters.Add(character);
        }

        public void RemoveCharacter(ICharacter character)
        {
            this.characters.Remove(character);
        }

        public int CountCharacter()
        {
            return this.characters.Count;
        }
    }
}