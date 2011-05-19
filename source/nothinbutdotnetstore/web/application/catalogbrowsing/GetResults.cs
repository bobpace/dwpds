using System;
using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public delegate IEnumerable<Type> GetResults<T>(ICanFindDetailsInTheStore store_catalog);
}