using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
  public class DisplayResultsFromStoreCatalog<ResultType> : IProcessAnApplicationSpecificBehaviour
  {
    ICanRenderInformation display_engine;
    ICanFindDetailsInTheStore store_catalog;
    GetResults<ResultType> get_results;

    public DisplayResultsFromStoreCatalog(ICanRenderInformation display_engine, ICanFindDetailsInTheStore store_catalog, GetResults<ResultType> get_results)
    {
      this.display_engine = display_engine;
      this.store_catalog = store_catalog;
      this.get_results = get_results;
    }

    public void run(IContainRequestInformation request)
    {
      display_engine.display(get_results(store_catalog));
    }
  }
}