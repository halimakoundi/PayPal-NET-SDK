﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayPal.Api;

namespace PayPal.UnitTest
{
    [TestClass]
    public class RelatedResourcesTest
    {
        public static RelatedResources GetRelatedResources()
        {
            RelatedResources resources = new RelatedResources();
            resources.authorization = AuthorizationTest.GetAuthorization();
            resources.capture = CaptureTest.GetCapture();
            resources.refund = RefundTest.GetRefund();
            resources.sale = SaleTest.GetSale();
            resources.order = OrderTest.GetOrder();
            return resources;
        }

        [TestMethod()]
        public void RelatedResourcesObjectTest() 
        {
            var resources = GetRelatedResources();
            Assert.AreEqual(resources.authorization.id, AuthorizationTest.GetAuthorization().id);
            Assert.AreEqual(resources.sale.id, SaleTest.GetSale().id);
            Assert.AreEqual(resources.refund.id, RefundTest.GetRefund().id);
            Assert.AreEqual(resources.capture.id, CaptureTest.GetCapture().id);
        }

        [TestMethod()]
        public void RelatedResourcesConvertToJsonTest() 
        {
            Assert.IsFalse(GetRelatedResources().ConvertToJson().Length == 0);
        }

        [TestMethod()]
        public void RelatedResourcesToStringTest() 
        {
            Assert.IsFalse(GetRelatedResources().ToString().Length == 0);
        }
    }
}
