namespace LibraryServices.UI.Reportes.RPTConsutas
{
    partial class PrestamoRP
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
            this.MycrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MycrystalReportViewer1
            // 
            this.MycrystalReportViewer1.ActiveViewIndex = -1;
            this.MycrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MycrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.MycrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MycrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.MycrystalReportViewer1.Name = "MycrystalReportViewer1";
            this.MycrystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.MycrystalReportViewer1.TabIndex = 0;
            this.MycrystalReportViewer1.Load += new System.EventHandler(this.MycrystalReportViewer1_Load);
            // 
            // PrestamoRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MycrystalReportViewer1);
            this.Name = "PrestamoRP";
            this.Text = "PrestamoRP";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MycrystalReportViewer1;
    }
}