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
    public partial class Form2 : Form
    {
        public BBDD.GGarciaEntities contexto;

        public BBDD.Ticket ticketPublic;
        Form1 form1 = null;
        public Form2(Form1 mainForm)
        {
            form1 = mainForm;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            carregarTickets();
        }

        private void carregarTickets()
        {
            contexto = new BBDD.GGarciaEntities();
            var x = (from y in contexto.Ticket where y.del == false select y).ToList();
            ticketBindingSource.DataSource = x;
            ticketBindingSource.ResetBindings(false);
        }

        private void btnEsborrar_Click(object sender, EventArgs e)
        {
           
            BBDD.Ticket ticketSeleccionat = (BBDD.Ticket)ticketBindingSource.Current;
         
            foreach (var item in ticketSeleccionat.TicketLin)
            {
                contexto.TicketLin.Remove(item);
            }
            contexto.Ticket.Remove(ticketSeleccionat);
            contexto.SaveChanges();
            carregarTickets();
        }

        private void btnEsborratLogic_Click(object sender, EventArgs e)
        {
            BBDD.Ticket ticketSeleccionat = (BBDD.Ticket)ticketBindingSource.Current;
            foreach (var item in ticketSeleccionat.TicketLin)
            {
                item.del = true;
            }
            ticketSeleccionat.del = true;
            contexto.SaveChanges();
            carregarTickets();  
        }

        private void btnCarregarTicket_Click_1(object sender, EventArgs e)
        {
            BBDD.Ticket ticketPublic = (BBDD.Ticket)ticketBindingSource.Current;
            form1.generarTicket(ticketPublic);
            this.Close();
        }
    }
}
