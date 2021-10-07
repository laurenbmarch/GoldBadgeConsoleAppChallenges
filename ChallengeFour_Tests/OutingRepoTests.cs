using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChallengeFour_RepositoryA;

namespace ChallengeFour_Tests
{
    [TestClass]
    public class OutingRepoTests
    {
        private readonly OutingRepo _repo = new OutingRepo();
        [TestInitialize]
        public void Arrange()
        {
            Outing outing = new Outing(EventType.Concert, 100, new DateTime(2021, 06, 07), 50.00m, 5000.00m);
            _repo.AddOutingToList(outing);
        } //Question
        [TestMethod]
        public void GetAllOutings_ListDoesExist_ReturnIsNotNull() //Question
        {
            //Arrange

            //Act

            //Assert

        }
        [TestMethod]
        public void GetAllOutings_ListDoesNotExist_ReturnIsNull() //Question
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void AddOuting_OutingIsNull_ReturnFalse()
        {
            //Arrange
            Outing newOuting = null;
            OutingRepo outingRepo = new OutingRepo();

            //Act
            bool result = outingRepo.AddOutingToList(newOuting);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddOuting_OutingIsNotNull_ReturnTrue()
        {
            //Arrange
            Outing newOuting = new Outing(EventType.Golf, 10, new DateTime(2021, 04, 16), 80.00m, 800.00m);
            OutingRepo outingRepo = new OutingRepo();

            //Act
            bool result = outingRepo.AddOutingToList(newOuting);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddAllOutingCosts_SumOfCostsIsCorrect_ReturnIsEqual() //Question
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void AddAllOutingCosts_SumOfCostsIsIncorrect_ReturnIsNotEqual() //Question
        {
            //Arrange

            //Act

            //Assert

        }
        [TestMethod]
        public void AddCostsByType_TypeIsNull_ReturnIsNull() //Question
        {

        }
        [TestMethod]
        public void AddCostsByType_TypeIsNotNull_ReturnIsNotNull() //Question
        {

        }
    }
}
