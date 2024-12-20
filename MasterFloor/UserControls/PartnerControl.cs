using MasterFloor.Forms;
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

namespace MasterFloor.UserControlls
{
    public partial class PartnerControl : UserControl
    {
        private Partner _partner;
        public PartnerControl()
        {
            InitializeComponent();
        }

        public async void DisplayInfo(Partner partner)
        {
            var dbHistorySales = new HistorySalesRepository(new MasterFloorDbContext());
            int discount = 0; 



            var result = await dbHistorySales.GetQuantitySales(partner.IdPartner);
            

            if(result.Sum() > 50000)
            {
                discount = 50;
            }
            


            _partner = partner;
            lblPartnetType.Text = partner.PartnerType.PartnerTypeName;
            lblPartnerName.Text = partner.PartnerName.ToString();
            lblPartnerDirector.Text = partner.DirectorName.ToString();
            lblPartnerPhone.Text = partner.PartnerPhone.ToString();
            lblRating.Text = partner.PartnerRating.ToString();
            lblPartnerDiscount.Text = discount.ToString();
        }

        private void btnHistorySales_Click(object sender, EventArgs e)
        {
            var historyForm = new HistorySales(_partner.IdPartner);
            historyForm.Show();
        }

        private void panelControl_Click(object sender, EventArgs e)
        {
            var editForm = new EditPartner(lblPartnerName.Text,lblPartnerDirector.Text,lblPartnerPhone.Text,lblRating.Text,_partner.IdPartner);
            editForm.Show();
        }
    }
}
