using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TechTest01.Domain;
using TechTest01.Domain.Catalog;
using TechTest01.Services;
using TechTest01.Services.Catalog;
using TechTest01.Web.Controllers;
using TechTest01.Web.Models;

namespace WebApplication1.Tests.Controllers
{

    [TestClass]
    public class ProductsControllerTest
    {
        IProductService _productService;
        ILogManager _logManager;

        [TestInitialize]
        public void Init()
        {
            var mockProducts = (new List<Product>
            {
            new Product{Id = 1, Slug="t-shirt", Description="T-Shirt", ImageUrl="t-shirt1.png", Name="T-Shirt", Price = 15.99M},
            new Product{Id = 2, Slug="abc-jacket", Description="It's a Jacket", ImageUrl="jacket10.png", Name="Abc jacket", Price = 55.99M},
            new Product{Id = 3, Slug="mens-xyz-jacket", Description="It's another Jacket", ImageUrl="jacket1.png", Name="Mens Xyz Jacket", Price = 45.99M},
            new Product{Id = 4, Slug="abc-sports-shorts", Description="There are shorts", ImageUrl="shorts1.png", Name="ABC Sports Shorts", Price = 38.99M},
            new Product{Id = 5, Slug="abc-t-shirt", Description="It's a tshirt", ImageUrl="t-shirt2.png", Name="Abc T-Shirt", Price = 20.99M},
            }).Select(x => x).AsQueryable();



            var mockDataRepo = new Mock<IProductRepository>();
            mockDataRepo.Setup(d => d.GetAll()).Returns(mockProducts);
            mockDataRepo.Setup(d => d.Get(It.IsAny<int>())).Returns(mockProducts.Single(p=>p.Id == 3));
            mockDataRepo.Setup(d => d.Get(It.IsAny<string>())).Returns((string slug) => mockProducts.Single(p => p.Slug == slug));
            _productService =  new ProductService(mockDataRepo.Object);


            var mockLogManager = new Mock<ILogManager>();
            _logManager = mockLogManager.Object;
            
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            ProductsController controller = new ProductsController(_productService, _logManager);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RandomProductsPartial()
        {
            // Arrange
            ProductsController controller = new ProductsController(_productService, _logManager);

            // Act
            PartialViewResult result = controller.RandomProductsPartial() as PartialViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = (ICollection<ProductVm>)result.Model;
            Assert.AreEqual(2, model.Count);
        }

        [TestMethod]
        public void GetProductDetails()
        {
            // Arrange
            ProductsController controller = new ProductsController(_productService, _logManager);

            // Act
            ViewResult result = controller.Details("abc-jacket") as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            var model = (ProductVm)result.Model;
            Assert.AreEqual(2, model.Id);
        }
    }
}
