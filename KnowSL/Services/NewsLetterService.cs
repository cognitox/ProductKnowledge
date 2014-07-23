using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnowSL.Enumerations;

namespace KnowSL.Services
{
    public class NewsLetterService
    {
        public NewsLetterService()
        {

        }

        public PilotSignupStatus CreateOrUpdate(String emailAddress)
        {
            //throw new NotImplementedException();
            return PilotSignupStatus.Success;
        }

    }
}