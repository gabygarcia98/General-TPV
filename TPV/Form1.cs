using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class Form1 : Form
    {
        private BBDD.GGarciaEntities contexto;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            generarTicket();
            CarregaCategories();
            
        }

        private void CarregaCategories()
        {
            flowLayoutPanel1.Controls.Clear();

            BBDD.Categoria categoria = new BBDD.Categoria();
            var x = (from y in contexto.Categoria where y.del == false select y).ToList();

            foreach (var item in x)
            {
                SimpleButton b = new SimpleButton();
                b.Text = item.nom;
                b.Click += new EventHandler(carregaProductes);
                //b.Tag = item.id;
                b.Tag = item;
                this.flowLayoutPanel1.Controls.Add(b);

            }


        }

        public void carregaProductes(object sender, EventArgs e)
        {
            this.flowLayoutPanel4.Controls.Clear();
            SimpleButton sp = (SimpleButton)sender;
            BBDD.Producte productes = new BBDD.Producte();
            BBDD.Categoria cat = (BBDD.Categoria)sp.Tag;

            var bbddproductes = (from y in contexto.Producte where y.del == false where y.Categoria.id == cat.id select y).ToList();

            foreach (var item in bbddproductes)
            {
                SimpleButton b = new SimpleButton();
                b.Text = item.nom;
                b.Tag = item;
                b.Click += new EventHandler(agregarLinea);
                this.flowLayoutPanel4.Controls.Add(b);
            }

        }

        public void agregarLinea(object sender, EventArgs e)
        {
            SimpleButton sp = (SimpleButton)sender;
            BBDD.Ticket t = (BBDD.Ticket)BSItem.Current;
            BBDD.TicketLin lin = new BBDD.TicketLin(/*false*/);

            BBDD.Producte productes = (BBDD.Producte)sp.Tag;

            lin.Producte = productes;
            lin.preu = productes.preu;
            lin.quantitat = 1;

            t.TicketLin.Add(lin);
            lin.Ticket = t;


            BSItem.ResetBindings(false);
            BSlinies.ResetBindings(false);
        }


        public void generarTicket(BBDD.Ticket ticket = null)
        {
            if (contexto != null)
            {
                contexto.Dispose();
                //BSItem.DataSource = null;
            }
            contexto = new BBDD.GGarciaEntities();
            BBDD.Ticket t = null;

            if (ticket == null)
            {
                
                t = new BBDD.Ticket(/*false*/);
                var z = (from y in contexto.Ticket where y.del == false orderby y.id descending select y.numeroticket).FirstOrDefault();
                if (z == null) z = 0;
                t.numeroticket = z + 1;
                contexto.Ticket.Add(t);
            }
            else
            {
                t = contexto.Ticket.Find(ticket.id);
            }

            BSItem.DataSource = t;
            BSItem.ResetBindings(false);
        }

        private void btnNumerosClick(object sender, EventArgs e)
        {
            SimpleButton sp = (SimpleButton)sender;
            string strComprovacio = (string)textBox1.Text + (string)sp.Tag;

            if (decimal.TryParse(strComprovacio, out decimal result))
            {
                textBox1.Text += (string)sp.Tag;
            }
            else
            {
                MessageBox.Show("Number not correct");

            }
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            var txt = textBox1.Text;
            textBox1.Text = (string)txt.Remove(txt.Length - 1);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {

            BBDD.TicketLin actual = (BBDD.TicketLin)BSlinies.Current;
            var txt = textBox1.Text;

            if (Decimal.TryParse(txt, out decimal de))
            {
                actual.preu = (double)de;
            }
            textBox1.Clear();

            BSlinies.ResetBindings(false);
            BSItem.ResetBindings(false);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            BBDD.TicketLin actual = (BBDD.TicketLin)BSlinies.Current;
            var txt = textBox1.Text;

            if (Decimal.TryParse(txt, out decimal de))
            {
                actual.quantitat = (int)de;
            }
            textBox1.Clear();

            BSlinies.ResetBindings(false);
            BSItem.ResetBindings(false);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                contexto.SaveChanges();
                generarTicket();
                resetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetForm()
        {
            flowLayoutPanel4.Controls.Clear();
            textBox1.Clear();
            contexto.Dispose();
            contexto = new BBDD.GGarciaEntities();
            CarregaCategories();
            generarTicket();
        }
        private void simpleButton16_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();

        }

        private void btnAfegirCategories_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }        
}
  
