
namespace TPV
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grvTickets = new DevExpress.XtraGrid.GridControl();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumeroticket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.ticketLinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_tickets = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantitat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpreu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEsborrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEsborrarLogic = new DevExpress.XtraEditors.SimpleButton();
            this.btnCarregarTicket = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketLinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.grvTickets);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(673, 234);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // grvTickets
            // 
            this.grvTickets.DataSource = this.ticketBindingSource;
            this.grvTickets.Location = new System.Drawing.Point(3, 3);
            this.grvTickets.MainView = this.gridView1;
            this.grvTickets.Name = "grvTickets";
            this.grvTickets.Size = new System.Drawing.Size(669, 231);
            this.grvTickets.TabIndex = 0;
            this.grvTickets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(BBDD.Ticket);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldata,
            this.colnumeroticket});
            this.gridView1.GridControl = this.grvTickets;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // coldata
            // 
            this.coldata.FieldName = "data";
            this.coldata.Name = "coldata";
            this.coldata.Visible = true;
            this.coldata.VisibleIndex = 1;
            // 
            // colnumeroticket
            // 
            this.colnumeroticket.FieldName = "numeroticket";
            this.colnumeroticket.Name = "colnumeroticket";
            this.colnumeroticket.Visible = true;
            this.colnumeroticket.VisibleIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 240);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gridControl2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 240);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 212);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.ticketLinBindingSource1;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(797, 209);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // ticketLinBindingSource1
            // 
            this.ticketLinBindingSource1.DataMember = "TicketLin";
            this.ticketLinBindingSource1.DataSource = this.ticketBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_tickets,
            this.colid1,
            this.colProducte,
            this.colquantitat,
            this.colpreu});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.id_tickets, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // id_tickets
            // 
            this.id_tickets.FieldName = "Ticket.id";
            this.id_tickets.Name = "id_tickets";
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            // 
            // colProducte
            // 
            this.colProducte.FieldName = "Producte.nom";
            this.colProducte.Name = "colProducte";
            this.colProducte.Visible = true;
            this.colProducte.VisibleIndex = 1;
            // 
            // colquantitat
            // 
            this.colquantitat.FieldName = "quantitat";
            this.colquantitat.Name = "colquantitat";
            this.colquantitat.Visible = true;
            this.colquantitat.VisibleIndex = 2;
            // 
            // colpreu
            // 
            this.colpreu.FieldName = "preu";
            this.colpreu.Name = "colpreu";
            this.colpreu.Visible = true;
            this.colpreu.VisibleIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnEsborrar);
            this.flowLayoutPanel4.Controls.Add(this.btnEsborrarLogic);
            this.flowLayoutPanel4.Controls.Add(this.btnCarregarTicket);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(679, 28);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(109, 206);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // btnEsborrar
            // 
            this.btnEsborrar.Location = new System.Drawing.Point(3, 3);
            this.btnEsborrar.Name = "btnEsborrar";
            this.btnEsborrar.Size = new System.Drawing.Size(100, 60);
            this.btnEsborrar.TabIndex = 0;
            this.btnEsborrar.Text = "ESBORRAT FISIC";
            this.btnEsborrar.Click += new System.EventHandler(this.btnEsborrar_Click);
            // 
            // btnEsborrarLogic
            // 
            this.btnEsborrarLogic.Location = new System.Drawing.Point(3, 69);
            this.btnEsborrarLogic.Name = "btnEsborrarLogic";
            this.btnEsborrarLogic.Size = new System.Drawing.Size(100, 60);
            this.btnEsborrarLogic.TabIndex = 1;
            this.btnEsborrarLogic.Text = "ESBORRAT LOGIC";
            this.btnEsborrarLogic.Click += new System.EventHandler(this.btnEsborratLogic_Click);
            // 
            // btnCarregarTicket
            // 
            this.btnCarregarTicket.Location = new System.Drawing.Point(3, 135);
            this.btnCarregarTicket.Name = "btnCarregarTicket";
            this.btnCarregarTicket.Size = new System.Drawing.Size(100, 60);
            this.btnCarregarTicket.TabIndex = 2;
            this.btnCarregarTicket.Text = "CARREGAR TICKET";
            this.btnCarregarTicket.Click += new System.EventHandler(this.btnCarregarTicket_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketLinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldata;
        private DevExpress.XtraGrid.Columns.GridColumn colnumeroticket;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource ticketLinBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colProducte;
        private DevExpress.XtraGrid.Columns.GridColumn colquantitat;
        private DevExpress.XtraGrid.Columns.GridColumn colpreu;
        private DevExpress.XtraGrid.Columns.GridColumn id_tickets;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton btnEsborrar;
        private DevExpress.XtraEditors.SimpleButton btnEsborrarLogic;
        public DevExpress.XtraGrid.GridControl grvTickets;
        public DevExpress.XtraEditors.SimpleButton btnCarregarTicket;
    }
}