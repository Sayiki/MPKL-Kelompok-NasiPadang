using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GUI_tubes_KPL;
using System.Windows.Forms;

namespace hitungsampah_test
{
    [TestClass]
    public class UnitTest1
    {
        private hitungSampah form;

        [TestInitialize]
        public void Initialize()
        {
            // Create an instance of the hitungSampah form
            form = new hitungSampah();
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Clean up resources and close the form after each test
            form.Close();
            form.Dispose();
        }

        [TestMethod]
        public void TestGetKategoriSampah_ValidInput()
        {
            // Arrange
            string validInput = "kertas a4";
            string expectedKategori = "paper";

            // Act
            string result = form.GetKategoriSampah(validInput);

            // Assert
            Assert.AreEqual(expectedKategori, result, "Category should match expected value");
        }

        [TestMethod]
        public void TestCalculateTotalSampah()
        {
            // Arrange
            hitungSampah form = new hitungSampah();
            int expectedTotal = 30; // total sampah yang diharapkan

            // Act
            form.ListOutput.Items.Add(new System.Windows.Forms.ListViewItem("bungkus indomie") { SubItems = { "plastic", "10" } });
            form.ListOutput.Items.Add(new System.Windows.Forms.ListViewItem("kertas a4") { SubItems = { "paper", "15" } });
            form.ListOutput.Items.Add(new System.Windows.Forms.ListViewItem("gelas kaca") { SubItems = { "glass", "5" } });

            form.CalculateTotalSampah(); // Hitung total sampah

            // Assert
            Assert.AreEqual("Total Sampah: " + expectedTotal, form.TotalLabel.Text);
        }
    }
}
