namespace Products_Mangement_System
{
    public partial class MainProductManagementForm : Form
    {
        public MainProductManagementForm()
        {
            InitializeComponent();
            button1.Click += ClickAddAction;
        }
        private void ClickAddAction(object? sender, EventArgs e)
        {
            new CreateProductForm(dataGridView1.Rows).Show();
        }
    }

}
