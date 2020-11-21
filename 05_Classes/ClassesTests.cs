using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeofVehicles = VehicleType.Car;

        }
    }
}
