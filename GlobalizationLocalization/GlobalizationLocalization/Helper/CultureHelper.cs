using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.SessionState;

namespace GlobalizationLocalization.Helper
{
    public class CultureHelper
    {
        protected HttpSessionState session;

        //Constructor
        public CultureHelper(HttpSessionState httpSessionState)
        {
            session = httpSessionState;
        }

        //properties
        public static int CurrentCulture
        {
            get
            {
                if(Thread.CurrentThread.CurrentUICulture.Name=="en-GB")
                {
                    return 0;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "hi-IN")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
              
            }
            set
            {
                if(value == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                }
                else if (value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("hi-IN");
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                }

                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            }
        }

    }
}