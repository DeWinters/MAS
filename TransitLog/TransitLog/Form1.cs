using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TransitLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_preview_Click(object sender, EventArgs e)
        {
            
            DateTime date = Convert.ToDateTime(dtp_date.Text);
            DateTime collection = Convert.ToDateTime(dtp_collection.Text);
            DateTime delivery = Convert.ToDateTime(dtp_delivery.Text);

            Contract active = new Contract();
            active.setContract(tbx_invoice.Text, date, cbx_client.Text, cbx_driver.Text, cbx_origin.Text, cbx_destination.Text, cbx_region.Text, collection, delivery, cbx_wait.Text, tbx_discount.Text, xbx_weekend.Checked );

            lbl_invoiceOut.Text = active.getInvoice();
            lbl_outClient.Text = active.getClient();
            lbl_outOrigin.Text = active.getOrigin();
            lbl_outDriver.Text = active.getDriver();
            lbl_outDestination.Text = active.getDestination();
            lbl_outRegion.Text = active.getRegion();
            lbl_outDate.Text = active.getDate();
            lbl_outCollection.Text = active.getCollection();
            lbl_outDelivery.Text = active.getDelivery();
            lbl_outWait.Text = active.getWait();
            lbl_outDiscount.Text = active.getDiscount();
            lbl_outWeekend.Text = active.getWeekend();


            TimeSpan voyager = delivery.Subtract(collection);
            string temp = voyager.ToString();
            if (temp.Contains("-"))
            {
                //  DateTime midnight = Convert.ToDateTime("24:00:00");
                //  TimeSpan TEMPvoyager = (midnight.Subtract(collection));
                //  string help = TEMPvoyager.ToString();
                //  DateTime please = Convert.ToDateTime(help);
                // please = (please.Subtract(collection));

                lbl_voyagerOut.Text = "NAWP";
            }
            else { lbl_voyagerOut.Text = voyager.ToString(); }

           
        }
    }
}
      