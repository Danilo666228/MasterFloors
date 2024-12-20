using MasterFloor.Models.Repositories;
using MasterFloor.Models;
using MasterFloor.UserControlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterFloor.Forms;

namespace MasterFloor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
    private async void DisplayPartnerInfo()
    {
        var dbPartners = new PartnerRepository(new MasterFloorDbContext());
        var allPartners = await dbPartners.GetPartners();
        flowLayoutPanel1.Controls.Clear();

        foreach (var partner in allPartners)
        {
            var partnerInfoControl = new PartnerControl();
            partnerInfoControl.DisplayInfo(partner);
            flowLayoutPanel1.Controls.Add(partnerInfoControl);
        }
    }

        private void Main_Activated(object sender, EventArgs e)
        {
            DisplayPartnerInfo();
        }

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            new AddPartner().Show();
        }
    }
}
