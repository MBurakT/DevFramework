using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.EntityFramework.Tests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal efProductDal = new EfProductDal();

            var result = efProductDal.GetList();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_paremeter_returns_filtered_products()
        {
            EfProductDal efProductDal = new EfProductDal();

            var result = efProductDal.GetList(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
