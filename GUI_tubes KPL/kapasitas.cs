using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KapasitasLibrary;

namespace GUI_tubes_KPL
{
    public partial class kapasitas : Form
    {
        // Add a private field to store the label control
        private Label _totalInputLabel;


        public kapasitas()
        {
            InitializeComponent();

            // Assign the label control to the private field
            _totalInputLabel = totalinput;
        }

        // Replace the old property implementation with this one
        public Label TotalInputLabel
        {
            get { return _totalInputLabel; }
            set { _totalInputLabel = value; }
        }

        private void totalinput_Click(object sender, EventArgs e)
        {

        }

        public void kapasitas_Load(object sender, EventArgs e)
        {
            // Load sampahDataList from the file
            hitungSampah hs = new hitungSampah();
            hs.LoadSampahData();

            // Calculate the total sampah
            int totalSampah = hs.sampahDataList.Sum(data => data.NominalSampah);

            // Update the total sampah in the kapasitas form
            TotalInputLabel.Text = kapasitaslibrary.UpdateTotalInput(totalSampah);
        }
    }
}
