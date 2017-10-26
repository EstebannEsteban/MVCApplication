using System;
using System.Web.Mvc;
using MVCApplication.Controllers;
using MVCApplication.Models.EntityManager;
using NUnit.Framework;

namespace MVCApplication.Unit.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void UserShoulAlreadyCreated()
        {
            var sut = new UserManager();

            var isUserCreated = sut.IsLoginNameExist("esteban");

            Assert.That(isUserCreated, Is.True);

            //AppDomain.CurrentDomain.SetData();
        }

        [Test]
        public void ValidateHomePage()
        {
            var sut = new HomeController();

            var result = sut.Index() as ViewResult;



            Assert.That(result.ViewName, Is.EqualTo("index"));

        }


    }
}
