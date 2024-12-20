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
    public partial class HistorySales : Form
    {
        private int _partnerId;
        public HistorySales(int partnerId)
        {
            InitializeComponent();
            _partnerId = partnerId;
            
        }

        private async void HistorySales_Activated(object sender, EventArgs e)

        {
            var dbHistory = new HistorySalesRepository(new MasterFloorDbContext());
            var history = await dbHistory.GetHistorySaleByPartner(_partnerId);
            dataGridView1.DataSource = history.Select(c=> new
            {
                c.PartnerId,
                c.ProductName,
                c.Quantity,
                c.DateSales,
            }).ToList();
        }
    }
}
