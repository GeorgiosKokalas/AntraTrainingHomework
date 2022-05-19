namespace Day2
{
    public abstract class Parent {
        public abstract int integer { get; set; }

        public virtual void method() { }
    }

    public class Child : Parent
    {
        public override int integer { get; set; }
        public override void method() {}
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
