﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        #region Constructors
        public Product()
        {
            Console.WriteLine("Product instance created");
        }

        public Product(int productId, string productName, string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;

            Console.WriteLine("Product instance has name: " + ProductName);
        }
        #endregion

        #region Properties
        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        #endregion

        public string SayHello()
        {
            var vendor = new Vendor();
            vendor.SendWelcomeEmail("Message from Product");

            var emailService = new EmailService();
            var confirmation = emailService.SendMessage(
                "New Product",
                this.ProductName,
                "sales@abc.com");

            var result = LoggingService.LogAction("saying Hello");

            return "Hello " + ProductName +
                   " (" + ProductId + "): " +
                   Description;
        }
    }
}
