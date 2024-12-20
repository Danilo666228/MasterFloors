using MasterFloor.Models.Repositories;
using MasterFloor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFloor.Forms
{
    public partial class AddPartner : Form
    {
        public AddPartner()
        {
            InitializeComponent();
        }

        private async void AddPartner_Activated(object sender, EventArgs e)
        {
            var dbPartnerType = new PartnerTypeRepository(new MasterFloorDbContext());
            var partnerTypes = await dbPartnerType.GetPartnerTypes();

            cmbPartnerType.DisplayMember = "PartnerTypeName";
            cmbPartnerType.ValueMember = "IdPartnerType";
            cmbPartnerType.DataSource = partnerTypes;
        }

        private async void btnEditPartner_Click(object sender, EventArgs e)
        {
            var dbPartner = new PartnerRepository(new MasterFloorDbContext());
             await dbPartner.AddPartner(txbPartnerName.Text, txbPartnerPhone.Text, "123", txbPartnerDirector.Text, (int)cmbPartnerType.SelectedValue,txbEmail.Text,txbTaxpayeer.Text,(int)numericPartnerRating.Value);
            
        }

        private void AddPartner_Load(object sender, EventArgs e)
        {

        }
    }
}
