using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajandekadatbazis
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;


        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection("Server = localhost;" +
                "Database = ajandek;" +
                "Uid = root;" +
                "Pwd = ;");
            conn.Open();

            this.FormClosed += (sender, args) =>
            {
                if (conn !=null)
                {
                    conn.Close();
                }
            };

            AdatBetoltes();
        }

        private void AdatBetoltes()
        {
            string sql = @"
                SELECT id, nev, uzlet
                FROM ajandek
                ORDER BY nev
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string uzlet = reader.GetString("uzlet");
                    Ajandek ajandek = new Ajandek(id, nev, uzlet);
                    listBox1.Items.Add(ajandek);
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbx_id.Text);
            string nev = txtbx_nev.Text;
            string uzlet = txtbx_uzlet.Text;
            
            var insertComm = conn.CreateCommand();
            insertComm.CommandText = @"
                            INSERT INTO ajandek (nev,uzlet)
                            VALUES(@nev,@uzlet)
                        ";
            insertComm.Parameters.AddWithValue("@nev", nev);
            insertComm.Parameters.AddWithValue("@uzlet", uzlet);
            insertComm.ExecuteNonQuery();
            Ajandek ajandek = new Ajandek(id, nev, uzlet);
            listBox1.Items.Add(ajandek);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labalreset();
            Ajandek a = (Ajandek)listBox1.SelectedItem;
            int tboxbaid = a.Id;
            txbx_id.Text = Convert.ToString(tboxbaid);
            string tboxbanev = a.Nev;
            txtbx_nev.Text = tboxbanev;
            string tboxbauzlet = a.Uzlet;
            txtbx_uzlet.Text = tboxbauzlet;

            lbl_idreszlet.Text += " "+tboxbaid;
            lbl_nevreszlet.Text += " " + tboxbanev;
            lbl_uzletreszlet.Text += " " + tboxbauzlet;
        }

        private void labalreset()
        {
            lbl_idreszlet.Text = "ID:";
            lbl_nevreszlet.Text = "Név:";
            lbl_uzletreszlet.Text = " Üzlet:";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>-1)
            {
                Ajandek a = (Ajandek)listBox1.SelectedItem;
                int id = a.Id;
                var deleteComm = conn.CreateCommand();
                deleteComm.CommandText = @"
                            DELETE FROM ajandek
                            WHERE id=@id
                        ";
                deleteComm.Parameters.AddWithValue("@id", id);
                deleteComm.ExecuteNonQuery();
                listaupdate();
            }
            else
            {
                MessageBox.Show("Nincs adat kiválasztva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaupdate()
        {
            listBox1.Items.Clear();
            AdatBetoltes();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Ajandek a = (Ajandek)listBox1.SelectedItem;
                int id = a.Id;
                string nev = txtbx_nev.Text;
                string uzlet = txtbx_uzlet.Text;
                var updateComm = conn.CreateCommand();
                updateComm.CommandText = @"
                            UPDATE ajandek SET nev=@nev, uzlet=@uzlet
                            WHERE id=@id
                        ";
                updateComm.Parameters.AddWithValue("@id", id);
                updateComm.Parameters.AddWithValue("@nev", nev);
                updateComm.Parameters.AddWithValue("@uzlet", uzlet);
                updateComm.ExecuteNonQuery();
                listaupdate();
            }
            else
            {
                MessageBox.Show("Nincs adat kiválasztva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
