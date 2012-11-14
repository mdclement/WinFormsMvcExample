using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcPattern
{
    public partial class AddToListForm : Form
    {
        private readonly IListController controller;

        public AddToListForm(IListController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Add(textBox1.Text);
            textBox1.Clear();
        }
    }
}
