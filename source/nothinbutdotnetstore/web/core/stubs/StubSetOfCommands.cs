using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.web.core.stubs
{
  public class StubSetOfCommands : IEnumerable<IProcessRequestInformation>
  {
    public IEnumerator<IProcessRequestInformation> GetEnumerator()
    {
      yield return new RequestCommand(x => x.get_url() == "/departments.denver",
                                      new ViewMainDepartmentsInTheStore());
      yield return new RequestCommand(x => x.get_url() == "/departments/{id}.denver",
                                      new ViewTheDepartmentsInADepartment());
      yield return new RequestCommand(x => x.get_url() == "/departments/{id}/products.denver",
                                      new ViewProductsInADepartment());
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}