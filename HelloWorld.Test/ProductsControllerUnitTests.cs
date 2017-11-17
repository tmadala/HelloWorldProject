using System.Configuration;
using System.IO;
using Moq;
using NUnit;
using NUnit.Framework;
using HelloWorldAPI.Business;
using HelloWorldAPI.Controllers;

namespace HelloWorldAPI.Tests.UnitTests
{
  
    [TestFixture]
    public class ProductsControllerUnitTests
    {
        /// <summary>
        ///     The mocked data service
        /// </summary>
        private Mock<IProductDetails> ProductDetailsMock;

        /// <summary>
        ///     The implementation to test
        /// </summary>
        private ProductsController productsController;

        /// <summary>
        ///     Initialize the test fixture (runs one time)
        /// </summary>
        [NUnit.Framework.SetUp]
        public void InitTestSuite()
        {
            // Setup mocked dependencies
            this.ProductDetailsMock = new Mock<IProductDetails>();

            // Create object to test
            this.productsController = new ProductsController(this.ProductDetailsMock.Object);
        }

        #region Get Tests
        /// <summary>
        ///     Tests the controller's get method for success
        /// </summary>
        [Test]
        public void ProductControllerSaveSuccess()
        {
            // Create the expected result
            var expectedResult = GetSampleProducts();
            HelloWorld.DAL.Products product = new HelloWorld.DAL.Products();

            // Set up dependencies
            this.ProductDetailsMock.Setup(m => m.SaveProducts(product)).Returns(true);

            // Call the method to test
            var result = this.productsController.saveProductDetails(product);

            // Check values
            Assert.NotNull(result);
            Assert.AreEqual(result, expectedResult);
        }

     
        #endregion

        #region Helper Methods
        /// <summary>
        ///     Gets a sample TodaysData model
        /// </summary>
        /// <returns>A sample TodaysData model</returns>
        private static HelloWorld.DAL.Products GetSampleProducts()
        {
            return new HelloWorld.DAL.Products()
            {
                Price= 20,
                productId= 250
            };
        }
        #endregion
    }
}