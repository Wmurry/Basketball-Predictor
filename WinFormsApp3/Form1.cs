using System.Data;
using System.Data.SqlClient;


namespace WinFormsApp3
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
                        comboBox1.Items.Add(reader.GetString(i));
                        comboBox2.Items.Add(reader.GetString(i));
                    }
                }
                conn.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int error = 0;

            if ((comboBox1.Text == null) || (comboBox1.Text == ""))
            {
                MessageBox.Show("You need to pick a away team");
                error = 1;
            }
            if ((comboBox2.Text == null) || (comboBox2.Text == ""))
            {
                MessageBox.Show("You need to pick a home team");
                error = 2;
            }
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("A team cannot face themselves");
                error = 3;
            }
            if (error == 0)
            {
                works();
            }
        }

        private void works()
        {
            Team Away = new Team();
            Team Home = new Team();

            Away.GetDataFromDatabase(comboBox1.Text);
            Home.GetDataFromDatabase(comboBox2.Text);

            Away.get_numbers();
            Home.get_numbers();

            if (checkBox1.Checked == false)
            {
                Away.Away_Travel(Math.Abs(Home.TimeZone - Away.TimeZone));
            }
            else
            {
                Away.Away_Travel(-1);
            }

            Away.getvalue();
            Home.getvalue();


            if (Away.Value > Home.Value)
            {
                MessageBox.Show($"{comboBox1.Text} Wins");
            }
            if (Away.Value < Home.Value)
            {
                MessageBox.Show($"{comboBox2.Text} Wins");
            }
            if (Away.Value == Home.Value)
            {
                MessageBox.Show("Tie Game");
            }
        }
    }
}