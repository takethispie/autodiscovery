using System;

namespace DustCatMicroService
{
    public delegate void MessageEvent(object sender, MicroServiceEventArgs e);

    public class MicroServiceBus
    {
        public string Name;

        public event MessageEvent sendToService;

        public MicroServiceBus()
        {

        }

        /// <summary>
        /// Receives message from service.
        /// call by service
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">event wich contains the message sent.</param>
        public void receiveFromService(object sender, MicroServiceEventArgs e)
        {
            //Console.WriteLine("receiving message to bus with:");
            //Console.WriteLine("header: " + e.message.header);
            //Console.WriteLine("content: " + e.message.content);
            //Console.WriteLine("Target Name: " + e.message.TargetName);
            //Console.WriteLine("Target ID: " + e.message.TargetId);
            Delegate[] DelegateList = sendToService.GetInvocationList();
            bool messageIssued = false;

            foreach (Delegate d in DelegateList)
            {
                MicroService ms = (MicroService)d.Target;
                if ((ms.GetType().Name == e.message.TargetName || e.message.TargetId == ms.Id) && e.message.TargetId != 0 && ms.started)
                {
                    ms.receive(sender, e);
                }
                else if (e.message.TargetId == 0)
                {
                    //need some review later
                    foreach (Delegate de in DelegateList)
                    {
                        MicroService serv = (MicroService)de.Target;
                        if (e.message.TargetName == serv.GetType().Name)
                        {
                            switch (e.message.header)
                            {
                                case "START_SERV":
                                    serv.InitService();
                                    break;

                                case "STOP_SERV":
                                    serv.ShutdownService();
                                    break;
                            }
                            messageIssued = true;
                            break;
                        }
                    }

                    //message issued, we need to exit ReceiveFromService
                    if (messageIssued)
                    {
                        break;
                    }
                }
            }
        }
    }
}

