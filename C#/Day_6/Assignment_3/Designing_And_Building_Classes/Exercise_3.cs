namespace Day2
{
  public class Class
    {
        public Class(){}
        private int _variable;

        public int Variable
        {
            get{return _variable}
            set
            {
                if (value > 0)
                {
                    _variable = value;
                }
                else
                {
                    _variable = 1;
                }
            }
        }
    }
}
