﻿using System;

namespace Enemies
{
    ///<summary>
    /// Empty public enemy class for a zombie
    ///</summary>
    public class Zombie
    {
        ///<summary>
        /// public field health with get and set
        ///</summary>
        public int health { get; set; }
        ///<summary>
        /// public class constructor zombie that sets health to 0
        ///</summary>
        public Zombie()
        {
            health = 0;
        }
    }
}
