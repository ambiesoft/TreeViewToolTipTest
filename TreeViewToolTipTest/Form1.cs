using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewToolTipTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

            string longtext = "";
            for (int i = 0; i < 1000; ++i)
                longtext += "1111111111111111111111111111111";

            // Showing the tooltip of this node makes freeze
            treeView1.Nodes.Add(
                longtext
                );

            string longtextwithspace = "";
            for (int i = 0; i < 1000; ++i)
                longtextwithspace += "1111111111111111111111111111111 ";

            treeView1.Nodes.Add(
                longtextwithspace
                );

            treeView1.Nodes.Add("aaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
            treeView1.Nodes.Add("cccccccccccccccccccccccccccccccccc");
        }
    }
}
