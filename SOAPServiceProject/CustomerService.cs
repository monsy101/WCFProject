using System;

namespace SOAPServiceProject
{
    public class CustomerService : ICustomerService
    {
        public string GetCustomerDetails(int customerId)
        {
            // For now, return a simple message. You can connect this to a database later.
            return $"Customer details for ID {customerId}";
        }
    }
}
