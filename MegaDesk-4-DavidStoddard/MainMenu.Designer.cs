namespace MegaDesk_4_DavidStoddard
{
  partial class MainMenu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
      this.AddQuotesBtn = new System.Windows.Forms.Button();
      this.ViewQuotesBtn = new System.Windows.Forms.Button();
      this.SearchQuotesBtn = new System.Windows.Forms.Button();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // AddQuotesBtn
      // 
      this.AddQuotesBtn.FlatAppearance.BorderSize = 2;
      this.AddQuotesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.AddQuotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.AddQuotesBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AddQuotesBtn.Location = new System.Drawing.Point(24, 26);
      this.AddQuotesBtn.Margin = new System.Windows.Forms.Padding(6);
      this.AddQuotesBtn.Name = "AddQuotesBtn";
      this.AddQuotesBtn.Size = new System.Drawing.Size(200, 50);
      this.AddQuotesBtn.TabIndex = 0;
      this.AddQuotesBtn.Text = "&Add New Quote";
      this.AddQuotesBtn.UseVisualStyleBackColor = true;
      this.AddQuotesBtn.Click += new System.EventHandler(this.AddQuotesBtn_Click);
      // 
      // ViewQuotesBtn
      // 
      this.ViewQuotesBtn.FlatAppearance.BorderSize = 2;
      this.ViewQuotesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.ViewQuotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ViewQuotesBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ViewQuotesBtn.Location = new System.Drawing.Point(24, 88);
      this.ViewQuotesBtn.Margin = new System.Windows.Forms.Padding(6);
      this.ViewQuotesBtn.Name = "ViewQuotesBtn";
      this.ViewQuotesBtn.Size = new System.Drawing.Size(200, 50);
      this.ViewQuotesBtn.TabIndex = 1;
      this.ViewQuotesBtn.Text = "&View Quotes";
      this.ViewQuotesBtn.UseVisualStyleBackColor = true;
      this.ViewQuotesBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
      // 
      // SearchQuotesBtn
      // 
      this.SearchQuotesBtn.FlatAppearance.BorderSize = 2;
      this.SearchQuotesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.SearchQuotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SearchQuotesBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SearchQuotesBtn.Location = new System.Drawing.Point(24, 150);
      this.SearchQuotesBtn.Margin = new System.Windows.Forms.Padding(6);
      this.SearchQuotesBtn.Name = "SearchQuotesBtn";
      this.SearchQuotesBtn.Size = new System.Drawing.Size(200, 50);
      this.SearchQuotesBtn.TabIndex = 2;
      this.SearchQuotesBtn.Text = "&Search Quotes";
      this.SearchQuotesBtn.UseVisualStyleBackColor = true;
      this.SearchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
      // 
      // ExitBtn
      // 
      this.ExitBtn.FlatAppearance.BorderSize = 2;
      this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ExitBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ExitBtn.Location = new System.Drawing.Point(24, 212);
      this.ExitBtn.Margin = new System.Windows.Forms.Padding(6);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(200, 50);
      this.ExitBtn.TabIndex = 3;
      this.ExitBtn.Text = "E&xit";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(242, 150);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(130, 112);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 286);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.ExitBtn);
      this.Controls.Add(this.SearchQuotesBtn);
      this.Controls.Add(this.ViewQuotesBtn);
      this.Controls.Add(this.AddQuotesBtn);
      this.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainMenu";
      this.Text = "MegaDesk";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button AddQuotesBtn;
    private System.Windows.Forms.Button ViewQuotesBtn;
    private System.Windows.Forms.Button SearchQuotesBtn;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

