﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    internal class Hero : Character
    {

        public Hero(int lifePoints, int maxLifePoints, string characterName, string className) : base(lifePoints, maxLifePoints, characterName, className)
        {
            LifePoints = lifePoints;
            MaxLifePoints = maxLifePoints;
            CharacterName = characterName;
            ClassName = className;
        }

        public string CastBuff(string characterName, string className)
        {
            return($"{ClassName} {CharacterName}: Ha lanzado un buff!");
        }

    }
}
