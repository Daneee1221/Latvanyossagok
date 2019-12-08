using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        private bool click = false;
        private bool mod = false;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Port=; Database=latvany; Uid=root; Pwd=;");
            conn.Open();

            VarosListazas();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void VarosListazas()
        {
            listBoxVaros.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT id, nev, lakossag
                                FROM varosok
                                ORDER BY id";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    var varos = new Varos(id, nev, lakossag);
                    listBoxVaros.Items.Add(varos);
                }
            }
        }

        void LatvanyossagListazas()
        {
                listBoxLatvanyossag.Items.Clear();
                var varos = (Varos)listBoxVaros.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT id, nev, leiras, ar, varos_id
                                FROM latvanyossagok
                                WHERE varos_id = @id";
                cmd.Parameters.AddWithValue("@id", varos.Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("id");
                        var nev = reader.GetString("nev");
                        var leiras = reader.GetString("leiras");
                        var ar = reader.GetInt32("ar");
                        var ar2= "Ingyenes";
                        if (ar.Equals("0"))
                        {
                            ar2=ar.ToString();
                        
                        }
                        var varos_id = reader.GetInt32("varos_id");
                        var latvanyossag = new Latvanyossag(id, nev, leiras, ar, varos_id);
                        listBoxLatvanyossag.Items.Add(latvanyossag);
                    }
                }
            
        }

        private void buttonVarosHozzaad_Click(object sender, EventArgs e)
        {
            int igaz=0;
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxVarosNev.Text, "^[a-zA-Z ]" )|| string.IsNullOrEmpty(textBoxLakossag.Text) || textBoxLakossag.Text == "0" || string.IsNullOrEmpty(textBoxVarosNev.Text) || !int.TryParse(textBoxLakossag.Text, out igaz))
            {
                MessageBox.Show("Hibás adatokat adott meg");
                textBoxLakossag.Clear();
                textBoxVarosNev.Clear();
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO varosok (nev, lakossag)
                                VALUES (@nev, @lakossag)";
                cmd.Parameters.AddWithValue("@nev", textBoxVarosNev.Text);
                cmd.Parameters.AddWithValue("@lakossag", textBoxLakossag.Text);

                cmd.ExecuteNonQuery();
                VarosListazas();
            }
        }

        private void buttonLatvanyossagHozzaad_Click(object sender, EventArgs e)
        {
            int igaz;
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxLeiras.Text, "^[a-zA-Z ]") || !System.Text.RegularExpressions.Regex.IsMatch(textBoxLatvanyossagNev.Text, "^[a-zA-Z ]") || string.IsNullOrEmpty(textBoxLatvanyossagNev.Text) || textBoxLeiras.Text == "0" || string.IsNullOrEmpty(textBoxAr.Text) || !int.TryParse(textBoxAr.Text, out igaz))
            {
                MessageBox.Show("Hibás adatokat adott meg");
                textBoxLeiras.Clear();
                textBoxLatvanyossagNev.Clear();
                textBoxAr.Clear();
            }
            var varos = (Varos)listBoxVaros.SelectedItem;
            var id = varos.Id;
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO latvanyossagok (nev, leiras, ar, varos_id)
                                VALUES (@nev, @leiras, @ar, @varos_id)";
            cmd.Parameters.AddWithValue("@nev", textBoxLatvanyossagNev.Text);
            cmd.Parameters.AddWithValue("@leiras", textBoxLeiras.Text);
            cmd.Parameters.AddWithValue("@ar", textBoxAr.Text);
            cmd.Parameters.AddWithValue("@varos_id", id);
            
            cmd.ExecuteNonQuery();
            LatvanyossagListazas();
        }

        private void buttonVarosTorles_Click(object sender, EventArgs e)
        {
            if (listBoxVaros.SelectedIndex == -1 || listBoxVaros.Items.Count == 0)
            {
                MessageBox.Show("Üres a lista vagy nincs kijelölve item");
            }
            else
            {
                var varos = (Varos)listBoxVaros.SelectedItem;
                    var id = varos.Id;
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM latvanyossagok WHERE varos_id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    var cmdDelete = conn.CreateCommand();
                    cmdDelete.CommandText = "DELETE FROM varosok WHERE id = @id";
                    cmdDelete.Parameters.AddWithValue("@id", id);
                    cmdDelete.ExecuteNonQuery();
                    VarosListazas();
                
            }
        }

        private void buttonLatvanyossagTorles_Click(object sender, EventArgs e)
        {
            if (listBoxLatvanyossag.SelectedIndex == -1 || listBoxLatvanyossag.Items.Count == 0)
            {
                MessageBox.Show("Üres a lista vagy nincs kijelölve item");
            }
            else
            {
                var latvanyossag = (Latvanyossag)listBoxLatvanyossag.SelectedItem;
                var id = latvanyossag.Id;
                var cmdDelete = conn.CreateCommand();
                cmdDelete.CommandText = "DELETE FROM latvanyossagok WHERE id = @id";
                cmdDelete.Parameters.AddWithValue("@id", id);
                cmdDelete.ExecuteNonQuery();
                LatvanyossagListazas();
            }
        }

        private void listBoxVaros_SelectedIndexChanged(object sender, EventArgs e)
        {
            LatvanyossagListazas();
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            if (mod == false)
            {
                click = true;
                if (click == true)
                {
                    var varos = (Varos)listBoxVaros.SelectedItem;
                    btnModositas.Text = "Megerősítés";
                    textBoxVarosNev.Text = varos.Nev;
                    textBoxLakossag.Text = varos.Lakossag.ToString();
                    mod = true;
                    click = false;
                }
            }
            else
            {
                    if (mod==true)
                    {
                        var varos = (Varos)listBoxVaros.SelectedItem;
                        var id = varos.Id;
                        var cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE varosok SET nev=@nev,lakossag=@lakossag WHERE id=@id";
                        cmd.Parameters.AddWithValue("@nev", textBoxVarosNev.Text);
                        cmd.Parameters.AddWithValue("@lakossag", textBoxLakossag.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        btnModositas.Text = "Módosítás";
                        textBoxLakossag.Clear();
                        textBoxVarosNev.Clear();
                        VarosListazas();
                        mod = false;
                    }
                
            }
        }

        private void btnModositas2_Click(object sender, EventArgs e)
        {
            if (mod ==false)
            {
                click = true;
                if (click == true)
                {
                    btnModositas2.Text = "Megerősítés";
                    var latvanyossag = (Latvanyossag)listBoxLatvanyossag.SelectedItem;
                    textBoxLatvanyossagNev.Text = latvanyossag.Nev;
                    textBoxLeiras.Text = latvanyossag.Leiras;
                    textBoxAr.Text = latvanyossag.Ar.ToString();
                    mod = true;
                    click = false;
                }
            }
            else
            {
                if (mod == true)
                {
                    var latvanyossag = (Latvanyossag)listBoxLatvanyossag.SelectedItem;
                    var id = latvanyossag.Id;
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE latvanyossagok SET nev=@nev,leiras=@leiras,ar=@ar WHERE id=@id";
                    cmd.Parameters.AddWithValue("@nev", textBoxLatvanyossagNev.Text);
                    cmd.Parameters.AddWithValue("@leiras", textBoxLeiras.Text);
                    cmd.Parameters.AddWithValue("@ar", textBoxAr.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    btnModositas2.Text = "Módosítás";
                    textBoxLatvanyossagNev.Clear();
                    textBoxLeiras.Clear();
                    textBoxAr.Clear();
                    LatvanyossagListazas();
                    mod = false;
                }

            }
        }
    }
}
