using InvestorROI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestorROI.Repository
{
    public interface IInvestorROIRepository<T> where T : BaseModel
    {
        List<T> GetAll();
    }
}
