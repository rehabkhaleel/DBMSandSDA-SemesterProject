using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DBMSProject
{
    class Health : Cost
    {

        public override void ProcessRequest(CostCalculation cost, int _uid)
        {
            SqlConnection con = new SqlConnection(@"Data Source=REHAB\SQLEXPRESS;Initial Catalog=Insurance;Integrated Security=True;Encrypt=False");
            if (cost.policyName.ToLower() == "health")
            {
                con.Open();
                int sumAssure = 200000;
                int premiumAmount = 10000;
                SqlCommand cmd3 = new SqlCommand("exec Policy_Activation " + _uid + "," + sumAssure + "," + premiumAmount, con);
                cmd3.ExecuteNonQuery();
                con.Close();
            }
            else if (cost != null)
            {
                successor.ProcessRequest(cost, _uid);
            }
        }
    }
}