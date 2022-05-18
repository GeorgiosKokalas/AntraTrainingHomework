namespace Day2
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string name)
        {

        }
        public int Id { get; set; }

        // Long version of Properties
        //private int _id;
        //public int Id
        //{
        //    get { return _id; }
        //    set
        //    {
        //        if (value > 10) { _id = value; }
        //        else { Console.WriteLine("get out of here with a low id number"); }
        //    }
        //}

        // read-only
        public string Name { get; private set; }
        //write-Only
        public int Receipt { get; set; }

        public virtual int GetReceipt()
        {
            // FullTime.TotalFullTimeEmployee += 1;
            return Receipt;
        }

    }
    
    public class Student : Person
    {
        public Student(){}

        public Student(int ID = 0, string NAME = "N/A", int RECEIPT = 0, string SCHOOL = "N/A", int GRADE = 0)
        {
            Id = ID;
            Receipt = RECEIPT;
            School = SCHOOL;
            Grade = GRADE;
        }
        
        public string School { get; set; }
        public int Grade { get; set; }

        public override int GetReceipt()
        {
            Console.WriteLine("Overriding Method");
            return Receipt;
        }
    }
}
