using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _3ChallengeThree_Repository;

namespace _3ChallengeThree_Tests
{
    [TestClass]
    public class BadgeRepoTests
    {
        private readonly BadgeRepo _repo = new BadgeRepo();
        [TestInitialize]
        public void Arrange()
        {
            Badge badge = new Badge(4444, "Employee A", new List<string>() { "G1", "G5", "G7" });
            _repo.AddBadgeToDictionary(badge.BadgeID,badge);
        }
        [TestMethod] 
        public void AddBadge_BadgeIsNull_ReturnFalse()
        {
            //Arrange
            Badge badge = null;
            BadgeRepo badgeRepo = new BadgeRepo();

            //Act
            bool result = badgeRepo.AddBadgeToDictionary(4444, badge);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddBadge_BadgeIsNotNull_ReturnTrue()
        {
            //Arrange
            Badge badge = new Badge(4445, "Employee A", new List<string>() { "G1", "G5", "G7" });
            BadgeRepo badgeRepo = new BadgeRepo();

            //Act
            bool result = badgeRepo.AddBadgeToDictionary(badge.BadgeID, badge);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdateBadge_BadgeDoesNotExist_ReturnNull()
        {
            //Arrange
            Badge badge = new Badge(1111, "Employee B", new List<string>() { "C1", "C2" });
            BadgeRepo repo = new BadgeRepo();
            repo.AddBadgeToDictionary(badge.BadgeID, badge);

            //Act
            Badge result = repo.GetBadgeByIDNumber(777);

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdateBadge_BadgeExists_ReturnIsNotNull()
        {
            //Arrange
            Badge badge = new Badge(1111, "Employee B", new List<string>() { "C1", "C2" });
            BadgeRepo repo = new BadgeRepo();
            repo.AddBadgeToDictionary(badge.BadgeID, badge);

            //Act
            Badge result = repo.GetBadgeByIDNumber(1111);

            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void GetListOfBadges_ListDoesNotExist_ReturnIsNull()
        {
            //Arrange
            Badge badge = new Badge(4445, "Employee A", new List<string>() { "G1", "G5", "G7" });
            BadgeRepo badgeRepo = new BadgeRepo();
            Dictionary<int, Badge> testDictionary = new Dictionary<int, Badge>();
            testDictionary = null;

            //Act

            bool result = badgeRepo.GetListOfAllBadges();
            //Assert
            Assert.IsNull(testDictionary);         
        }//Question

        [TestMethod]
        public void GetListOfBadges_ListDoesExist_ReturnIsNotNull()
        {
            //Arrange
            Badge badge = new Badge(4445, "Employee A", new List<string>() { "G1", "G5", "G7" });
            BadgeRepo badgeRepo = new BadgeRepo();
            Dictionary<int, Badge> testDictionary = new Dictionary<int, Badge>();

            //Act


        }//Question

    }
}
