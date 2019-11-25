namespace LibraryServices.UI.Reportes
{
    partial class RPPrestamos
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
            this.MycrystalReportViewer1.Size = new System.Drawing.Size(765, 424);
            this.MycrystalReportViewer1.TabIndex = 0;
            this.MycrystalReportViewer1.Load += new System.EventHandler(this.CrystalReportViewer1_Load);
            // 
            // RPPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 424);
            this.Controls.Add(this.MycrystalReportViewer1);
            this.Name = "RPPrestamos";
            this.Text = "RPPrestamos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MycrystalReportViewer1;
    }
}