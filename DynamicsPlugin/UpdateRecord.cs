using Microsoft.Xrm.Sdk;
using System;

namespace DynamicsPlugin
{
    public class UpdateRecord : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {

            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

            //_serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            //_service = _serviceFactory.CreateOrganizationService(context.UserId);


            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));


            try
            {
                //if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
                //{
                //    Entity targetEntity = (Entity)context.InputParameters["Target"];
                //    Entity preImage = context.PreEntityImages.Contains("PreImage") ? context.PreEntityImages["PreImage"] : null;
                //    Entity postImage = context.PostEntityImages.Contains("PostImage") ? context.PostEntityImages["PostImage"] : null;

                //    if (preImage != null && postImage != null &&
                //        preImage.Contains("utapi_name") && postImage.Contains("utapi_name") &&
                //        preImage.Contains("utapi_fathername") && postImage.Contains("utapi_fathername"))
                //    {
                //        string previousName = preImage.GetAttributeValue<string>("utapi_name");
                //        string currentName = postImage.GetAttributeValue<string>("utapi_name");
                //        string currentFatherName = postImage.GetAttributeValue<string>("utapi_fathername");

                //        if (previousName != currentName && currentName == "Hamza" && currentFatherName != "Ilyas")
                //        {
                //            Entity updatedEntity = new Entity(targetEntity.LogicalName);
                //            updatedEntity.Id = targetEntity.Id;
                //            updatedEntity["utapi_fathername"] = "Ilyas";

                //            tracingService.Trace("Error Message");
                //            service.Update(updatedEntity);
                //        }
                //    }
                //}



                Entity newRecord = new Entity("utapi_user");

                newRecord["utapi_name"] = "Ali";
                newRecord["utapi_fathername"] = "But";

                //Guid newRecordId = service.Create(newRecord);
                service.Create(newRecord);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
