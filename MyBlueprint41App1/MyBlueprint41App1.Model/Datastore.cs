using System;

using Blueprint41;

namespace MyBlueprint41App1.Model
{
    public class Datastore : DatastoreModel<Datastore>
    {
        [Version(1, 0, 0)]
        protected void Initial()
        {
            // Define your data model here            
            throw new NotImplementedException();
        }

        protected override void SubscribeEventHandlers()
        {
            // Susbcribe your event handlers here
            throw new NotImplementedException();
        }
    }
}
