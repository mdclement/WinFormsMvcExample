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
    public partial class ListDisplayForm : Form
    {
        public ListDisplayForm()
        {
            InitializeComponent();
        }

        public void ModelChanged(string todoList)
        {
            textBox1.Text = todoList;
        }
    }
}
