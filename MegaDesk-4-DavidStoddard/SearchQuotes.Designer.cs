namespace MegaDesk_4_DavidStoddard
{
  partial class SearchQuotes
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
      this.cancelBtn = new System.Windows.Forms.Button();
      this.materialLabel = new System.Windows.Forms.Label();
      this.materialSelect = new System.Windows.Forms.ComboBox();
      this.SearchResultList = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // cancelBtn
      // 
      this.cancelBtn.FlatAppearance.BorderSize = 2;
      this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cancelBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.cancelBtn.Location = new System.Drawing.Point(155, 323);
      this.cancelBtn.Margin = new System.Windows.Forms.Padding(6);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(231, 50);
      this.cancelBtn.TabIndex = 10;
      this.cancelBtn.Text = "&Return to Main Menu";
      this.cancelBtn.UseVisualStyleBackColor = true;
      this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
      // 
      // materialLabel
      // 
      this.materialLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.materialLabel.Location = new System.Drawing.Point(12, 24);
      this.materialLabel.Name = "materialLabel";
      this.materialLabel.Size = new System.Drawing.Size(144, 24);
      this.materialLabel.TabIndex = 12;
      this.materialLabel.Text = "Search by Material:";
      // 
      // materialSelect
      // 
      this.materialSelect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.materialSelect.FormattingEnabled = true;
      this.materialSelect.Location = new System.Drawing.Point(162, 21);
      this.materialSelect.Name = "materialSelect";
      this.materialSelect.Size = new System.Drawing.Size(148, 27);
      this.materialSelect.TabIndex = 11;
      this.materialSelect.SelectedIndexChanged += new System.EventHandler(this.SearchListByMaterial);
      // 
      // SearchResultList
      // 
      this.SearchResultList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SearchResultList.Location = new System.Drawing.Point(12, 54);
      this.SearchResultList.Name = "SearchResultList";
      this.SearchResultList.Size = new System.Drawing.Size(517, 260);
      this.SearchResultList.TabIndex = 13;
      this.SearchResultList.UseCompatibleStateImageBehavior = false;
      this.SearchResultList.View = System.Windows.Forms.View.Details;
      // 
      // SearchQuotes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(541, 388);
      this.Controls.Add(this.SearchResultList);
      this.Controls.Add(this.materialLabel);
      this.Controls.Add(this.materialSelect);
      this.Controls.Add(this.cancelBtn);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchQuotes";
      this.Text = "Search Quotes";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubFormClosing);
      this.Load += new System.EventHandler(this.LoadingForm);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.Label materialLabel;
    private System.Windows.Forms.ComboBox materialSelect;
    private System.Windows.Forms.ListView SearchResultList;
  }
}