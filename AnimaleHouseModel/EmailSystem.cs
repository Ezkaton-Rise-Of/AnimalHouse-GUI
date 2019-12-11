using System;
using System.Collections.Generic;
using System.Threading;

namespace AnimaleHouseModel
{
    public class EmailSystem
    {
        
        public EmailSystem() { }
        public bool CreateEmail(string subjekt, string inhold,List<string> emaillist)
        {
            try
            {
                foreach (var modtager in emaillist)
                {
                    Email e = new Email();
                    Thread t = new Thread(() => SendEmail(subjekt, inhold, modtager));
                    t.Start();
                }
                return true;
            }
            catch (Exception)
            {
                //throw;
                return false;
                
            }
        }
        private bool SendEmail(string subjekt, string inhold, string modtager)
        {
            Email email = new Email();
            return email.SendEmail(subjekt,inhold,modtager);
        }
    }
}
