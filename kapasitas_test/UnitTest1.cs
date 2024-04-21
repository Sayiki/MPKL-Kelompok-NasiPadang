using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using GUI_tubes_KPL; 

namespace kapasitas_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKapasitasDalamRange()
        {
            // Arrange
            hitungSampah hs = new hitungSampah();
            hs.LoadSampahData();
            hs.sampahDataList.Add(new SampahData("kertas a4", "kertas", 10)); 


            // Act
            int totalSampah = hs.sampahDataList.Sum(data => data.NominalSampah);

            // Assert
            Assert.AreEqual(10, totalSampah, "Jadi 10");
        }


        [TestMethod]
        public void TestKapasitasLebihDari10()
        {
            // Arrange
            hitungSampah hs = new hitungSampah();
            hs.LoadSampahData();
            hs.sampahDataList.Add(new SampahData("kertas a4", "kertas", 11)); 


            // Act
            int totalSampah = hs.sampahDataList.Sum(data => data.NominalSampah);

            // Assert
            Assert.AreEqual(10, totalSampah, "Total should be capped at 10");
        }
    }
}
