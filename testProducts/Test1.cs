using prjPROG6212_ICE_2;

namespace testProducts
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestName()
        {
            Products product = new Products("Coffee", "The Best Coffee", 100, 12.50);
            Assert.AreEqual("Coffee", product[0]);
        }

        [TestMethod]
        public void TestBrand()
        {
            Products product = new Products("Milk", "The Best Milk", 25, 7.50);
            Assert.AreEqual("The Best Milk", product["brand"]);
        }

        [TestMethod]
        public void UpdatePriceTest()
        {
            Products product = new Products("Chocolate", "The Best Chocolate", 1000, 20.00);
            product[3] = 25.00;
            Assert.AreEqual(25.00, product["price"]);
        }

        [TestMethod]
        public void UpdateInventoryTest()
        {
            Products product = new Products("Water", "The Best Water", 250, 10.00);
            product["inventory"] = 243;
            Assert.AreEqual(243, product[2]);
        }

        [TestMethod]
        public void UpdateBrandTest()
        {
            Products product = new Products("Apples", "The Best Apples", 10000, 100.00);
            product["brand"] = "The Second Best Apples";
            Assert.AreEqual("The Second Best Apples", product["brand"]);
        }

    }
}
