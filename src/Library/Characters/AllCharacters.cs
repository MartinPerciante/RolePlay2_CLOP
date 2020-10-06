using System.Collections.Generic;
namespace RoleplayGame
{
    public class AllCharacters
    {
        public List<ICharacter> characters = new List<ICharacter>();

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