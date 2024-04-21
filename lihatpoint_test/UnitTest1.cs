using GUI_tubes_KPL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTesting_Poin
{
    [TestClass]
    public class LihatPoinTests
    {
        [TestMethod]
        public void TestCalculatePoinPlastic()
        {
            // Arrange
            LihatPoin lihatPoin = new LihatPoin();

            // Act
            int result = lihatPoin.CalculatePoin("plastic", 6);

            // Assert
            Assert.AreEqual(3 * 6, result);
        }

        [TestMethod]
        public void TestCalculateTotalPoints()
        {
            // Arrange
            LihatPoin lihatPoin = new LihatPoin();
            List<SampahData> sampahDataList = new List<SampahData>
        {
            new SampahData("Plastic", "plastic", 2), // 1 plastic : 3
            new SampahData("Glass", "glass", 3), // 1 glass : 4
            new SampahData("Paper", "paper", 4), // 1 paper : 2
            new SampahData("Cardboard", "cardboard", 1), // 1 cardboard : 3
        };

            // Act
            lihatPoin.SetSampahDataList(sampahDataList);
            int result = lihatPoin.CalculateTotalPoints();

            // Assert
            Assert.AreEqual(29, result);
        }
    }
}