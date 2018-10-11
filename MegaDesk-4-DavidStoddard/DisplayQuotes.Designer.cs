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
      this.SuspendLayout();
      // 
      // cancelBtn
      // 
      this.cancelBtn.FlatAppearance.BorderSize = 2;
      this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cancelBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.cancelBtn.Location = new System.Drawing.Point(130, 228);
      this.cancelBtn.Margin = new System.Windows.Forms.Padding(6);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(157, 50);
      this.cancelBtn.TabIndex = 9;
      this.cancelBtn.Text = "&Close";
      this.cancelBtn.UseVisualStyleBackColor = true;
      this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
      // 
      // DisplayQuote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(411, 293);
      this.Controls.Add(this.cancelBtn);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DisplayQuote";
      this.Text = "Quote";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubFormClosing);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cancelBtn;
  }
}