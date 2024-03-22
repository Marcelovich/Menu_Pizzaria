using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class f : Form
    {
        private frmFatura faturaForm;

        public f()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new frmPizzaria());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            faturaForm = new frmFatura(
               Program.cliente,
               Program.pizza,
               Program.pizzaSelecionada,
               Program.borda,
               Program.bordaSelecionada,
               Program.bebida,
               Program.bebidaSelecionada,
               Program.suco,
               Program.sucoSelecionado,
               Program.totalFatura
               );
            loadform(faturaForm);
        }

        public void loadform(Form form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(form);
            this.mainpanel.Tag = form;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
