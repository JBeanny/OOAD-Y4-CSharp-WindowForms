namespace Products_Mangement_System
{
    public partial class CreateProductForm : Form
    {
        DataGridView _allProducts;
        private DataGridViewRowCollection rows;
        public CreateProductForm(DataGridViewRowCollection rows)
        {
            InitializeComponent();
            this.rows = rows;
            button1.Click += ClickCancelAction;
            button2.Click += ClickAddAction;
        }
        private void ClickCancelAction(object? sender, EventArgs e)
        {
            Close();
        }

        private void ClickAddAction(object? sender, EventArgs e)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = textBox1.Text });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = textBox2.Text });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = textBox3.Text });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = textBox4.Text });
            // Add more cells as needed
            rows.Add(newRow);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
