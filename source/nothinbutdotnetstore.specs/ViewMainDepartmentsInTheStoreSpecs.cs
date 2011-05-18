 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.web.core;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs
{  
  [Subject(typeof(ViewMainDepartmentsInTheStore))]  
  public class ViewMainDepartmentsInTheStoreSpecs
  {
    public abstract class concern : Observes<IProcessAnApplicationSpecificBehaviour,
                                      ViewMainDepartmentsInTheStore>
    {
    }

   
    public class when_run : concern
    {
      Establish c = () =>
      {
        viewName = "main-departments-in-the-store";
        viewFinder = depends.on<IViewFinder>();
        view = fake.an<IView>();
        requestInformation = fake.an<IContainRequestInformation>();
        viewFinder.setup(x => x.FindView(requestInformation, viewName)).Return(view);
      };

      Because b = () =>
        sut.run(requestInformation);

      It should_find_a_view_for_main_departments_in_the_store = () =>
        viewFinder.received(x => x.FindView(requestInformation, viewName));

      It should_render_the_view = () =>
        view.received(x => x.Render());

      static IViewFinder viewFinder;
      static IContainRequestInformation requestInformation;
      static IView view;
      static string viewName;
    }
  }
}
