/*using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Tooling.Connector;

namespace APPCDA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var connectionString = @"AuthType = Office365; Url = https://org764cc19a.crm4.dynamics.com/;Username=Theo.PERSONNE@TalanCloudExperts.onmicrosoft.com;Password=Lionceaux999*";
                CrmServiceClient conn = new CrmServiceClient(connectionString);

                IOrganizationService service;
                service = (IOrganizationService)conn.OrganizationWebProxyClient != null ? (IOrganizationService)conn.OrganizationWebProxyClient : (IOrganizationService)conn.OrganizationServiceProxy;

                // Create a new record
                Entity contact = new Entity("contact");
                contact["firstname"] = "Bob";
                contact["lastname"] = "Smith";
                Guid contactId = service.Create(contact);
                Console.WriteLine("New contact id: {0}.", contactId.ToString());

                // Retrieve a record using Id
                Entity retrievedContact = service.Retrieve(contact.LogicalName, contactId, new ColumnSet(true));
                Console.WriteLine("Record retrieved {0}", retrievedContact.Id.ToString());

                // Update record using Id, retrieve all attributes
                Entity updatedContact = new Entity("contact");
                updatedContact = service.Retrieve(contact.LogicalName, contactId, new ColumnSet(true));
                updatedContact["jobtitle"] = "CEO";
                updatedContact["emailaddress1"] = "test@test.com";
                service.Update(updatedContact);
                Console.WriteLine("Updated contact");

                // Retrieve specific fields using ColumnSet
                ColumnSet attributes = new ColumnSet(new string[] { "jobtitle", "emailaddress1" });
                retrievedContact = service.Retrieve(contact.LogicalName, contactId, attributes);
                foreach (var a in retrievedContact.Attributes)
                {
                    Console.WriteLine("Retrieved contact field {0} - {1}", a.Key, a.Value);
                }

                // Delete a record using Id
                /* service.Delete(contact.LogicalName, contactId);
                 Console.WriteLine("Deleted");
                 Console.ReadLine();*/
                
/*
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
*/