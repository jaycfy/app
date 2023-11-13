using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Kimphat
{
    public partial class UC_Main_Products : UserControl
    {
        public UC_Main_Products()
        {
            InitializeComponent();
        }

        private void UC_Main_Products_A_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new(Database.con);
            MySqlCommand cmd = new(
                "SELECT " +
                    "items.attribut, " +
                    "items.upc, " +
                    "items.kp_code, " +
                    "items.brand, " +
                    "items.description, " +
                    "items.mesure, " +
                    "items.unit, " +
                    "families.name, " +
                    "users.username " +
                    "FROM items " +
                    "LEFT JOIN users on items.user_id = users.id " +
                    "LEFT JOIN families on items.family_id = families.id " +
                    "WHERE items.user_id = '" + User.UserID + "' ",
                    con);

            try
            {
                con.Open();
                MySqlDataAdapter sdr = new(cmd);
                DataTable dt = new();
                sdr.Fill(dt);
                DGV_UC_Products_A.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            con.Close();
        }

        private void LoadImage(string url, string type)
        {
            try
            {
                // Download image from URL
                WebClient webClient = new();
                byte[] data = webClient.DownloadData(url);

                // Create a MemoryStream from the downloaded data
                using MemoryStream memoryStream = new(data);

                // Create an Image from the MemoryStream
                System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);

                if (type == "Image")
                {
                    PCB_UC_Product_Image.Image = image;
                    return;
                }

                if (type == "UPC")
                {
                    PCB_UC_Product_UPC.Image = image;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'UPC : " + ex.Message);
            }
        }

        private void TXT_Search_TextChanged(object sender, EventArgs e)
        {
            UC_Search_With_Filter();
        }

        private void UC_Search_With_Filter()
        {
            string Search = TXT_Search.Text;
            MySqlConnection con = new(Database.con);

            if (CKB_UC_Products_See_Mine.Checked == true)
            {
                MySqlCommand cmd = new(
                        "SELECT " +
                            "   items.attribut, " +
                            "   items.upc, " +
                            "   items.kp_code, " +
                            "   items.brand, " +
                            "   items.description, " +
                            "   items.mesure, " +
                            "   items.unit, " +
                            "   families.name, " +
                            "   users.username " +
                            "FROM items " +
                            "LEFT JOIN users on items.user_id = users.id " +
                            "LEFT JOIN families on items.family_id = families.id " +
                            "WHERE " +
                            "user_id = '" + User.UserID + "' " +
                            "AND " +
                            "(items.upc LIKE '" + Search + "%' " +
                            "OR " +
                            "kp_code LIKE '" + Search + "%' " +
                            "OR " +
                            "items.brand LIKE '%" + Search + "%' " +
                            "OR " +
                            "description LIKE '%" + Search + "%' " +
                            "OR " +
                            "family_id = '" + Search + "' )",
                            con);

                try
                {
                    con.Open();
                    MySqlDataAdapter sdr = new(cmd);
                    DataTable dt = new();
                    sdr.Fill(dt);
                    DGV_UC_Products_A.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                con.Close();
            }
            else
            {
                MySqlCommand cmd = new(
                "SELECT " +
                    "   items.attribut, " +
                    "   items.upc, " +
                    "   items.kp_code, " +
                    "   items.brand, " +
                    "   items.description, " +
                    "   items.mesure, " +
                    "   items.unit, " +
                    "   families.name, " +
                    "   users.username " +
                    "FROM items " +
                    "LEFT JOIN users on items.user_id = users.id " +
                    "LEFT JOIN families on items.family_id = families.id " +
                    "WHERE " +
                    "items.upc LIKE '" + Search + "%' " +
                    "OR " +
                    "kp_code LIKE '" + Search + "%' " +
                    "OR " +
                    "items.brand LIKE '%" + Search + "%' " +
                    "OR " +
                    "description LIKE '%" + Search + "%' " +
                    "OR " +
                    "family_id = '" + Search + "' " +
                    "OR " +
                    "users.username = '" + Search + "'",
                    con);

                try
                {
                    con.Open();
                    MySqlDataAdapter sdr = new(cmd);
                    DataTable dt = new();
                    sdr.Fill(dt);
                    DGV_UC_Products_A.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                con.Close();
            }
        }

        private void CKB_UC_Products_See_Mine_CheckedChanged(object sender, EventArgs e)
        {
            if (CKB_UC_Products_See_Mine.Checked == true)
            {
                if (TXT_Search.Text == null)
                {
                    MySqlConnection con = new(Database.con);
                    MySqlCommand cmd = new(
                        "SELECT " +
                            "   items.attribut, " +
                            "   items.upc, " +
                            "   items.kp_code, " +
                            "   items.brand, " +
                            "   items.description, " +
                            "   items.mesure, " +
                            "   items.unit, " +
                            "   families.name, " +
                            "   users.username " +
                            "FROM items " +
                            "LEFT JOIN users on items.user_id = users.id " +
                            "LEFT JOIN families on items.family_id = families.id " +
                            "WHERE items.user_id = '" + User.UserID + "' ",
                            con);

                    try
                    {
                        con.Open();
                        MySqlDataAdapter sdr = new(cmd);
                        DataTable dt = new();
                        sdr.Fill(dt);
                        DGV_UC_Products_A.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                    con.Close();
                }
                else
                {
                    string Search = TXT_Search.Text;
                    MySqlConnection con = new(Database.con);
                    MySqlCommand cmd = new(
                        "SELECT " +
                            "   items.attribut, " +
                            "   items.upc, " +
                            "   items.kp_code, " +
                            "   items.brand, " +
                            "   items.description, " +
                            "   items.mesure, " +
                            "   items.unit, " +
                            "   families.name, " +
                            "   users.username " +
                            "FROM items " +
                            "LEFT JOIN users on items.user_id = users.id " +
                            "LEFT JOIN families on items.family_id = families.id " +
                            "WHERE " +
                            "user_id = '" + User.UserID + "' " +
                            "AND " +
                            "(items.upc LIKE '" + Search + "%' " +
                            "OR " +
                            "kp_code LIKE '" + Search + "%' " +
                            "OR " +
                            "items.brand LIKE '%" + Search + "%' " +
                            "OR " +
                            "description LIKE '%" + Search + "%' " +
                            "OR " +
                            "family_id = '" + Search + "' )",
                            con);

                    try
                    {
                        con.Open();
                        MySqlDataAdapter sdr = new(cmd);
                        DataTable dt = new();
                        sdr.Fill(dt);
                        DGV_UC_Products_A.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                    con.Close();
                }
            }
            else
            {
                UC_Search_With_Filter();
            }
        }
    }
}
