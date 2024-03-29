﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();

            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";


            string expected = "Baggins, Bilbo";

            
            //--Act

            string actual = customer.FullName;

            //--Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();

            customer.LastName = "Baggins";


            string expected = "Baggins";


            //--Act

            string actual = customer.FullName;

            //--Assert

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();

            customer.FirstName = "Bilbo";


            string expected = "Bilbo";


            //--Act

            string actual = customer.FullName;

            //--Assert

            Assert.AreEqual(expected, actual);



        }
    
    
    
    
    
    }

}
