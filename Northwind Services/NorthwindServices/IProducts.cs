using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace NorthwindServices
{
    [ServiceContract]
    public interface IProducts
    {
        [OperationContract] 
        string GetProductName(int productID);

        [OperationContract]
        int GetProductQty(int productID);

        [OperationContract]
        string GetCategoryName(int productID);
    }
}
