namespace MegaDesk_4_DavidStoddard
{
  partial class DisplayQuote
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
      this.cancelBtn = new System.Windows.Forms.Button();
      this.NameLbl = new System.Windows.Forms.Label();
      this.QuoteLbl = new System.Windows.Forms.Label();
      this.DateLbl = new System.Windows.Forms.Label();
      this.DepthLbl = new System.Windows.Forms.Label();
      this.WidthLbl = new System.Windows.Forms.Label();
      this.DrawersLbl = new System.Windows.Forms.Label();
      this.MaterialLbl = new System.Windows.Forms.Label();
      this.AreaLbl = new System.Windows.Forms.Label();
      this.RushLbl = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cancelBtn
      // 
      this.cancelBtn.FlatAppearance.BorderSize = 2;
      this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cancelBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.cancelBtn.Location = new System.Drawing.Point(94, 287);
      this.cancelBtn.Margin = new System.Windows.Forms.Padding(6);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(224, 50);
      this.cancelBtn.TabIndex = 9;
      this.cancelBtn.Text = "&Return to Main Menu";
      this.cancelBtn.UseVisualStyleBackColor = true;
      this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
      // 
      // NameLbl
      // 
      this.NameLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NameLbl.Location = new System.Drawing.Point(96, 9);
      this.NameLbl.Name = "NameLbl";
      this.NameLbl.Size = new System.Drawing.Size(220, 19);
      this.NameLbl.TabIndex = 10;
      this.NameLbl.Text = "Name Placeholder";
      this.NameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // QuoteLbl
      // 
      this.QuoteLbl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.QuoteLbl.ForeColor = System.Drawing.Color.DarkOrange;
      this.QuoteLbl.Location = new System.Drawing.Point(2, 241);
      this.QuoteLbl.Name = "QuoteLbl";
      this.QuoteLbl.Size = new System.Drawing.Size(408, 40);
      this.QuoteLbl.TabIndex = 11;
      this.QuoteLbl.Text = "Quote Placeholder";
      this.QuoteLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // DateLbl
      // 
      this.DateLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DateLbl.Location = new System.Drawing.Point(96, 28);
      this.DateLbl.Name = "DateLbl";
      this.DateLbl.Size = new System.Drawing.Size(220, 20);
      this.DateLbl.TabIndex = 12;
      this.DateLbl.Text = "Date Placeholder";
      this.DateLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // DepthLbl
      // 
      this.DepthLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DepthLbl.Location = new System.Drawing.Point(12, 113);
      this.DepthLbl.Name = "DepthLbl";
      this.DepthLbl.Size = new System.Drawing.Size(171, 20);
      this.DepthLbl.TabIndex = 13;
      this.DepthLbl.Text = "Depth Placeholder";
      // 
      // WidthLbl
      // 
      this.WidthLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WidthLbl.Location = new System.Drawing.Point(12, 87);
      this.WidthLbl.Name = "WidthLbl";
      this.WidthLbl.Size = new System.Drawing.Size(171, 20);
      this.WidthLbl.TabIndex = 14;
      this.WidthLbl.Text = "Width Placeholder";
      // 
      // DrawersLbl
      // 
      this.DrawersLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DrawersLbl.Location = new System.Drawing.Point(228, 113);
      this.DrawersLbl.Name = "DrawersLbl";
      this.DrawersLbl.Size = new System.Drawing.Size(171, 20);
      this.DrawersLbl.TabIndex = 16;
      this.DrawersLbl.Text = "Drawers Placeholder";
      // 
      // MaterialLbl
      // 
      this.MaterialLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MaterialLbl.Location = new System.Drawing.Point(228, 87);
      this.MaterialLbl.Name = "MaterialLbl";
      this.MaterialLbl.Size = new System.Drawing.Size(171, 20);
      this.MaterialLbl.TabIndex = 15;
      this.MaterialLbl.Text = "Material Placeholder";
      // 
      // AreaLbl
      // 
      this.AreaLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AreaLbl.Location = new System.Drawing.Point(12, 139);
      this.AreaLbl.Name = "AreaLbl";
      this.AreaLbl.Size = new System.Drawing.Size(364, 20);
      this.AreaLbl.TabIndex = 17;
      this.AreaLbl.Text = "Total Area";
      // 
      // RushLbl
      // 
      this.RushLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RushLbl.Location = new System.Drawing.Point(12, 191);
      this.RushLbl.Name = "RushLbl";
      this.RushLbl.Size = new System.Drawing.Size(171, 20);
      this.RushLbl.TabIndex = 18;
      this.RushLbl.Text = "Rush Placeholder";
      // 
      // DisplayQuote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(411, 356);
      this.Controls.Add(this.RushLbl);
      this.Controls.Add(this.AreaLbl);
      this.Controls.Add(this.DrawersLbl);
      this.Controls.Add(this.MaterialLbl);
      this.Controls.Add(this.WidthLbl);
      this.Controls.Add(this.DepthLbl);
      this.Controls.Add(this.DateLbl);
      this.Controls.Add(this.QuoteLbl);
      this.Controls.Add(this.NameLbl);
      this.Controls.Add(this.cancelBtn);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DisplayQuote";
      this.Text = "Quote";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubFormClosing);
      this.Load += new System.EventHandler(this.DisplayInfo);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.Label NameLbl;
    private System.Windows.Forms.Label QuoteLbl;
    private System.Windows.Forms.Label DateLbl;
    private System.Windows.Forms.Label DepthLbl;
    private System.Windows.Forms.Label WidthLbl;
    private System.Windows.Forms.Label DrawersLbl;
    private System.Windows.Forms.Label MaterialLbl;
    private System.Windows.Forms.Label AreaLbl;
    private System.Windows.Forms.Label RushLbl;
  }
}