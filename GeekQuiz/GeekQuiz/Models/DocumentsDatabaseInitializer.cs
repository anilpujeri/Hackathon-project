// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

namespace GeekQuiz.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    public class DocumentsDatabaseInitializer : DropCreateDatabaseIfModelChanges<DocumentsContext>
    {
        protected override void Seed(DocumentsContext context)
        {
            base.Seed(context);

            var documents = new List<Documents>();

            documents.Add(new Documents
            {
                UserId = "BSK123",
                DocumentType = "Passport",
                DocumentNumber = "ABC123ABC",
                FirstName = "Sudhanva",
                LastName  = "Kotabagi",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
               
            });

            documents.Add(new Documents
            {
                UserId = "BSK123",
                DocumentType = "Driver License",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Sudhanva",
                LastName = "Kotabagi",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BSK123",
                DocumentType = "Green Card",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Sudhanva",
                LastName = "Kotabagi",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BSK123",
                DocumentType = "National Id",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Sudhanva",
                LastName = "Kotabagi",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BSK123",
                DocumentType = "Power of Attorney",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Sudhanva",
                LastName = "Kotabagi",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BSK123",
                DocumentType = "Tax Id",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Sudhanva",
                LastName = "Kotabagi",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BSK123",
                DocumentType = "Voter Id",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Sudhanva",
                LastName = "Kotabagi",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            //ANIL

            documents.Add(new Documents
            {
                UserId = "BAP123",
                DocumentType = "Passport",
                DocumentNumber = "ABC123ABC",
                FirstName = "Anil",
                LastName = "Pujeri",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",

            });

            documents.Add(new Documents
            {
                UserId = "BAP123",
                DocumentType = "Driver License",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Anil",
                LastName = "Pujeri",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BAP123",
                DocumentType = "Green Card",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Anil",
                LastName = "Pujeri",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BAP123",
                DocumentType = "National Id",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Anil",
                LastName = "Pujeri",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BAP123",
                DocumentType = "Power of Attorney",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Anil",
                LastName = "Pujeri",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BAP123",
                DocumentType = "Tax Id",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Anil",
                LastName = "Pujeri",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });


            documents.Add(new Documents
            {
                UserId = "BAP123",
                DocumentType = "Voter Id",
                DocumentNumber = "XYZ123XYZ",
                FirstName = "Anil",
                LastName = "Pujeri",
                ValidFrom = DateTime.Now.AddDays(-60),
                ValidTill = DateTime.Now.AddDays(300),
                ImagePath = "",
            });

            
            documents.ForEach(a => context.Documents.Add(a));

            context.SaveChanges();
        }
    }
}