using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FKArch.Core;

namespace FKArch.UnitTests
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           ///qwerty
        }
        ProductCore pCore = new ProductCore();
        public void GetAll()
        {
            pCore.GetAll();
        }
        public void GetSingle()
        {
            pCore.GetProductByStatus(true);
        }
    }
}
