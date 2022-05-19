namespace Day2
{
  public interface IAdmit {
    public string Admission();
    public bool Guilty(int guilt_points);
  }
  
  public class Person : IAdmit {
    public string name;
    
    public Person() {}
    
    public string Admission() { 
      return "sorry";
    }
    
    public bool Guilty(int guilt_points){
        return false;
    }
  }
}
