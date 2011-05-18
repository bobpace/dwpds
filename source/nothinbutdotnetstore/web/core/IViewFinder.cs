namespace nothinbutdotnetstore.web.core
{
  public interface IViewFinder
  {
    IView FindView(IContainRequestInformation request);
  }

  public interface IView
  {
    void Render();
  }
}