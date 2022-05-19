
namespace DepreciationDBApp.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.dgvAsset = new System.Windows.Forms.DataGridView();
            this.btnActivo = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(535, 355);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(75, 23);
            this.btnAddAsset.TabIndex = 0;
            this.btnAddAsset.Text = "Add Asset";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // dgvAsset
            // 
            this.dgvAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsset.Location = new System.Drawing.Point(12, 12);
            this.dgvAsset.Name = "dgvAsset";
            this.dgvAsset.RowTemplate.Height = 25;
            this.dgvAsset.Size = new System.Drawing.Size(725, 296);
            this.dgvAsset.TabIndex = 1;
            // 
            // btnActivo
            // 
            this.btnActivo.Location = new System.Drawing.Point(3, 3);
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.Size = new System.Drawing.Size(75, 48);
            this.btnActivo.TabIndex = 2;
            this.btnActivo.Text = "Activos";
            this.btnActivo.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(84, 3);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 48);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnActivo);
            this.flowLayoutPanel1.Controls.Add(this.btnEmpleados);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(278, 327);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 81);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 457);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvAsset);
            this.Controls.Add(this.btnAddAsset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.DataGridView dgvAsset;
        private System.Windows.Forms.Button btnActivo;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

