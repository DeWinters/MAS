using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TransitLog
{
    public class MASresources
    {
        public string queryString;
        public static string connectionString = "server=localhost;port=3306;User ID=root;password=secret;Database=MASdb";
        MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlDataAdapter adptr = new MySqlDataAdapter();

        private float hourlyRate;
        private float vat;
        private string invoice;
        private string client;
        private string origin;
        private string destination;
        private string region;
        private int colHour;
        private int colMin;
        private int delHour;
        private int delmin;

        MASresources contract = new MASresources();

        MASresources(string invoice, string client, string origin, string destination, string region, int colHour, int colMin,
                    int delHour, int delMin)
        {
            MASresources contract = new MASresources();

            conn.Open();
        }
        MASresources() { }



        public string preview(string invoice, string client, string origin, string destination, string region, string colHour, string colMin,
                    string delHour, string delMin)
        {
           // int tempCH = Int32.Parse(colHour);
           // int tempCM = Int32.Parse(colMin);
           // int tempDH = Int32.Parse(delHour);
           // int tempDM = Int32.Parse(delMin);

            this.invoice = invoice;
            this.invoice = invoice;
            this.client = client;
            this.origin = origin;
            this.destination = destination;
            this.region = region;
          //  this.colHour = tempCH;
         //   this.colMin = tempCM;
         //   this.delHour = tempDH;
         //   this.delmin = tempDM;


            return "success";
        }

        public static float calculateRate(string origin, string destination)
        {

            //more to come
            return 12.5f;  
        }




        public void addContract()
        {
            queryString = "";
           // queryString = "INSERT INTO MASdb.Region (regionName, regionCode, regionNation) VALUES('" + tbx_addRegionName.Text + "','" + tbx_addRegionCode.Text + "','" + tbx_addRegionNation.Text + "')";
            MySqlCommand cmd = new MySqlCommand(queryString, conn);
            cmd = new MySqlCommand(queryString, conn);
            cmd.ExecuteReader();
        }

        

    }
}
