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

        /// private name field for class zombie
        private string _name = "(No name)";

        ///<summary> Public getter and setter for zombie name </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        ///<summary> Public getter for health </summary>
        public int GetHealth()
        {
            return _health;
        }

        ///<summary> Our own tostring method for the zombie class</summary>
        public override string ToString()
        {
            return $"Zombie Name: {_name} / Total Health: {_health}";
        }
    }
}
