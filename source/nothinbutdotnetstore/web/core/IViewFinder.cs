namespace nothinbutdotnetstore.web.core
{
  public interface IViewFinder
  {
    IView FindView(IContainRequestInformation request, string viewName);
  }
}