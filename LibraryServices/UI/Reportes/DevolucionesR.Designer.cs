namespace LibraryServices.UI.Reportes.RPTConsutas
{
    partial class DevolucionesR
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
            this.MyrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MyrystalReportViewer1
            // 
            this.MyrystalReportViewer1.ActiveViewIndex = -1;
            this.MyrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.MyrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.MyrystalReportViewer1.Name = "MyrystalReportViewer1";
            this.MyrystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.MyrystalReportViewer1.TabIndex = 0;
            this.MyrystalReportViewer1.Load += new System.EventHandler(this.MyrystalReportViewer1_Load);
            // 
            // DevolucionesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyrystalReportViewer1);
            this.Name = "DevolucionesR";
            this.Text = "DevolucionesR";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MyrystalReportViewer1;
    }
}