using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Main : Form
    {
        List<GraphObject> elements = new List<GraphObject>();
        public Main()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть окно ?", " предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AddFigure(object sender, EventArgs e)
        {
            elements.Add(new GraphObject());
            panel1.Invalidate();
        }

        private void ClearFigures(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void PaintPanel(object sender, PaintEventArgs e)
        {
            
            foreach (GraphObject elem in elements)
            {
                elem.Draw(e.Graphics);
            }
        }
    }
}
