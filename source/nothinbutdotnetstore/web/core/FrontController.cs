using System;

namespace nothinbutdotnetstore.web.core
{
  public class FrontController : IProcessIncomingRequests
  {
    readonly IFindCommands find_commands;

    public FrontController(IFindCommands find_commands)
    {
      this.find_commands = find_commands;
    }

    public void process(IContainRequestInformation request)
    {
      var command = find_commands.get_the_command_that_can_process(request);
      command.run(request);
    }
  }
}