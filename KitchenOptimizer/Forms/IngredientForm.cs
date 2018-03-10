using KitchenOptimizer.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KitchenOptimizer.Forms
{
    public partial class IngredientForm : Form
    {
        SQLiteConnection connection = new SQLiteConnection();
        DataTable dataTable = new DataTable();
        SQLiteDataAdapter adapter;
        BindingSource bs = new BindingSource();
        SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder();

        public IngredientForm()
        {
            InitializeComponent();
            connection = new SQLiteConnection("Data Source=C:\\Users\\Public\\KitchenOpData\\data.sqlite;Version=3;");
            connection.Open();
            this.FormClosing += IngredientForm_FormClosing;
        }

        private void IngredientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow dr = dataTable.NewRow();
            dataTable.Rows.Add(dr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTable(true);
        }

        private void UpdateTable(bool popup)
        {
            dataGridView1.EndEdit();

            string queriesToRun = "";
            DataTable dt = dataGridView1.DataSource as DataTable;
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                if (dt.Rows[x].RowState == DataRowState.Added)
                {
                    DataRow dr = dt.Rows[x];
                    queriesToRun += String.Format(Queries.INSERT_INGREDIENT, dr[1], dr[2], dr[3]);
                }
                else if (dt.Rows[x].RowState == DataRowState.Modified)
                {
                    DataRow dr = dt.Rows[x];
                    queriesToRun += String.Format(Queries.UPDATE_INGREDIENT, dr[0], dr[1], dr[2], dr[3]);
                }
                else if (dt.Rows[x].RowState == DataRowState.Deleted)
                {
                    DataRow dr = dt.Rows[x];
                    queriesToRun += String.Format(Queries.DELETE_INGREDIENT, dr[0, DataRowVersion.Original]);
                }
            }

            Console.WriteLine(queriesToRun);
            SQLiteCommand command = new SQLiteCommand(queriesToRun, connection);

            int rowsChangedCount = 0;
            rowsChangedCount = command.ExecuteNonQuery();
            if(popup && rowsChangedCount > -1)
                MessageBox.Show(rowsChangedCount + " rows updated");
        }

        private void IngredientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.IngredientCategory' table. You can move, or remove it, as needed.
            this.ingredientCategoryTableAdapter.Fill(this.dataDataSet.IngredientCategory);
            SQLiteDataAdapter adapter;
            string query = Queries.INGREDIENT_FORM;
            SQLiteCommand command = new SQLiteCommand(query, connection);
            adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTable(false);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow dr = dataTable.NewRow();
            dr["IngredientName"] = textBox2.Text;
            dr["IngredientCost"] = textBox1.Text;
            dr["IngredientCategory"] = comboBox1.Text;
            dataTable.Rows.Add(dr);
            
        }
    }
}
