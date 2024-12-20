using MasterFloor.Models;
using MasterFloor.Models.Repositories;
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
    public partial class EditPartner : Form
    {
        private int _partnerId;
        public EditPartner(string partnerName,string partnerDirector,string partnerPhone,string partnerRating,int partnerId)
        {
            InitializeComponent();
            _partnerId = partnerId;
            txbPartnerName.Text = partnerName;
            txbPartnerDirector.Text = partnerDirector;
            txbPartnerPhone.Text = partnerPhone;
            numericPartnerRating.Value = int.Parse(partnerRating);
        }

        private async void EditPartner_Activated(object sender, EventArgs e)
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
           var response =  await dbPartner.EditPartner(_partnerId,txbPartnerName.Text,txbPartnerPhone.Text,"123",txbPartnerDirector.Text,(int)cmbPartnerType.SelectedValue);
            if (response == true)
            {
                MessageBox.Show("Партнет отредактирован");
                this.Close();
            }
            
        }

        private void EditPartner_Load(object sender, EventArgs e)
        {

        }
    }
}
