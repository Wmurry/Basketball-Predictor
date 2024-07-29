using System.Data;
using System.Data.SqlClient;


namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-1IJP7QH2\\SQLEXPRESS;Initial Catalog=willdb;Integrated Security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sc = new SqlCommand("Select (Team_Name) from Basketball_Teams", conn);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        BasecomboBox.Items.Add(reader.GetString(i));
                    }
                }
                conn.Close();
            }
            catch
            {

            }
        }


        public int combobox_search(ComboBox combo, string str)
        {
            for (int i = 0; combo.Items.Count > 0; i++)
            {
                if (combo.Items[i].ToString() == str.Trim())
                {
                    return i;
                }
            }
            return -2;
        }

        public int timesearch(int str)
        {
            return str - 1;
        }

        private void BasecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sc = new SqlCommand($"Select (Team_Name),City,Coach,Timezone,PG,SG,SF,PF,C,Momentum from Basketball_Teams Where (Team_Name) = '{BasecomboBox.Text}'", conn);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                while (reader.Read())
                {
                    TeamtextBox.Text = reader.GetString(0);
                    CitytextBox.Text = reader.GetString(1);
                    CoachcomboBox.SelectedIndex = combobox_search(CoachcomboBox, reader.GetString(2));
                    TimezonecomboBox.SelectedIndex = timesearch((int)reader.GetValue(3));
                    PGcomboBox.SelectedIndex = combobox_search(PGcomboBox, reader.GetString(4));
                    SGcomboBox.SelectedIndex = combobox_search(SGcomboBox, reader.GetString(5));
                    SFcomboBox.SelectedIndex = combobox_search(SFcomboBox, reader.GetString(6));
                    PFcomboBox.SelectedIndex = combobox_search(PFcomboBox, reader.GetString(7));
                    CcomboBox.SelectedIndex = combobox_search(CcomboBox, reader.GetString(8));
                    MomcomboBox.SelectedIndex = combobox_search(MomcomboBox, reader.GetString(9));
                }
                TeamtextBox.Enabled = true;
                CitytextBox.Enabled = true;
                CoachcomboBox.Enabled = true;
                TimezonecomboBox.Enabled = true;
                PGcomboBox.Enabled = true;
                SGcomboBox.Enabled = true;
                SFcomboBox.Enabled = true;
                PFcomboBox.Enabled = true;
                CcomboBox.Enabled = true;
                MomcomboBox.Enabled = true;
                button1.Visible = true;
                conn.Close();
            }
            catch
            {

            }
        }


        bool pre_editor()
        {
            if ((TeamtextBox.Text == "") || (TeamtextBox.Text == null))
            {
                string box_msg = "The team must have a name";
                string box_title = "Error";
                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                return false;
            }
            if ((CitytextBox.Text == "") || (CitytextBox.Text == null))
            {
                string box_msg = "The team must have a city";
                string box_title = "Error";
                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void editor()
        {
            string command = $"UPDATE Basketball_Teams " +
                $"SET Team_Name = '{TeamtextBox.Text}'," +
                $"City = '{CitytextBox.Text}'," +
                $"Timezone = {TimezonecomboBox.SelectedIndex + 1}," +
                $"PG = '{PGcomboBox.Text}'," +
                $"SG = '{SGcomboBox.Text}'," +
                $"SF = '{SFcomboBox.Text}'," +
                $"PF = '{PFcomboBox.Text}'," +
                $"C = '{CcomboBox.Text}'," +
                $"Momentum = '{MomcomboBox.Text}'" +
                $"Where (Team_Name) = '{BasecomboBox.Text}'";
            try
            {
                conn.Open();
                SqlCommand sc = new SqlCommand(command, conn);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                conn.Close();
                ReadtextBox.Text = command;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pre_editor())
            {
                DialogResult d;
                string box_msg = "Do you want to save these changes";
                string box_msg2 = "The changes have been saved";
                string box_title = "Save";
                d = MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    editor();
                    MessageBox.Show(box_msg2, box_title, MessageBoxButtons.OK);
                }
            }
        }
    }
}