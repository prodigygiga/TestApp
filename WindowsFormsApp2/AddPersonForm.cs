using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Person p1 = new Person(textBox1.Text, "");
            p1.BirthDate = dateTimePicker1.Value; 

            mainForm.people.Add(p1);
            mainForm.refresh();

            this.Close();
        }
    }
}
