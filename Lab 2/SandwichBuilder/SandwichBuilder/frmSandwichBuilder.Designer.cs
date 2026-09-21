namespace SandwichBuilder
{
    partial class frmSandwichBuilder
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOrderType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxPreMade = new System.Windows.Forms.ComboBox();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.lblBread = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.cbxSauces = new System.Windows.Forms.ComboBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.lblMeats = new System.Windows.Forms.Label();
            this.lblCheese = new System.Windows.Forms.Label();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.lblPremToppings = new System.Windows.Forms.Label();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.gbBread = new System.Windows.Forms.GroupBox();
            this.gbCheese = new System.Windows.Forms.GroupBox();
            this.gbMeats = new System.Windows.Forms.GroupBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.gbExtraToppings = new System.Windows.Forms.GroupBox();
            this.gbBread.SuspendLayout();
            this.gbCheese.SuspendLayout();
            this.gbMeats.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbExtraToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(477, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(477, 102);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 26);
            this.txtAddress.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(476, 154);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(242, 26);
            this.txtPhone.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(564, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(551, 79);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phone Number:";
            // 
            // cbxOrderType
            // 
            this.cbxOrderType.FormattingEnabled = true;
            this.cbxOrderType.Items.AddRange(new object[] {
            "Pickup",
            "Delivery"});
            this.cbxOrderType.Location = new System.Drawing.Point(533, 204);
            this.cbxOrderType.Name = "cbxOrderType";
            this.cbxOrderType.Size = new System.Drawing.Size(121, 28);
            this.cbxOrderType.TabIndex = 6;
            this.cbxOrderType.Text = "Order Type:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(391, 881);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(415, 52);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // cbxPreMade
            // 
            this.cbxPreMade.FormattingEnabled = true;
            this.cbxPreMade.Items.AddRange(new object[] {
            "Custom",
            "Small Love Turkey",
            "Large Hateful Turkey",
            "Party Hateful Turkey"});
            this.cbxPreMade.Location = new System.Drawing.Point(477, 238);
            this.cbxPreMade.Name = "cbxPreMade";
            this.cbxPreMade.Size = new System.Drawing.Size(242, 28);
            this.cbxPreMade.TabIndex = 8;
            this.cbxPreMade.Text = "Pre Made:";
            // 
            // cbxSize
            // 
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra-Large",
            "Party-Size"});
            this.cbxSize.Location = new System.Drawing.Point(477, 292);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(241, 28);
            this.cbxSize.TabIndex = 10;
            this.cbxSize.Text = "Size:";
            // 
            // lblBread
            // 
            this.lblBread.AutoSize = true;
            this.lblBread.Location = new System.Drawing.Point(118, 21);
            this.lblBread.Name = "lblBread";
            this.lblBread.Size = new System.Drawing.Size(56, 20);
            this.lblBread.TabIndex = 11;
            this.lblBread.Text = "Bread:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 125);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 24);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(184, 125);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 24);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(17, 174);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(126, 24);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(184, 174);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(126, 24);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(181, 36);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 24);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(28, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(113, 24);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(181, 66);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 24);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(28, 96);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 24);
            this.checkBox5.TabIndex = 23;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(181, 96);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(113, 24);
            this.checkBox6.TabIndex = 24;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(28, 126);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(113, 24);
            this.checkBox7.TabIndex = 25;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(181, 126);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(113, 24);
            this.checkBox8.TabIndex = 26;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // cbxSauces
            // 
            this.cbxSauces.FormattingEnabled = true;
            this.cbxSauces.Location = new System.Drawing.Point(533, 548);
            this.cbxSauces.Name = "cbxSauces";
            this.cbxSauces.Size = new System.Drawing.Size(121, 28);
            this.cbxSauces.TabIndex = 27;
            this.cbxSauces.Text = "Sauces";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(28, 163);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(113, 24);
            this.checkBox9.TabIndex = 28;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(181, 163);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(122, 24);
            this.checkBox10.TabIndex = 29;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // lblMeats
            // 
            this.lblMeats.AutoSize = true;
            this.lblMeats.Location = new System.Drawing.Point(132, 13);
            this.lblMeats.Name = "lblMeats";
            this.lblMeats.Size = new System.Drawing.Size(53, 20);
            this.lblMeats.TabIndex = 30;
            this.lblMeats.Text = "Meats";
            // 
            // lblCheese
            // 
            this.lblCheese.AutoSize = true;
            this.lblCheese.Location = new System.Drawing.Point(120, 7);
            this.lblCheese.Name = "lblCheese";
            this.lblCheese.Size = new System.Drawing.Size(68, 20);
            this.lblCheese.TabIndex = 31;
            this.lblCheese.Text = "Cheese:";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(32, 55);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(122, 24);
            this.checkBox11.TabIndex = 32;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(182, 55);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(122, 24);
            this.checkBox12.TabIndex = 33;
            this.checkBox12.Text = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(32, 89);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(122, 24);
            this.checkBox13.TabIndex = 34;
            this.checkBox13.Text = "checkBox13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(182, 89);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(122, 24);
            this.checkBox14.TabIndex = 35;
            this.checkBox14.Text = "checkBox14";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(106, 119);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(122, 24);
            this.checkBox15.TabIndex = 36;
            this.checkBox15.Text = "checkBox15";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(123, 3);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(74, 20);
            this.lblToppings.TabIndex = 37;
            this.lblToppings.Text = "Toppings";
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(16, 40);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(122, 24);
            this.checkBox16.TabIndex = 38;
            this.checkBox16.Text = "checkBox16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(175, 40);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(122, 24);
            this.checkBox17.TabIndex = 39;
            this.checkBox17.Text = "checkBox17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(16, 84);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(122, 24);
            this.checkBox18.TabIndex = 40;
            this.checkBox18.Text = "checkBox18";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(175, 84);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(122, 24);
            this.checkBox19.TabIndex = 41;
            this.checkBox19.Text = "checkBox19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(16, 126);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(122, 24);
            this.checkBox20.TabIndex = 42;
            this.checkBox20.Text = "checkBox20";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(175, 128);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(122, 24);
            this.checkBox21.TabIndex = 43;
            this.checkBox21.Text = "checkBox21";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(16, 178);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(122, 24);
            this.checkBox22.TabIndex = 44;
            this.checkBox22.Text = "checkBox22";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(175, 178);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(122, 24);
            this.checkBox23.TabIndex = 45;
            this.checkBox23.Text = "checkBox23";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // lblPremToppings
            // 
            this.lblPremToppings.AutoSize = true;
            this.lblPremToppings.Location = new System.Drawing.Point(113, 43);
            this.lblPremToppings.Name = "lblPremToppings";
            this.lblPremToppings.Size = new System.Drawing.Size(115, 20);
            this.lblPremToppings.TabIndex = 46;
            this.lblPremToppings.Text = "Extra Toppings";
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(28, 84);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(122, 24);
            this.checkBox24.TabIndex = 47;
            this.checkBox24.Text = "checkBox24";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(200, 84);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(122, 24);
            this.checkBox25.TabIndex = 48;
            this.checkBox25.Text = "checkBox25";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(28, 131);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(122, 24);
            this.checkBox26.TabIndex = 49;
            this.checkBox26.Text = "checkBox26";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(200, 131);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(122, 24);
            this.checkBox27.TabIndex = 50;
            this.checkBox27.Text = "checkBox27";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(28, 178);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(122, 24);
            this.checkBox28.TabIndex = 51;
            this.checkBox28.Text = "checkBox28";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(200, 178);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(122, 24);
            this.checkBox29.TabIndex = 52;
            this.checkBox29.Text = "checkBox29";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(28, 224);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(122, 24);
            this.checkBox30.TabIndex = 53;
            this.checkBox30.Text = "checkBox30";
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(200, 224);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(122, 24);
            this.checkBox31.TabIndex = 54;
            this.checkBox31.Text = "checkBox31";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(28, 267);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(122, 24);
            this.checkBox32.TabIndex = 55;
            this.checkBox32.Text = "checkBox32";
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // checkBox33
            // 
            this.checkBox33.AutoSize = true;
            this.checkBox33.Location = new System.Drawing.Point(200, 267);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(122, 24);
            this.checkBox33.TabIndex = 56;
            this.checkBox33.Text = "checkBox33";
            this.checkBox33.UseVisualStyleBackColor = true;
            // 
            // gbBread
            // 
            this.gbBread.Controls.Add(this.radioButton6);
            this.gbBread.Controls.Add(this.radioButton5);
            this.gbBread.Controls.Add(this.radioButton4);
            this.gbBread.Controls.Add(this.radioButton3);
            this.gbBread.Controls.Add(this.radioButton2);
            this.gbBread.Controls.Add(this.radioButton1);
            this.gbBread.Controls.Add(this.lblBread);
            this.gbBread.Location = new System.Drawing.Point(23, 424);
            this.gbBread.Name = "gbBread";
            this.gbBread.Size = new System.Drawing.Size(339, 220);
            this.gbBread.TabIndex = 57;
            this.gbBread.TabStop = false;
            // 
            // gbCheese
            // 
            this.gbCheese.Controls.Add(this.checkBox15);
            this.gbCheese.Controls.Add(this.checkBox14);
            this.gbCheese.Controls.Add(this.checkBox13);
            this.gbCheese.Controls.Add(this.checkBox12);
            this.gbCheese.Controls.Add(this.checkBox11);
            this.gbCheese.Controls.Add(this.lblCheese);
            this.gbCheese.Location = new System.Drawing.Point(31, 650);
            this.gbCheese.Name = "gbCheese";
            this.gbCheese.Size = new System.Drawing.Size(330, 165);
            this.gbCheese.TabIndex = 58;
            this.gbCheese.TabStop = false;
            // 
            // gbMeats
            // 
            this.gbMeats.Controls.Add(this.lblMeats);
            this.gbMeats.Controls.Add(this.checkBox10);
            this.gbMeats.Controls.Add(this.checkBox9);
            this.gbMeats.Controls.Add(this.checkBox8);
            this.gbMeats.Controls.Add(this.checkBox7);
            this.gbMeats.Controls.Add(this.checkBox6);
            this.gbMeats.Controls.Add(this.checkBox5);
            this.gbMeats.Controls.Add(this.checkBox4);
            this.gbMeats.Controls.Add(this.checkBox3);
            this.gbMeats.Controls.Add(this.checkBox2);
            this.gbMeats.Controls.Add(this.checkBox1);
            this.gbMeats.Location = new System.Drawing.Point(434, 342);
            this.gbMeats.Name = "gbMeats";
            this.gbMeats.Size = new System.Drawing.Size(338, 206);
            this.gbMeats.TabIndex = 59;
            this.gbMeats.TabStop = false;
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.checkBox23);
            this.gbToppings.Controls.Add(this.checkBox22);
            this.gbToppings.Controls.Add(this.checkBox21);
            this.gbToppings.Controls.Add(this.checkBox20);
            this.gbToppings.Controls.Add(this.checkBox19);
            this.gbToppings.Controls.Add(this.checkBox18);
            this.gbToppings.Controls.Add(this.checkBox17);
            this.gbToppings.Controls.Add(this.checkBox16);
            this.gbToppings.Controls.Add(this.lblToppings);
            this.gbToppings.Location = new System.Drawing.Point(441, 595);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(330, 231);
            this.gbToppings.TabIndex = 60;
            this.gbToppings.TabStop = false;
            // 
            // gbExtraToppings
            // 
            this.gbExtraToppings.Controls.Add(this.checkBox33);
            this.gbExtraToppings.Controls.Add(this.checkBox32);
            this.gbExtraToppings.Controls.Add(this.checkBox31);
            this.gbExtraToppings.Controls.Add(this.checkBox30);
            this.gbExtraToppings.Controls.Add(this.checkBox29);
            this.gbExtraToppings.Controls.Add(this.checkBox28);
            this.gbExtraToppings.Controls.Add(this.checkBox27);
            this.gbExtraToppings.Controls.Add(this.checkBox26);
            this.gbExtraToppings.Controls.Add(this.checkBox25);
            this.gbExtraToppings.Controls.Add(this.checkBox24);
            this.gbExtraToppings.Controls.Add(this.lblPremToppings);
            this.gbExtraToppings.Location = new System.Drawing.Point(812, 429);
            this.gbExtraToppings.Name = "gbExtraToppings";
            this.gbExtraToppings.Size = new System.Drawing.Size(338, 344);
            this.gbExtraToppings.TabIndex = 61;
            this.gbExtraToppings.TabStop = false;
            // 
            // frmSandwichBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 1068);
            this.Controls.Add(this.gbExtraToppings);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbMeats);
            this.Controls.Add(this.gbCheese);
            this.Controls.Add(this.gbBread);
            this.Controls.Add(this.cbxSauces);
            this.Controls.Add(this.cbxSize);
            this.Controls.Add(this.cbxPreMade);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxOrderType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "frmSandwichBuilder";
            this.Text = "Sandwich Order Form";
            this.gbBread.ResumeLayout(false);
            this.gbBread.PerformLayout();
            this.gbCheese.ResumeLayout(false);
            this.gbCheese.PerformLayout();
            this.gbMeats.ResumeLayout(false);
            this.gbMeats.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbExtraToppings.ResumeLayout(false);
            this.gbExtraToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOrderType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbxPreMade;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.Label lblBread;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.ComboBox cbxSauces;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label lblMeats;
        private System.Windows.Forms.Label lblCheese;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.Label lblPremToppings;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.CheckBox checkBox33;
        private System.Windows.Forms.GroupBox gbBread;
        private System.Windows.Forms.GroupBox gbCheese;
        private System.Windows.Forms.GroupBox gbMeats;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbExtraToppings;
    }
}

