using System;

namespace Enemies
{
    ///<summary> Empty public enemy class for a zombie </summary>
    public class Zombie
    {
        /// private health field for class zombie
        private int _health;

        ///<summary> public class constructor zombie that sets health to 0 </summary>
        public Zombie()
        {
            _health = 0;
        }

        ///<summary> new public class constructor that ensures health is at least 0</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException(String.Format("Health must be greater than or equal to 0"));
            else
                _health = value;
        }

        ///<summary> Public getter for health </summary>
        public int GetHealth()
        {
            return _health;
        }
    }
}
