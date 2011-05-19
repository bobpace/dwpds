namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class DepartmentItem
  {
    public DepartmentItem() : this(0)
    {
    }

    public DepartmentItem(int id)
    {
      this.id = id;
      this.name = id.ToString("Department 0");
    }

    public string name { get; set; }
    public int id { get; set; }
  }
}