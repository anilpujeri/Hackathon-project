using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using GeekQuiz.Models;
using System.Web;
using System.IO;

namespace GeekQuiz.Controllers
{
    [Authorize]
    public class DocumentsController : ApiController
    {
        private DocumentsContext db = new DocumentsContext();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }

        // GET api/Trivia
        [ResponseType(typeof(Documents))]
        public async Task<IHttpActionResult> Get()
        {
            var userId = User.Identity.Name;

            if (userId == "sudhanva.kotabagi@inszoom.com")
            {
                userId = "BSK123";
            }
            else
            {
                userId = "BAP123";
            }

            var documentsList = from doc in db.Documents
                                where doc.UserId == userId
                                select doc;

            if (documentsList == null)
            {
                return this.NotFound();
            }

            Documents[] documentsArray = documentsList.ToArray();


            return this.Ok(documentsArray);
        }

        

        // POST api/Trivia
        [ResponseType(typeof(TriviaAnswer))]
        public async Task<IHttpActionResult> Post(Documents documents)
        {
            DocumentsContext context = new DocumentsContext();
            var userId = User.Identity.Name;
            Int16 documentStartCount = 0;
            Int16 documentEndCount = 0;


            


            if (documents.DocumentType != null)
            {


                if (userId == "sudhanva.kotabagi@inszoom.com")
                {
                    documents.UserId = "BSK123";
                }
                else
                {
                    documents.UserId = "BAP123";
                }

                if (documents.ImagePath != null)
                {
                    documents.ImagePath = documents.ImagePath.Replace("C:\\fakepath\\", "");
                }

                documentStartCount = Convert.ToInt16(context.Documents.Count());

                context.Documents.Add(documents);

                context.SaveChanges();


                documentEndCount = Convert.ToInt16(context.Documents.Count());
            }
            if (documentEndCount > documentStartCount)
            {
                //return RedirectToRoute("Home/Index","");
                return this.Ok(true);
            }
            else
            {
                return this.Ok(false);
            }

        }
    }
}
