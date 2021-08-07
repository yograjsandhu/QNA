using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QNA.Controllers;
using System.Web.Mvc;


namespace QNATest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {

            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Privacy()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Privacy() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }


    }


    //Question controller tests
    public class QuestionsControllerTest
    {



        [TestMethod]
        public void Create()
        {
            // Arrange
            QuestionsController controller = new QuestionsController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }





    }

    //Answer controller tests
    public class AnswersControllerTest
    {

        [TestMethod]
        public void Create()
        {
            // Arrange
            AnswersController controller = new AnswersController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
    public class CategoriesControllerTest
    {



        [TestMethod]
        public void Create()
        {
            // Arrange
            CategoriesController controller = new CategoriesController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

    }


}
