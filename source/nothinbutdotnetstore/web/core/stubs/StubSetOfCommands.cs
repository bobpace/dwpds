using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.web.core.stubs
{
  public class StubSetOfCommands : IEnumerable<IProcessRequestInformation>
  {
    public IEnumerator<IProcessRequestInformation> GetEnumerator()
    {
      //todo need a way to map 
      //yield return new RequestCommand(x => true,
      //                                new ViewTheDepartmentsInADepartment());
      yield return new RequestCommand(x => x.get_url() == "/departments.denver",
                                      new ViewMainDepartmentsInTheStore());
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }


}