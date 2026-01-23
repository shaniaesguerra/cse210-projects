public class Student
{
   private string _name;
   public string GetName()
   {
        return $"{_name}";
   }

    public void SetName(string name)
    {
        _name = name;
    }
}
