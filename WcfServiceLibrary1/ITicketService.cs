using DAL.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface ITicketService
    {
        [OperationContract]
        string GetYourString(string str);

        [OperationContract]
        IEnumerable<Ticket> GetAll();

        [OperationContract]
        int Create(Ticket ticket);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Ticket ticket);
    }
}
