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
    public partial class AddPersonForm : Form
    {
        public Form1 mainForm { get; set; }
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(textBox1.Text, "yifiani");
            p1.BirthDate = dateTimePicker1.Value;
            p1.IsMarried = true;
            DbManager dbManager = new DbManager();
            dbManager.AddPerson(p1);
            
            //mainForm.people.Add(p1);
            mainForm.refresh();

            this.Close();
        }
    }
}
