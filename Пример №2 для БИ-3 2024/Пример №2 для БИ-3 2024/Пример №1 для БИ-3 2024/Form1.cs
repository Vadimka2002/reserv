
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Пример__1_для_БИ_3_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            get_type();
            get_type1();
            get_type2();
        }

        void get_type()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                        "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `справочник`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "nameDolsh";
            comboBox1.ValueMember = "idDolshnost";            
            
            DataTable dataTable1 = new DataTable();
            mySqlDataAdapter.Fill(dataTable1);
            comboBox2.DataSource = dataTable1;
            comboBox2.DisplayMember = "NameOtdel";
            comboBox2.ValueMember = "idOtdel";

            

        }
        void get_type1()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                        "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `список работающих`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            comboBox3.DataSource = dataTable;
            comboBox3.DisplayMember = "FIO";
            comboBox3.ValueMember = "ID people";
        }
        void get_type2()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                        "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `tabel time`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            comboBox4.DataSource = dataTable;
            comboBox4.DisplayMember = "ID worker";
            comboBox4.ValueMember = "id worker";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; " +
                "sslmode=none;";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "SELECT * FROM `people`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, mySqlConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            mySqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            get_data();
        }

        void get_data()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; " +
                    "sslmode=none;";
            String sqlQuery = "SELECT * FROM `people`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        void get_data2()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; " +
                    "sslmode=none;";
            String sqlQuery = "SELECT * FROM `отдел`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }
        void get_data3()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; " +
                    "sslmode=none;";
            String sqlQuery = "SELECT * FROM `должности`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }
        void get_data4()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; " +
                    "sslmode=none;";
            String sqlQuery = "SELECT * FROM `справочник`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView4.DataSource = dataTable;
        }
        void get_data5()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; " +
                    "sslmode=none;";
            String sqlQuery = "SELECT * FROM `список работающих`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView5.DataSource = dataTable;
        }
        void get_data6()
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; " +
                    "sslmode=none;";
            String sqlQuery = "SELECT * FROM `tabel time`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView6.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "INSERT INTO `people` " +
                " (`id people`, `FIO`, `Year`,`phone`," +
                " `Home`) " +
                " VALUES " +
                $"( '{textBox1.Text}', " +
                $" '{textBox2.Text}', " +
            // $"'{textBox3.Text}', " +
            //   $"'{textBox5.Text}', " +
            //$" '{comboBox1.SelectedValue}'," +
            //$" '{numericUpDown1.Value.ToString().Replace(",", ".")}', " +
            //$"'{numericUpDown2.Value}', " +
            //$" {checkBox1.Checked}, " +
            $" '{dateTimePicker1.Value.ToString("yyyy.MM.dd")}'," +
            $" '{textBox3.Text}', " +
            $" '{textBox5.Text}'  ); ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успех!");
                get_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `people`" +
                $"WHERE `FIO` LIKE '%{textBox7.Text}%' OR" +
                $" `Home` LIKE '%{textBox7.Text}%' ;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            foreach (DataGridViewRow tmp in dataGridView1.SelectedRows)
            {
                String sqlQuery = "DELETE FROM `people` " +
                   $" WHERE `FIO`= " +
                   $" '{tmp.Cells["FIO"].Value}' ;";
                MySqlCommand mySqlCommand =
                    new MySqlCommand(sqlQuery, mySqlConnection);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Успех!");
            get_data();
            mySqlConnection.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (dataGridView1.SelectedRows.Count == 0) return;
            textBox2.Text =
                dataGridView1.SelectedRows[0].Cells["FIO"].Value.ToString();
            textBox3.Text =
                dataGridView1.SelectedRows[0].Cells["phone"].Value.ToString();
            textBox5.Text =
                dataGridView1.SelectedRows[0].Cells["Home"].Value.ToString();
            textBox1.Text =
                dataGridView1.SelectedRows[0].Cells["id people"].Value.ToString();
            //comboBox1.SelectedValue =
            //   dataGridView1.SelectedRows[0].Cells["id people"].Value;
            //numericUpDown1.Value =
            //    Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["Цена"].Value);
            //numericUpDown2.Value =
            //    Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["НаСкладе"].Value);
            // checkBox1.Checked=
            //    Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Year"].Value);
            if (dataGridView1.SelectedRows[0].Cells["Year"].Value != DBNull.Value)
                dateTimePicker1.Value =
                    Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["Year"].Value);
            else
                dateTimePicker1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            string sqlQuery = "UPDATE  `people` " +
                $" set `FIO`= '{textBox2.Text}', " +
                $"  `Year`= '{dateTimePicker1.Value.ToString("yyyy.MM.dd")}', " +
                $"  `phone`= '{textBox3.Text}', " +
                $"  `Home`= '{textBox5.Text}' " +
                $" WHERE `id people`= " +
                   $" '{textBox1.Text}' ; ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Успех!");
            get_data();
            mySqlConnection.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.RowCount == 0) return;
            if (dataGridView2.SelectedRows.Count == 0) return;
            textBox6.Text =
                dataGridView2.SelectedRows[0].Cells["IdOtdel"].Value.ToString();
            textBox8.Text =
                dataGridView2.SelectedRows[0].Cells["NameOtdel"].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; " +
                "sslmode=none;";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "SELECT * FROM `отдел`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, mySqlConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            mySqlConnection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            get_data2();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `отдел`" +
                $"WHERE `NameOtdel` LIKE '%{textBox4.Text}%' OR" +
                $" `IdOtdel` LIKE '%{textBox4.Text}%' ;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "INSERT INTO `отдел` " +
                " (`IdOtdel`, `NameOtdel`) " +
                " VALUES " +
                $"( '{textBox6.Text}', " +
                $" '{textBox8.Text}'); ";                            
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успех!");
                get_data2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            string sqlQuery = "UPDATE  `отдел` " +
                $" set `NameOtdel`= '{textBox8.Text}' " +              
                $" WHERE `IdOtdel`= " +
                   $" '{textBox6.Text}' ; ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Успех!");
            get_data2();
            mySqlConnection.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            foreach (DataGridViewRow tmp in dataGridView2.SelectedRows)
            {
                String sqlQuery = "DELETE FROM `отдел` " +
                   $" WHERE `NameOtdel`= " +
                   $" '{tmp.Cells["NameOtdel"].Value}' ;";
                MySqlCommand mySqlCommand =
                    new MySqlCommand(sqlQuery, mySqlConnection);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Успех!");
            get_data2();
            mySqlConnection.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.RowCount == 0) return;
            if (dataGridView3.SelectedRows.Count == 0) return;
            textBox11.Text =
                dataGridView3.SelectedRows[0].Cells["IdDolshnost"].Value.ToString();
            textBox9.Text =
                dataGridView3.SelectedRows[0].Cells["nameDolsh"].Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; " +
                "sslmode=none;";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "SELECT * FROM `должности`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, mySqlConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
            mySqlConnection.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            get_data3();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `должности`" +
                $"WHERE `IdDolshnost` LIKE '%{textBox12.Text}%' OR" +
                $" `nameDolsh` LIKE '%{textBox12.Text}%' ;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "INSERT INTO `должности` " +
                " (`IdDolshnost`, `nameDolsh`) " +
                " VALUES " +
                $"( '{textBox11.Text}', " +
                $" '{textBox9.Text}'); ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успех!");
                get_data3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            string sqlQuery = "UPDATE  `должности` " +
                $" set `nameDolsh`= '{textBox9.Text}' " +
                $" WHERE `IdDolshnost`= " +
                   $" '{textBox11.Text}' ; ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Успех!");
            get_data3();
            mySqlConnection.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            foreach (DataGridViewRow tmp in dataGridView3.SelectedRows)
            {
                String sqlQuery = "DELETE FROM `должности` " +
                   $" WHERE `nameDolsh`= " +
                   $" '{tmp.Cells["nameDolsh"].Value}' ;";
                MySqlCommand mySqlCommand =
                    new MySqlCommand(sqlQuery, mySqlConnection);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Успех!");
            get_data3();
            mySqlConnection.Close();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.RowCount == 0) return;
            if (dataGridView4.SelectedRows.Count == 0) return;
            textBox14.Text =
                dataGridView4.SelectedRows[0].Cells["idSpravka"].Value.ToString();
            comboBox1.SelectedValue =
               dataGridView4.SelectedRows[0].Cells["idDolshnost"].Value;
            comboBox2.SelectedValue =
               dataGridView4.SelectedRows[0].Cells["idOtdel"].Value;
            textBox13.Text =
                dataGridView4.SelectedRows[0].Cells["amountVakansii"].Value.ToString();          
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; " +
                "sslmode=none;";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "SELECT * FROM `справочник`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, mySqlConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView4.DataSource = dataTable;
            mySqlConnection.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            get_data4();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `справочник`" +
                $"WHERE `IdSpravka` LIKE '%{textBox15.Text}%' ;"; 
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView4.DataSource = dataTable;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "INSERT INTO `справочник` " +
                " (`IdSpravka`, `idDolshnost`, `idOtdel`,`amountVakansii`) " +                
                " VALUES " +
                $"( '{textBox14.Text}', " +
                $" '{comboBox1.SelectedValue}'," +
                $" '{comboBox2.SelectedValue}'," +
                $" '{textBox13.Text}'  ); ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успех!");
                get_data4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
               "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            string sqlQuery = "UPDATE  `справочник` " +
                $" set `idDolshnost`= '{comboBox1.SelectedValue}', " +               
                $"  `idOtdel`= '{comboBox2.SelectedValue}', " +
                $"  `amountVakansii`= '{textBox13.Text}' " +
                $" WHERE `idSpravka`= " +
                   $" '{textBox14.Text}' ; ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Успех!");
            get_data4();
            mySqlConnection.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            foreach (DataGridViewRow tmp in dataGridView4.SelectedRows)
            {
                String sqlQuery = "DELETE FROM `справочник` " +
                   $" WHERE `amountVakansii`= " +
                   $" '{tmp.Cells["amountVakansii"].Value}' ;";
                MySqlCommand mySqlCommand =
                    new MySqlCommand(sqlQuery, mySqlConnection);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Успех!");
            get_data4();
            mySqlConnection.Close();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.RowCount == 0) return;
            if (dataGridView5.SelectedRows.Count == 0) return;
            textBox17.Text =
                dataGridView5.SelectedRows[0].Cells["ID worker"].Value.ToString();
            textBox18.Text =
                dataGridView5.SelectedRows[0].Cells["Vakancia"].Value.ToString();
            comboBox3.SelectedValue =
               dataGridView5.SelectedRows[0].Cells["ID people"].Value;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; " +
                "sslmode=none;";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "SELECT * FROM `список работающих`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, mySqlConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView5.DataSource = dataTable;
            mySqlConnection.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            get_data5();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `список работающих`" +
                $"WHERE `id worker` LIKE '%{textBox16.Text}%' ;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView5.DataSource = dataTable;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "INSERT INTO `список работающих` " +
                " (`Id worker`, `Vakancia`, `id people`) " +
                " VALUES " +
                $"( '{textBox17.Text}', " +
                $" '{textBox18.Text}'," +               
                $" '{comboBox3.SelectedValue}'  ); ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успех!");
                get_data5();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
               "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            string sqlQuery = "UPDATE  `список работающих` " +
                $" set `Vakancia`= '{textBox18.Text}', " +
                $"  `id people`= '{comboBox3.SelectedValue}' " +                
                $" WHERE `id worker`= " +
                   $" '{textBox17.Text}' ; ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Успех!");
            get_data5();
            mySqlConnection.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            foreach (DataGridViewRow tmp in dataGridView5.SelectedRows)
            {
                String sqlQuery = "DELETE FROM `список работающих` " +
                   $" WHERE `ID worker`= " +
                   $" '{tmp.Cells["ID worker"].Value}' ;";
                MySqlCommand mySqlCommand =
                    new MySqlCommand(sqlQuery, mySqlConnection);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Успех!");
            get_data5();
            mySqlConnection.Close();
        }

        
        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (dataGridView1.SelectedRows.Count == 0) return;
            textBox19.Text =
                dataGridView6.SelectedRows[0].Cells["id tabel"].Value.ToString();
            if (dataGridView6.SelectedRows[0].Cells["date"].Value != DBNull.Value)
                dateTimePicker2.Value =
                    Convert.ToDateTime(dataGridView6.SelectedRows[0].Cells["date"].Value);
            else
                dateTimePicker1.Text = "";
            comboBox4.SelectedValue =
               dataGridView6.SelectedRows[0].Cells["id worker"].Value;
            textBox21.Text =
                dataGridView6.SelectedRows[0].Cells["Занятность"].Value.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; " +
                "sslmode=none;";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "SELECT * FROM `tabel time`;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, mySqlConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView6.DataSource = dataTable;
            mySqlConnection.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            get_data6();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                    "database=ychet; userid=Vadim; password=Vd17012002; ";
            String sqlQuery = "SELECT * FROM `tabel time`" +
                $"WHERE `id tabel` LIKE '%{textBox20.Text}%' OR" +
                $" `Занятность` LIKE '%{textBox20.Text}%' ;";
            MySqlDataAdapter mySqlDataAdapter =
                new MySqlDataAdapter(sqlQuery, connectionString);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView6.DataSource = dataTable;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            String sqlQuery = "INSERT INTO `tabel time` " +
                " (`Id tabel`, `date`, `id worker`, `Занятность`) " +
                " VALUES " +
                $"( '{textBox19.Text}', " +
                $" '{dateTimePicker2.Value.ToString("yyyy.MM.dd")}'," +
                $" '{comboBox4.SelectedValue}'," +
                $" '{textBox21.Text}'  ); ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успех!");
                get_data6();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
               "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            string sqlQuery = "UPDATE  `tabel time` " +
                $" set `date`= '{dateTimePicker2.Value.ToString("yyyy.MM.dd")}', " +
                $"  `id worker`= '{comboBox4.SelectedValue}', " +
                $"  `Занятность`= '{textBox21.Text}' " +
                $" WHERE `id tabel`= " +
                   $" '{textBox19.Text}' ; ";
            MySqlCommand mySqlCommand =
                new MySqlCommand(sqlQuery, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Успех!");
            get_data6();
            mySqlConnection.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1; port=3305; " +
                "database=ychet; userid=Vadim; password=Vd17012002; ";
            MySqlConnection mySqlConnection =
                new MySqlConnection(connectionString);
            mySqlConnection.Open();
            foreach (DataGridViewRow tmp in dataGridView6.SelectedRows)
            {
                String sqlQuery = "DELETE FROM `tabel time` " +
                   $" WHERE `ID tabel`= " +
                   $" '{tmp.Cells["ID tabel"].Value}' ;";
                MySqlCommand mySqlCommand =
                    new MySqlCommand(sqlQuery, mySqlConnection);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Успех!");
            get_data6();
            mySqlConnection.Close();
        }
    }   
}

