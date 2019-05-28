using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using PeopleCoreMvcApplication.Controllers;
using PeopleCoreMvcApplication.Models;
using PeopleCoreMvcApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class PeopleControllerUnitTests
    {
        readonly IList<Person> fakePeopleList = new List<Person>()
        {
            new Person { Id = Guid.NewGuid(), Name = "Test Person", Phone = "0123654789", Email = "person@test.com" }
        };
        readonly Person fakePerson = new Person { Name = "Test Create", Phone = "0123654789", Email = "person@test.com" };
        readonly Mock<IPeopleRepository> mockRepository = new Mock<IPeopleRepository>();
        readonly Mock<ITempDataDictionary> mockTempData = new Mock<ITempDataDictionary>();

        [Fact]
        public async Task Index_ReturnsViewResult()
        {
            // Arrange
            mockRepository.Setup(repo => repo.GetPeopleAsync())
                .ReturnsAsync(fakePeopleList);

            var controller = new PeopleController(mockRepository.Object);

            // Act
            var result = await controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Index_HasPeopleList()
        {
            // Arrange
            mockRepository.Setup(repo => repo.GetPeopleAsync())
                .ReturnsAsync(fakePeopleList);

            var controller = new PeopleController(mockRepository.Object);

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IList<Person>>(
                viewResult.ViewData.Model);
        }

        [Fact]
        public void Create_RedirectsIfPersonIsAddedSuccessfully()
        {
            // Arrange
            mockRepository.Setup(repo => repo.InsertPerson(fakePerson))
                .Returns(1);

            var controller = new PeopleController(mockRepository.Object) { TempData = mockTempData.Object };
            
            // Act
            var result = controller.Create(fakePerson);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Null(redirectToActionResult.ControllerName);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        [Fact]
        public void Create_RetainsViewIfPersonModelIsInvalid()
        {
            // Arrange
            var controller = new PeopleController(mockRepository.Object) { TempData = mockTempData.Object };
            controller.ModelState.AddModelError("Name", "Required");

            // Act
            var result = controller.Create(fakePerson);

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_AddssModelErrorIfDatabaseInsertIsUnsuccessful()
        {
            // Arrange
            mockRepository.Setup(repo => repo.InsertPerson(fakePerson))
                .Returns(0);

            var controller = new PeopleController(mockRepository.Object) { TempData = mockTempData.Object };

            // Act
            controller.Create(fakePerson);

            // Assert
            Assert.True(controller.ModelState.ErrorCount == 1);
        }
    }
}
