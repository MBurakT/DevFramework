using DevFramework.Northwind.DataAccess.Concrete.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.NHibernat.Tests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_paremeter_returns_filtered_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList(p => p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
