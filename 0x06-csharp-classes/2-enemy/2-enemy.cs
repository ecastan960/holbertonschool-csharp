﻿using System;

namespace Enemies
{
    /// <summary> public class Zombie that defines a zombie.</summary>
    class Zombie
    {
        public int health;

        public Zombie()
        {
            this.health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
    }
}
