using System;

namespace nothinbutdotnetstore.web.core
{
  public class ViewMainDepartmentsInTheStore : IProcessAnApplicationSpecificBehaviour
  {
    readonly IViewFinder view_finder;

    public ViewMainDepartmentsInTheStore(IViewFinder view_finder)
    {
      this.view_finder = view_finder;
    }

    public void run(IContainRequestInformation request)
    {
      var view = view_finder.FindView(request, "main-departments-in-the-store");
      view.Render();
    }
  }
}