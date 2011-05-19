using System;
using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore.web.application.catalogbrowsing.stubs
{
  public class StubStoreCatalog : ICanFindDetailsInTheStore
  {
    public IEnumerable<DepartmentItem> get_the_main_departments()
    {
      return Enumerable.Range(1, 10).Select(x => new DepartmentItem(x));
    }

    public IEnumerable<DepartmentItem> get_departments_for(DepartmentItem department)
    {
      return Enumerable.Range(11, 20).Select(x => new DepartmentItem(x));
    }

    public IEnumerable<ProductItem> get_products_for(DepartmentItem department)
    {
      return Enumerable.Range(1, 10).Select(x => new ProductItem { name = x.ToString("Product 0") });
    }

    public DepartmentItem get_department_by_id(int id)
    {
      return new DepartmentItem(id);
    }
  }
}