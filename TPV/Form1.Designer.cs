
namespace TPV
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode6 = new DevExpress.XtraGrid.GridLevelNode();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.BSlinies = new System.Windows.Forms.BindingSource(this.components);
            this.BSItem = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colquantitat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpreu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton16 = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton15 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAfegirCategories = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSlinies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.BSlinies;
            gridLevelNode4.RelationName = "Cant";
            gridLevelNode5.RelationName = "Producto";
            gridLevelNode6.RelationName = "Total";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4,
            gridLevelNode5,
            gridLevelNode6});
            this.gridControl1.Location = new System.Drawing.Point(9, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(492, 297);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // BSlinies
            // 
            this.BSlinies.DataMember = "TicketLin";
            this.BSlinies.DataSource = this.BSItem;
            // 
            // BSItem
            // 
            this.BSItem.DataSource = typeof(BBDD.Ticket);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.IndianRed;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colquantitat,
            this.colpreu,
            this.colProducte,
            this.colTotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colquantitat
            // 
            this.colquantitat.Caption = "Cant.";
            this.colquantitat.FieldName = "quantitat";
            this.colquantitat.Name = "colquantitat";
            this.colquantitat.Visible = true;
            this.colquantitat.VisibleIndex = 0;
            this.colquantitat.Width = 72;
            // 
            // colpreu
            // 
            this.colpreu.FieldName = "preu";
            this.colpreu.Name = "colpreu";
            this.colpreu.Visible = true;
            this.colpreu.VisibleIndex = 2;
            this.colpreu.Width = 98;
            // 
            // colProducte
            // 
            this.colProducte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colProducte.FieldName = "Producte.nom";
            this.colProducte.Name = "colProducte";
            this.colProducte.Visible = true;
            this.colProducte.VisibleIndex = 1;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(915, 601);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.gridControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(915, 379);
            this.splitContainer2.SplitterDistance = 527;
            this.splitContainer2.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(15, 334);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(96, 30);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Finalitzar ticket";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSItem, "totalTicket", true));
            this.label2.Location = new System.Drawing.Point(417, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSItem, "txtNumTicket", true));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.simpleButton13);
            this.flowLayoutPanel3.Controls.Add(this.simpleButton14);
            this.flowLayoutPanel3.Controls.Add(this.simpleButton16);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(258, 65);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(62, 263);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // simpleButton13
            // 
            this.simpleButton13.Location = new System.Drawing.Point(3, 3);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(59, 50);
            this.simpleButton13.TabIndex = 9;
            this.simpleButton13.Text = "Preu";
            this.simpleButton13.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // simpleButton14
            // 
            this.simpleButton14.Location = new System.Drawing.Point(3, 59);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.Size = new System.Drawing.Size(59, 50);
            this.simpleButton14.TabIndex = 10;
            this.simpleButton14.Text = "Quantitat";
            this.simpleButton14.Click += new System.EventHandler(this.simpleButton14_Click);
            // 
            // simpleButton16
            // 
            this.simpleButton16.Location = new System.Drawing.Point(3, 115);
            this.simpleButton16.Name = "simpleButton16";
            this.simpleButton16.Size = new System.Drawing.Size(59, 50);
            this.simpleButton16.TabIndex = 11;
            this.simpleButton16.Text = "Historial";
            this.simpleButton16.Click += new System.EventHandler(this.simpleButton16_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.simpleButton2);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton3);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton4);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton5);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton6);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton7);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton8);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton9);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton10);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton11);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton12);
            this.flowLayoutPanel2.Controls.Add(this.simpleButton15);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(58, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(175, 263);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(3, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 50);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Tag = "1";
            this.simpleButton2.Text = "1";
            this.simpleButton2.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(59, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(50, 50);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Tag = "2";
            this.simpleButton3.Text = "2";
            this.simpleButton3.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(115, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(50, 50);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Tag = "3";
            this.simpleButton4.Text = "3";
            this.simpleButton4.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(3, 59);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(50, 50);
            this.simpleButton5.TabIndex = 8;
            this.simpleButton5.Tag = "4";
            this.simpleButton5.Text = "4";
            this.simpleButton5.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(59, 59);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(50, 50);
            this.simpleButton6.TabIndex = 9;
            this.simpleButton6.Tag = "5";
            this.simpleButton6.Text = "5";
            this.simpleButton6.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(115, 59);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(50, 50);
            this.simpleButton7.TabIndex = 10;
            this.simpleButton7.Tag = "6";
            this.simpleButton7.Text = "6";
            this.simpleButton7.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(3, 115);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(50, 50);
            this.simpleButton8.TabIndex = 11;
            this.simpleButton8.Tag = "7";
            this.simpleButton8.Text = "7";
            this.simpleButton8.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(59, 115);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(50, 50);
            this.simpleButton9.TabIndex = 12;
            this.simpleButton9.Tag = "8";
            this.simpleButton9.Text = "8";
            this.simpleButton9.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Location = new System.Drawing.Point(115, 115);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(50, 50);
            this.simpleButton10.TabIndex = 13;
            this.simpleButton10.Tag = "9";
            this.simpleButton10.Text = "9";
            this.simpleButton10.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Location = new System.Drawing.Point(3, 171);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(50, 50);
            this.simpleButton11.TabIndex = 14;
            this.simpleButton11.Tag = "0";
            this.simpleButton11.Text = "0";
            this.simpleButton11.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton12
            // 
            this.simpleButton12.Location = new System.Drawing.Point(59, 171);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(50, 50);
            this.simpleButton12.TabIndex = 15;
            this.simpleButton12.Tag = ",";
            this.simpleButton12.Text = ".";
            this.simpleButton12.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // simpleButton15
            // 
            this.simpleButton15.Location = new System.Drawing.Point(115, 171);
            this.simpleButton15.Name = "simpleButton15";
            this.simpleButton15.Size = new System.Drawing.Size(50, 50);
            this.simpleButton15.TabIndex = 16;
            this.simpleButton15.Tag = "";
            this.simpleButton15.Text = "DEL";
            this.simpleButton15.Click += new System.EventHandler(this.simpleButton15_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 29);
            this.textBox1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textEdit1);
            this.splitContainer3.Panel1.Controls.Add(this.btnAfegirCategories);
            this.splitContainer3.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer3.Size = new System.Drawing.Size(915, 218);
            this.splitContainer3.SplitterDistance = 430;
            this.splitContainer3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(402, 157);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 19);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(457, 157);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // btnAfegirCategories
            // 
            this.btnAfegirCategories.Location = new System.Drawing.Point(12, 182);
            this.btnAfegirCategories.Name = "btnAfegirCategories";
            this.btnAfegirCategories.Size = new System.Drawing.Size(102, 32);
            this.btnAfegirCategories.TabIndex = 1;
            this.btnAfegirCategories.Text = "Afegir Categories";
            this.btnAfegirCategories.Click += new System.EventHandler(this.btnAfegirCategories_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(120, 188);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 601);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSlinies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton13;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton simpleButton14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton simpleButton15;
        private System.Windows.Forms.BindingSource BSItem;
        private System.Windows.Forms.BindingSource BSlinies;
        private DevExpress.XtraGrid.Columns.GridColumn colquantitat;
        private DevExpress.XtraGrid.Columns.GridColumn colpreu;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.SimpleButton simpleButton16;
        private DevExpress.XtraGrid.Columns.GridColumn colProducte;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnAfegirCategories;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}

