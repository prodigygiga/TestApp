using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Db;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= GetPeopleFromDb();
        }

        private void InitializeData()
        {
            Person p1 = new Person("luka", "grigalashvili");
            //p1.FirstName = "luka";
            //p1.LastName = "grigalashvili";
            p1.PrivateNumber = "57001050825";
            p1.IsMarried = false;
            p1.BirthDate = new DateTime(2003, 7, 22);
            p1.Height = 1.8m;

            Person p2 = new Person("rati", "yifiani");
            p2.PrivateNumber = "4564564565";
            p2.IsMarried = true;
            p2.BirthDate = new DateTime(2001, 7, 22);
            p2.Height = 1.8m;


        }


        private List<Person> GetPeopleFromDb()
        {
            DbManager dbManager = new DbManager();
            return dbManager.GetAllPersons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPersonForm form = new AddPersonForm();
            form.mainForm= this;
            form.ShowDialog();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= GetPeopleFromDb();
        }
    }
}
