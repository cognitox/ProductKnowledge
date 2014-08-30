using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnowSL.Enumerations;
using KnowSL.Database;
using System.Configuration;

namespace KnowSL.Services
{
    public class NewsLetterService
    {
        public NewsLetterService()
        {

        }

        public PilotSignupStatus CreateOrUpdate(String emailAddress)
        {
            var result = PilotSignupStatus.Failed;
            try
            {
                var context = new PKDatabaseDataContext(ConfigurationManager.ConnectionStrings["DB_9B214B_ProductKnowledgeConnectionString"].ToString());

                context.NewsLetters.InsertOnSubmit(new NewsLetter()
                {
                    email = emailAddress
                });
                context.SubmitChanges();
                result = PilotSignupStatus.Success;
            }
            catch (Exception) { }
            return result;
        }

        public List<NewsLetter> GetAll()
        {
            var result = new List<NewsLetter>();
            try
            {
                var context = new PKDatabaseDataContext(ConfigurationManager.ConnectionStrings["DB_9B214B_ProductKnowledgeConnectionString"].ToString());
                result = context.NewsLetters.ToList();

            }
            catch (Exception) { }
            return result;            
        }

    }
}