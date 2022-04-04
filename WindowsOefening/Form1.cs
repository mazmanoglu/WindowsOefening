using LeeszaalLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsOefening
{
    public partial class Form1 : Form
    {
        public ReadingRoom readingRoom = new ReadingRoom();
        public int numberOfHats = 0;
        public int numberOfMagazins = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readingRoom.AddReader(10);
            readingRoom.AddReader(10);
            lstReaders.DataSource = readingRoom.ReadersList.ToList();
            cmbHats.DataSource = Hat.HatNames;
            cmbMagazineColors.DataSource = MagazineColors.ColorNames;
            lblBothCount.Text = Convert.ToString(numberOfHats + numberOfMagazins);
            
        }

        private void lstReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reader reader = lstReaders.SelectedItem as Reader;
            lblAge.Text = reader.Person.Age.ToString();
            lblMagColor.Text = reader.Magazine.Color.ToString();
            lblHat.Text = reader.ReaderHat.ToString();
        }

        private void cmbHats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hat = Hat.Hats(cmbHats.SelectedIndex);
            numberOfHats = readingRoom.NumberOfReaderByHoofdeksel(hat);
            lblHatCount.Text = Convert.ToString(numberOfHats);
            lblBothCount.Text = Convert.ToString(numberOfHats + numberOfMagazins);
        }

        private void cmbMagazineColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = MagazineColors.Colors(cmbMagazineColors.SelectedIndex);
            numberOfMagazins = readingRoom.NumberOfReaderByMagColor(color);
            lblMagazineColorCount.Text = Convert.ToString(numberOfMagazins);
            lblBothCount.Text = Convert.ToString(numberOfHats + numberOfMagazins);

        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            readingRoom.AddReader(Convert.ToInt32(txtAmount.Text));
            lstReaders.DataSource = readingRoom.ReadersList.ToList();
        }
    }
}