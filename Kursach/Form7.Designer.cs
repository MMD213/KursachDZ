namespace Kursach
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.callCentrDataSet2 = new Kursach.CallCentrDataSet2();
            this.callCentrDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentTableAdapter = new Kursach.CallCentrDataSet2TableAdapters.AbonentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callCentrDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callCentrDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(776, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // callCentrDataSet2
            // 
            this.callCentrDataSet2.DataSetName = "CallCentrDataSet2";
            this.callCentrDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // callCentrDataSet2BindingSource
            // 
            this.callCentrDataSet2BindingSource.DataSource = this.callCentrDataSet2;
            this.callCentrDataSet2BindingSource.Position = 0;
            // 
            // abonentBindingSource
            // 
            this.abonentBindingSource.DataMember = "Abonent";
            this.abonentBindingSource.DataSource = this.callCentrDataSet2BindingSource;
            // 
            // abonentTableAdapter
            // 
            this.abonentTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Дополнительная информация";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callCentrDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callCentrDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource callCentrDataSet2BindingSource;
        private CallCentrDataSet2 callCentrDataSet2;
        private System.Windows.Forms.BindingSource abonentBindingSource;
        private CallCentrDataSet2TableAdapters.AbonentTableAdapter abonentTableAdapter;
    }
}