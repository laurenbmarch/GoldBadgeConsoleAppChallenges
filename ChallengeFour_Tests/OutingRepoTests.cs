using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChallengeFour_RepositoryA;

namespace ChallengeFour_Tests
{
    [TestClass]
    public class OutingRepoTests
    {
        private readonly OutingRepo _repo = new OutingRepo();
        [TestMethod]
        public void GetAllOutings_ListDoesExist_ReturnIsNotNull()
        {
            //Arrange
            OutingRepo outingRepo = new OutingRepo();

            //Assert
            Assert.IsNotNull(outingRepo.GetAllOutings());
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
    }
}
