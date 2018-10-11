namespace MegaDesk_4_DavidStoddard
{
  partial class AddQuotes
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuotes));
      this.AddQuotesBtn = new System.Windows.Forms.Button();
      this.cancelBtn = new System.Windows.Forms.Button();
      this.materialSelect = new System.Windows.Forms.ComboBox();
      this.nameLbl = new System.Windows.Forms.Label();
      this.widthLbl = new System.Windows.Forms.Label();
      this.DepthLbl = new System.Windows.Forms.Label();
      this.materialLabel = new System.Windows.Forms.Label();
      this.rushOrderVal = new System.Windows.Forms.ListBox();
      this.rushOrderLbl = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.numberDrawersVal = new System.Windows.Forms.NumericUpDown();
      this.nameBox = new System.Windows.Forms.TextBox();
      this.depthVal = new System.Windows.Forms.NumericUpDown();
      this.widthVal = new System.Windows.Forms.NumericUpDown();
      this.widthDetails = new System.Windows.Forms.Label();
      this.depthDetails = new System.Windows.Forms.Label();
      this.drawerDetials = new System.Windows.Forms.Label();
      this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.numberDrawersVal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.depthVal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.widthVal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // AddQuotesBtn
      // 
      this.AddQuotesBtn.FlatAppearance.BorderSize = 2;
      this.AddQuotesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.AddQuotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.AddQuotesBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AddQuotesBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.AddQuotesBtn.Location = new System.Drawing.Point(15, 377);
      this.AddQuotesBtn.Margin = new System.Windows.Forms.Padding(6);
      this.AddQuotesBtn.Name = "AddQuotesBtn";
      this.AddQuotesBtn.Size = new System.Drawing.Size(157, 50);
      this.AddQuotesBtn.TabIndex = 7;
      this.AddQuotesBtn.Text = "Add &Quote";
      this.AddQuotesBtn.UseVisualStyleBackColor = true;
      this.AddQuotesBtn.Click += new System.EventHandler(this.AddQuotesBtn_Click);
      // 
      // cancelBtn
      // 
      this.cancelBtn.FlatAppearance.BorderSize = 2;
      this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
      this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cancelBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.cancelBtn.Location = new System.Drawing.Point(237, 377);
      this.cancelBtn.Margin = new System.Windows.Forms.Padding(6);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(157, 50);
      this.cancelBtn.TabIndex = 8;
      this.cancelBtn.Text = "&Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
      // 
      // materialSelect
      // 
      this.materialSelect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.materialSelect.FormattingEnabled = true;
      this.materialSelect.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
      this.materialSelect.Location = new System.Drawing.Point(119, 63);
      this.materialSelect.Name = "materialSelect";
      this.materialSelect.Size = new System.Drawing.Size(148, 27);
      this.materialSelect.TabIndex = 2;
      // 
      // nameLbl
      // 
      this.nameLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLbl.Location = new System.Drawing.Point(20, 26);
      this.nameLbl.Name = "nameLbl";
      this.nameLbl.Size = new System.Drawing.Size(93, 38);
      this.nameLbl.TabIndex = 4;
      this.nameLbl.Text = "Name:";
      this.nameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // widthLbl
      // 
      this.widthLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.widthLbl.Location = new System.Drawing.Point(20, 105);
      this.widthLbl.Name = "widthLbl";
      this.widthLbl.Size = new System.Drawing.Size(93, 38);
      this.widthLbl.TabIndex = 5;
      this.widthLbl.Text = "Width:";
      this.widthLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // DepthLbl
      // 
      this.DepthLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DepthLbl.Location = new System.Drawing.Point(20, 143);
      this.DepthLbl.Name = "DepthLbl";
      this.DepthLbl.Size = new System.Drawing.Size(93, 38);
      this.DepthLbl.TabIndex = 6;
      this.DepthLbl.Text = "Depth:";
      this.DepthLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // materialLabel
      // 
      this.materialLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.materialLabel.Location = new System.Drawing.Point(20, 66);
      this.materialLabel.Name = "materialLabel";
      this.materialLabel.Size = new System.Drawing.Size(93, 38);
      this.materialLabel.TabIndex = 7;
      this.materialLabel.Text = "Material:";
      this.materialLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // rushOrderVal
      // 
      this.rushOrderVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rushOrderVal.FormattingEnabled = true;
      this.rushOrderVal.ItemHeight = 19;
      this.rushOrderVal.Items.AddRange(new object[] {
            "None",
            "3 Day",
            "5 Day",
            "7 Day"});
      this.rushOrderVal.Location = new System.Drawing.Point(21, 262);
      this.rushOrderVal.Name = "rushOrderVal";
      this.rushOrderVal.Size = new System.Drawing.Size(120, 80);
      this.rushOrderVal.TabIndex = 6;
      // 
      // rushOrderLbl
      // 
      this.rushOrderLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rushOrderLbl.Location = new System.Drawing.Point(17, 240);
      this.rushOrderLbl.Name = "rushOrderLbl";
      this.rushOrderLbl.Size = new System.Drawing.Size(96, 19);
      this.rushOrderLbl.TabIndex = 9;
      this.rushOrderLbl.Text = "Rush Order:";
      this.rushOrderLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(20, 181);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 38);
      this.label1.TabIndex = 10;
      this.label1.Text = "Number of Drawers:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // numberDrawersVal
      // 
      this.numberDrawersVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numberDrawersVal.Location = new System.Drawing.Point(119, 192);
      this.numberDrawersVal.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.numberDrawersVal.Name = "numberDrawersVal";
      this.numberDrawersVal.Size = new System.Drawing.Size(53, 27);
      this.numberDrawersVal.TabIndex = 5;
      this.numberDrawersVal.Enter += new System.EventHandler(this.value_Enter);
      // 
      // nameBox
      // 
      this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameBox.Location = new System.Drawing.Point(119, 23);
      this.nameBox.Name = "nameBox";
      this.nameBox.Size = new System.Drawing.Size(148, 26);
      this.nameBox.TabIndex = 1;
      // 
      // depthVal
      // 
      this.depthVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.depthVal.Location = new System.Drawing.Point(119, 141);
      this.depthVal.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
      this.depthVal.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
      this.depthVal.Name = "depthVal";
      this.depthVal.Size = new System.Drawing.Size(53, 27);
      this.depthVal.TabIndex = 4;
      this.depthVal.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
      this.depthVal.Enter += new System.EventHandler(this.value_Enter);
      this.depthVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthVal_KeyPress);
      // 
      // widthVal
      // 
      this.widthVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.widthVal.Location = new System.Drawing.Point(119, 103);
      this.widthVal.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
      this.widthVal.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.widthVal.Name = "widthVal";
      this.widthVal.Size = new System.Drawing.Size(53, 27);
      this.widthVal.TabIndex = 3;
      this.widthVal.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
      this.widthVal.Enter += new System.EventHandler(this.value_Enter);
      this.widthVal.Validating += new System.ComponentModel.CancelEventHandler(this.widthVal_Validating);
      this.widthVal.Validated += new System.EventHandler(this.widthVal_Validated);
      // 
      // widthDetails
      // 
      this.widthDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.widthDetails.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.widthDetails.Location = new System.Drawing.Point(178, 108);
      this.widthDetails.Name = "widthDetails";
      this.widthDetails.Size = new System.Drawing.Size(219, 22);
      this.widthDetails.TabIndex = 15;
      this.widthDetails.Text = "*Min 24 inches   Max 96 inches";
      // 
      // depthDetails
      // 
      this.depthDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.depthDetails.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.depthDetails.Location = new System.Drawing.Point(178, 146);
      this.depthDetails.Name = "depthDetails";
      this.depthDetails.Size = new System.Drawing.Size(219, 22);
      this.depthDetails.TabIndex = 16;
      this.depthDetails.Text = "*Min 12 inches   Max 48 inches";
      // 
      // drawerDetials
      // 
      this.drawerDetials.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.drawerDetials.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.drawerDetials.Location = new System.Drawing.Point(178, 197);
      this.drawerDetials.Name = "drawerDetials";
      this.drawerDetials.Size = new System.Drawing.Size(219, 22);
      this.drawerDetials.TabIndex = 17;
      this.drawerDetials.Text = "*Min 0 drawers   Max 7 drawers";
      // 
      // widthErrorProvider
      // 
      this.widthErrorProvider.ContainerControl = this;
      // 
      // AddQuotes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(409, 442);
      this.Controls.Add(this.drawerDetials);
      this.Controls.Add(this.depthDetails);
      this.Controls.Add(this.widthDetails);
      this.Controls.Add(this.widthVal);
      this.Controls.Add(this.depthVal);
      this.Controls.Add(this.nameBox);
      this.Controls.Add(this.numberDrawersVal);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.rushOrderLbl);
      this.Controls.Add(this.rushOrderVal);
      this.Controls.Add(this.materialLabel);
      this.Controls.Add(this.DepthLbl);
      this.Controls.Add(this.widthLbl);
      this.Controls.Add(this.nameLbl);
      this.Controls.Add(this.materialSelect);
      this.Controls.Add(this.cancelBtn);
      this.Controls.Add(this.AddQuotesBtn);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AddQuotes";
      this.Text = "Add New Quotes";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubFormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.numberDrawersVal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.depthVal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.widthVal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button AddQuotesBtn;
    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.ComboBox materialSelect;
    private System.Windows.Forms.Label nameLbl;
    private System.Windows.Forms.Label widthLbl;
    private System.Windows.Forms.Label DepthLbl;
    private System.Windows.Forms.Label materialLabel;
    private System.Windows.Forms.ListBox rushOrderVal;
    private System.Windows.Forms.Label rushOrderLbl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numberDrawersVal;
    private System.Windows.Forms.TextBox nameBox;
    private System.Windows.Forms.NumericUpDown depthVal;
    private System.Windows.Forms.NumericUpDown widthVal;
    private System.Windows.Forms.Label widthDetails;
    private System.Windows.Forms.Label depthDetails;
    private System.Windows.Forms.Label drawerDetials;
    private System.Windows.Forms.ErrorProvider widthErrorProvider;
  }
}