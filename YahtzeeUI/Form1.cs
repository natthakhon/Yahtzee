using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahtzeeModel;

namespace YahtzeeUI
{
    public partial class Form1 : Form
    {
        private ScoreCard scoreCard = new ScoreCard();

        public Form1()
        {
            InitializeComponent();
            this.bind();
        }

        private void bind()
        {
            this.dataGridView1.DataSource = null;
            var bindingList = new BindingList<ScoreCardItem>(this.scoreCard.Items);
            var source = new BindingSource(bindingList, null);
            this.dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roll = string.Format("{0},{1},{2},{3},{4}", this.comboBox1.Text
                , this.comboBox2.Text
                , this.comboBox3.Text
                , this.comboBox4.Text
                , this.comboBox5.Text);

            this.scoreCard.UpdateCard(roll);
            this.bind();
        }
    }
}
