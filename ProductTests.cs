using NUnit.Framework;

namespace EcommerceApp.Tests
{
    [TestFixture]
    public class ProductTests
    {
        // Tests for ProductID

        [Test]
        public void ProductID_ShouldBeGreaterThanEqualTo5()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.ProductID, Is.GreaterThanOrEqualTo(5));
        }

        [Test]
        public void ProductID_ShouldBeLessThanEqualTo50000()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.ProductID, Is.LessThanOrEqualTo(50000));
        }

        [Test]
        public void ProductID_ShouldNotBeNegative()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.ProductID, Is.GreaterThanOrEqualTo(0));
        }

        // Tests for Price

        [Test]
        public void Price_ShouldBeGreaterThanEqualTo5()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.Price, Is.GreaterThanOrEqualTo(5.00m));
        }

        [Test]
        public void Price_ShouldBeLessThanEqualTo5000()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.Price, Is.LessThanOrEqualTo(5000.00m));
        }

        [Test]
        public void Price_ShouldNotBeNegative()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.Price, Is.GreaterThanOrEqualTo(0.00m));
        }

        // Tests for Stock

        [Test]
        public void Stock_ShouldBeGreaterThanEqualTo5()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.Stock, Is.GreaterThanOrEqualTo(5));
        }

        [Test]
        public void Stock_ShouldBeLessThanEqualTo500000()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.Stock, Is.LessThanOrEqualTo(500000));
        }

        [Test]
        public void Stock_ShouldNotBeNegative()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.Stock, Is.GreaterThanOrEqualTo(0));
        }

        // Tests for ProductName

        [Test]
        public void ProductName_ShouldNotBeNull()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.ProductName, Is.Not.Null);
        }

        [Test]
        public void ProductName_ShouldNotBeEmpty()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.ProductName, Is.Not.Empty);
        }

        [Test]
        public void ProductName_ShouldBeEqualToNew_Product()
        {
            // Arrange
            var product = new Product(6, "New Product", 10.00m, 100);

            // Act & Assert
            Assert.That(product.ProductName, Is.EqualTo("New Product"));
        }

        // Tests for Increase Stock Method

        [Test]
        public void IncreaseStock_ShouldIncreaseStockByGivenAmount()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act
            product.IncreaseStock(50);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(150));
        }

        [Test]
        public void IncreaseStock_ShouldNotChangeStockForNegativeAmount()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act
            product.IncreaseStock(-50);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(100));
        }

        [Test]
        public void IncreaseStock_ShouldNotChangeStockForZeroAmount()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act
            product.IncreaseStock(0);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(100));
        }

        // Tests for Decrease Stock Method

        [Test]
        public void DecreaseStock_ShouldDecreaseStockByGivenAmount()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act
            product.DecreaseStock(50);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(50));
        }

        [Test]
        public void DecreaseStock_ShouldNotChangeStockForNegativeAmount()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act
            product.DecreaseStock(-50);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(100));
        }

        [Test]
        public void DecreaseStock_ShouldNotGoBelowZeroStock()
        {
            // Arrange
            var product = new Product(6, "Testing Product", 10.00m, 100);

            // Act
            product.DecreaseStock(100);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(0));
        }
    }
}