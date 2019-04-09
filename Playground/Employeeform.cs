using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground
{
    public partial class Employeeform : Form
    {
        private String employeeName;

        public Employeeform(String name)
        {
            InitializeComponent();
            this.employeeName = name;
            this.nameInput.Text = employeeName;
            this.header.Text = employeeName;
        }

        private void header_Click(object sender, EventArgs e)
        {

        }


        //super z Was chłopaki <3 
        // tak że tak :) 

        private void Save_Click(object sender, EventArgs e)
        {
            employeeName = this.nameInput.Text;
            this.header.Text = employeeName;
        }

        private void Employeeform_Load(object sender, EventArgs e)
        {

        }
    }
}
