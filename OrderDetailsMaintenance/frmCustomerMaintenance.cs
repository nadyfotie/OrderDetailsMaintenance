using OrderDetailsMaintenance.Models.DataLayer;

namespace OrderDetailsMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {

       // Nady Fotie 
        private NorthwindContext _context;
        // Nady Fotie
        private Customer _customer;
       // Nady Fotie 
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }
        // Nady Fotie 
        private void btnFind_Click(object sender, EventArgs e)
        {
            _context = new NorthwindContext();
            _customer = _context.Customers.Find(txtCustomerId.Text);

            if (_customer != null)
            {
                txtContact.Text = _customer.ContactName;
                txtAddress.Text = _customer.Address;
                txtCity.Text = _customer.City;
                txtCountry.Text = _customer.Country;

            }
            else
            {
                MessageBox.Show("Customer not found.");
            }

        }
        // Nady Fotie 
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (_customer == null)
            {
                MessageBox.Show("The customer is not there.");
                return;
            }


            _customer.ContactName = txtContact.Text;
            _customer.Address = txtAddress.Text;
            _customer.City = txtCity.Text;
            _customer.Country = txtCountry.Text;

            _context.Customers.Update(_customer);
            _context.SaveChanges();

            MessageBox.Show("Customer was saved.");
           
            

        }


        // Nady Fotie 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}