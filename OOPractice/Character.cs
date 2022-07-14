using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    internal class Character
    {
        public int LifePoints { get; set; }
        public int MaxLifePoints { get; set; }
        public string CharacterName { get; set; }
        public string ClassName { get; set; }

        public Character (int lifePoints, int maxLifePoints, string characterName, string className)
        {
            LifePoints = lifePoints;
            MaxLifePoints = maxLifePoints;
            CharacterName = characterName;
            ClassName = className;
        }

        public string Attack(string characterName, string className)
        {
            return($"{ClassName} {CharacterName}: Hace un ataque!");
        }

        public string Parry(string characterName, string className)
        {
            return($"{ClassName} {CharacterName}: Ha parado un ataque!");
        }

    }
}
