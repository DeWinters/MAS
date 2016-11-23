using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TransitLog
{
    class Contract
    {
        public string queryString;
        public static string connectionString = "server=localhost;port=3306;User ID=root;password=secret;Database=MASdb";
        MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlDataAdapter adptr = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rdr;

        private string Invoice;
        private string Client;
        private string Driver;
        private string Origin;
        private string Destination;
        private string Region;
        DateTime Date;
        DateTime Collection;
        DateTime Delivery;
        private string Wait;
        private string Discount;
        TimeSpan Voyage;

        
        private Boolean Weekend; // learn to pass checkbox data


        private string HourlyRate;

        public void setContract(string invoice, DateTime date, string client, string driver, string origin, string dest, string region, DateTime collection, DateTime delivery, string wait, string discount, Boolean wknd)
        {
            this.Invoice = invoice;
            this.Date = date;
            this.Client = client;
            this.Driver = driver;
            this.Origin = origin;
            this.Destination = dest;
            this.Region = region;           
            this.Collection = collection;
            this.Delivery = delivery;
            this.Wait = wait;
            this.Discount = discount;
            this.Weekend = wknd; // learn checkbox data

            this.Voyage = Delivery.Subtract(Collection);
        }


        public string getInvoice()
        {
            return Invoice;
        }

        public string getClient()
        {
            return Client;       
        }

        public string getOrigin()
        {
            return Origin;
        }

        public string getDriver()
        {
            return Driver;
        }

        public string getDestination()
        {
            return Destination;
        }

        public string getRegion()
        {
            return Region;
        }

        public string getDate()
        {
            return Date.ToString("dd / MM / yyyy");
        }

        public string getCollection()
        {
            return Collection.ToString("hh : mm");
        }

        public string getDelivery()
        {
            return Delivery.ToString("hh : mm");
        }

        public string getWait()
        {
            return Wait;
        }

        public string getDiscount()
        {
            return Discount;
        }

        public string getWeekend()
        {
            return Weekend.ToString();
        }

        public string getVoyage()
        {
            return Voyage.ToString();
        }

        public float calculateRate()
        {         
            conn.Open();
            queryString = "";
            queryString = "SELECT rate FROM myDB.MyGuests WHERE origin='" + Origin + "'&& destination='" + Destination + "'";
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryString, conn);

            HourlyRate = rdr.GetString(rdr.GetOrdinal("hourlyRate"));
            float rate = 34.5f;
            return rate;
        }

    }
}
