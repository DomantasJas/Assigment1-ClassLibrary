using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assigment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Bob", Age = 23, ShirtNumber = 59 };

        [TestMethod()]
        public void ValidateNameTest()
        {
            player.ValidateName();
            FootballPlayer nameToShort = new FootballPlayer() { Id = 2, Name = "", Age = 35, ShirtNumber = 65 };
            Assert.ThrowsException<ArgumentException>(
                () => nameToShort.ValidateName());

            FootballPlayer nameIsNull = new FootballPlayer() { Id = 3, Name = null, Age = 35, ShirtNumber = 65 };
            Assert.ThrowsException<ArgumentNullException>(
                ()=> nameIsNull.ValidateName());

            FootballPlayer nameIsGood = new FootballPlayer() { Id = 4, Name = "Do", Age = 27, ShirtNumber = 11 };
                nameIsGood.ValidateName();

        }
        [TestMethod()]
        public void ValidateAgeTest()
        {

            player.ValidateAge();
            FootballPlayer ageToLow = new FootballPlayer() { Id = 5, Name = "John", Age = 0, ShirtNumber = 21 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => ageToLow.ValidateAge());

            FootballPlayer ageIsGood = new FootballPlayer() { Id = 6, Name = "Jack", Age = 55, ShirtNumber = 13 };
            player.ValidateAge();

        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            player.ValidateShirtNumber();
            FootballPlayer shirtNummberTooLow = new FootballPlayer() { Id = 7, Name = "Dom", Age = 15, ShirtNumber = 0 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => shirtNummberTooLow.ValidateShirtNumber());

            FootballPlayer shirtNumberTooHigh = new FootballPlayer() { Id = 8, Name = "Sack", Age = 39, ShirtNumber = 100 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => shirtNumberTooHigh.ValidateShirtNumber());

            FootballPlayer shirtNumberIsGood = new FootballPlayer() { Id = 9, Name = "BigMack", Age = 12, ShirtNumber = 70 };
            shirtNumberIsGood.ValidateShirtNumber();
        }
    }
}