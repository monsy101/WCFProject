using System.ServiceModel;

namespace SOAPServiceProject
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        string GetCustomerDetails(int customerId);
    }
}
