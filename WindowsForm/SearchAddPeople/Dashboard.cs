using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
          
        }

        private void UpdateBinding()
        {
            //refreshes the list box information
            PeopleFoundListbox.DataSource = people;
            PeopleFoundListbox.DisplayMember = "FullInfo";
        }

// get people
        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            // gets value fom the text box
            people = db.GetPeople(LastNameText.Text);
        }
        
        // add people
        
         private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            // insert value of form fields into database using insert person method in DataAccess file
            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text, phoneNumberInsText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailAddressInsText.Text = "";
            phoneNumberInsText.Text = "";
        
        
        
        }
    }
}
