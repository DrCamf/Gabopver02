using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;




namespace Gabopver02
{



    public partial class Form1 : Form
    {
        int cpr, tandlaege;

        public Form1()
        {
            InitializeComponent();

            Box_Dato.Format = DateTimePickerFormat.Custom;
            Box_Dato.CustomFormat = "dd-MM-yyyy HH:mm";

            #region
            DbConn db1 = new DbConn();
            db1.DBObO();

            Box_Klinik.ValueMember = "Klinik_ID";
            Box_Klinik.DisplayMember = "Klinik";
            Box_Klinik.DataSource = db1.DbSdIgView("SELECT Klinik FROM Klinik ");

            db1.DbObC();
            #endregion
            #region

            db1 = new DbConn();
            db1.DBObO();

            Box_Tandlaege.ValueMember = "Tandlaege_ID";
            Box_Tandlaege.DisplayMember = "Navn";
            Box_Tandlaege.DataSource = db1.DbSdIgView("SELECT Tandlaege_ID, Navn FROM Tandlaege ");

            db1.DbObC();
            #endregion

            #region
            db1.DBObO();
            SqlDataReader DbRd;
            DbRd = db1.DbReader("SELECT Postnr, Bynavn FROM Bynavn ");

            while (DbRd.Read())
            {
                string Post_By = Convert.ToString(DbRd["Postnr"]) + " " + Convert.ToString(DbRd["Bynavn"]);
                Box_Postnr.Items.Add(Post_By);
            }
            Box_Postnr.SelectedIndex = 484;
            db1.DbObC();
            #endregion
        }

        private void BtN_Ind_Click(object sender, EventArgs e)
        {
            string fNavn, mNavn, eNavn, adr, email;
            int tlf, post;
            if (string.IsNullOrWhiteSpace(Box_CPR.Text))
                MessageBox.Show("Patient oplysninger skal udfyldes");
            else
            {
                cpr = int.Parse(Box_CPR.Text);
                tlf = string.IsNullOrWhiteSpace(Box_Tlf.Text) ? 0 : int.Parse(Box_Tlf.Text);

                fNavn = Convert.ToString(Box_Fornavn.Text);
                eNavn = Convert.ToString(Box_Efternavn.Text);
                mNavn = Box_Mellemnavn.Text != null ? Convert.ToString(Box_Mellemnavn.Text) : null;
                adr = Convert.ToString(Box_Adresse.Text);
                email = Box_Email.Text != null ? Convert.ToString(Box_Email.Text) : null;
                string poste = Convert.ToString(Box_Postnr.SelectedItem);
                post = int.Parse(poste.Substring(0, 4));

                DbConn db1 = new DbConn();

                try
                {
                    db1.DBObO();

                    db1.DbSql("INSERT INTO Patient(CPR, Fornavn, Mellemnavn, Efternavn, Adresse, Postnr, Tlfnr, Email) VALUES (" + cpr + ",'" + fNavn + "','" + mNavn + "','" + eNavn + "','" + adr + "'," + post + "," + tlf + ",'" + email + "')");
                    MessageBox.Show("Patient oprettet");
                }
                catch
                {
                    MessageBox.Show("Ingen forbindelse til datanbasen !");
                }
                db1.DbObC();
            }
        }

        private void BtN_Beh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Box_Behandling.Text))
                MessageBox.Show("Du skal udfylde oplysningerne");
            else
            {
                string beBehand = Box_Behandling.Text;
                cpr = int.Parse(Box_CPR.Text);
                var dato = Convert.ToString(Box_Dato.Text);
                int beloeb = int.Parse(Box_Beloeb.Text);
                int betal = BtN_Betalt.Checked ? 1 : 0;

                DbConn db1 = new DbConn();

                int kID = Box_Klinik.SelectedIndex;
                int lID = Box_Tandlaege.SelectedIndex;

                try
                {
                    db1.DBObO();
                    string dSqlInd = "INSERT INTO Behandling(Behandling, CPR, Tabdlaege_ID, Klinik_ID, Dato, Regnings_Beloeb, Betalt) VALUES ('" + beBehand + "', " + cpr + ", " + lID + ", " + kID + ", '" + dato + "', " + beloeb + ", " + betal + ")";
                    db1.DbSqlInd(dSqlInd);
                    MessageBox.Show("behandling oprettet");

                    db1.DbObC();
                }
                catch
                {
                    MessageBox.Show("Fejl i datanbase forbindelse");
                }
            }
        }

        private void BtN_Book_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Box_CPR.Text))
                MessageBox.Show("Der skal udfyldes oplysninger");
            else
            {
                cpr = int.Parse(Box_CPR.Text);
                DataRowView drv = (DataRowView)Box_Tandlaege.SelectedItem;
                tandlaege = Convert.ToInt16(drv["Tandlaege_ID"]);
                var dato = Convert.ToString(Box_Dato.Text);

                DbConn db1 = new DbConn();

                try
                {
                    db1.DBObO();
                    db1.DbSql("INSERT INTO Booking(CPR, Tandlaege_ID,  Dato) VALUES (" + cpr + ", " + tandlaege + ",'" + dato + "')");
                    MessageBox.Show("Booking oprettet");
                }
                catch
                {
                    MessageBox.Show("Ingen forbindelse til databasen !");
                }
                db1.DbObC();
            }
        }

        private void SeOgRyd(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var box = c as TextBox;
                if (box != null)
                    box.Text = string.Empty;

                this.SeOgRyd(c);
            }
            Box_Klinik.SelectedIndex = 0;
            Box_Tandlaege.SelectedIndex = 0;
            CBox_Seek.SelectedIndex = -1;
            Box_Postnr.SelectedIndex = 484;
            BtN_Betalt.Checked = false;
            Box_Dato.Value = DateTime.Today;
        }

        private void BtN_Seek_Click(object sender, EventArgs e)
        {
            int value;

            if (string.IsNullOrWhiteSpace(CBox_Seek.Text))
                MessageBox.Show("Du skal vælge en betingelse");
            else if (CBox_Seek.Text == "CPR")
            {
                if (!int.TryParse(Box_CPR.Text, out value) || string.IsNullOrWhiteSpace(CBox_Seek.Text))
                {
                    MessageBox.Show("Nej det skal være tal i CPR");
                }
            }
            
            else
            {


                string valg = CBox_Seek.Text;
                Dictionary<string, object> valgres = new Dictionary<string, object>();
                //List<string> columnName = new List<string>();
                #region
                //columnName.Add("CPR");
                //columnName.Add("Fornavn");
                //columnName.Add("Mellemnavn");
                //columnName.Add("Efternavn");
                //columnName.Add("Adresse");
                //columnName.Add("Tlf");
                //columnName.Add("Email");

                valgres.Add("CPR", Box_CPR.Text);
                valgres.Add("Fornavn", Box_Fornavn.Text);
                valgres.Add("Efternavn", Box_Efternavn.Text);
                valgres.Add("Adresse", Box_Adresse.Text);
                valgres.Add("Tlfnr", Box_Tlf.Text);
                valgres.Add("Email", Box_Email.Text);
                valgres.Add("Tandlaege", Box_Tandlaege.SelectedIndex + 1);
                valgres.Add("Betalt", BtN_Betalt.Checked ? 1 : 0);
                #endregion


                string connectionString = @"Data Source= SDE-02364; Initial Catalog= Gabop_DATA;Integrated Security=true;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sqlDa;
                    DataTable dtbl = new DataTable();
                    DataGridTurn dataG = new DataGridTurn();

                    if (valg == "Tandlaege")
                    {
                        string valgdato = Box_Dato.Text.Substring(10);
                        sqlDa = new SqlDataAdapter("SELECT TandLaege.Navn, Booking.Dato, Patient.Fornavn, Patient.Efternavn FROM((Booking Inner JOIN Tandlaege ON Booking.Tandlaege_ID = Tandlaege.Tandlaege_ID) Inner JOIN Patient ON Booking.CPR = Patient.CPR) WHERE Booking.Tandlaege_ID = " + Convert.ToString(valgres[valg]) + " AND Booking.Dato >= '" + valgdato + "';", con);
                    }
                    else if (valg == "Betalt")
                        sqlDa = new SqlDataAdapter("SELECT CPR, Betalt FROM Behandling WHERE Betalt = " + Convert.ToString(valgres[valg]) + ";", con);
                    else
                        sqlDa = new SqlDataAdapter("SELECT CPR, Fornavn, Efternavn, Adresse, Postnr, Tlfnr, Email FROM Patient WHERE " + valg + " = '" + Convert.ToString(valgres[valg]) + "';", con);

                    sqlDa.Fill(dtbl);
                    Box_Seek_Result.DataSource = dtbl;
                }
            }








        }

        private void BtN_Lukned_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void BtN_Opdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Box_CPR.Text))
                MessageBox.Show("Du skal vælge Dato og Cpr for at opdatere betalt");
            else
            {
                cpr = int.Parse(Box_CPR.Text);
                int betal = BtN_Betalt.Checked ? 1 : 0;
                var dato = Convert.ToString(Box_Dato.Text);
                DbConn db1 = new DbConn();

                try
                {
                    db1.DBObO();

                    db1.DbSql("UPDATE Behandling SET Betalt = 1 WHERE CPR = " + cpr + " AND Dato = '" + dato + "';");
                    MessageBox.Show("Betaling opdateret");
                }
                catch
                {
                    MessageBox.Show("Ingen forbindelse til datanbasen !");
                }
                db1.DbObC();
            }
        }

        private void Message(object sender, EventArgs e) => MessageBox.Show("Dette er søge resultat felt og kan ikke skrives i");




        private void BtN_Ryd_Click(object sender, EventArgs e) => this.SeOgRyd(this);
    }
}
