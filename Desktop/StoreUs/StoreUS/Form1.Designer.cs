namespace StoreUS
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.System_Log = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_Item_Price = new System.Windows.Forms.Label();
            this.Label_Item_Status = new System.Windows.Forms.Label();
            this.Label_Item_Name = new System.Windows.Forms.Label();
            this.Label_Item_Origin = new System.Windows.Forms.Label();
            this.Label_Item_ID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.PictureBox_Item_Picture = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Button_Add_Item = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBox_AddItem_ItemName = new System.Windows.Forms.TextBox();
            this.TextBox_AddItem_Quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox_AddItem_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBox_AddItem_Origin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBox_AddItem_Price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ComboBox_AddItem_Status = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ListView_ItemRange = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Label_Item_Quantity = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item_Picture)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 172);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current items";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // System_Log
            // 
            this.System_Log.Location = new System.Drawing.Point(12, 498);
            this.System_Log.Name = "System_Log";
            this.System_Log.Size = new System.Drawing.Size(829, 63);
            this.System_Log.TabIndex = 1;
            this.System_Log.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_Item_Quantity);
            this.groupBox1.Controls.Add(this.Label_Item_Price);
            this.groupBox1.Controls.Add(this.Label_Item_Status);
            this.groupBox1.Controls.Add(this.Label_Item_Name);
            this.groupBox1.Controls.Add(this.Label_Item_Origin);
            this.groupBox1.Controls.Add(this.Label_Item_ID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.PictureBox_Item_Picture);
            this.groupBox1.Location = new System.Drawing.Point(527, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 441);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item";
            // 
            // Label_Item_Price
            // 
            this.Label_Item_Price.AutoSize = true;
            this.Label_Item_Price.Location = new System.Drawing.Point(7, 112);
            this.Label_Item_Price.Name = "Label_Item_Price";
            this.Label_Item_Price.Size = new System.Drawing.Size(34, 13);
            this.Label_Item_Price.TabIndex = 6;
            this.Label_Item_Price.Text = "Price:";
            // 
            // Label_Item_Status
            // 
            this.Label_Item_Status.AutoSize = true;
            this.Label_Item_Status.Location = new System.Drawing.Point(6, 87);
            this.Label_Item_Status.Name = "Label_Item_Status";
            this.Label_Item_Status.Size = new System.Drawing.Size(40, 13);
            this.Label_Item_Status.TabIndex = 5;
            this.Label_Item_Status.Text = "Status:";
            // 
            // Label_Item_Name
            // 
            this.Label_Item_Name.AutoSize = true;
            this.Label_Item_Name.Location = new System.Drawing.Point(7, 42);
            this.Label_Item_Name.Name = "Label_Item_Name";
            this.Label_Item_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_Item_Name.TabIndex = 4;
            this.Label_Item_Name.Text = "Name:";
            // 
            // Label_Item_Origin
            // 
            this.Label_Item_Origin.AutoSize = true;
            this.Label_Item_Origin.Location = new System.Drawing.Point(6, 64);
            this.Label_Item_Origin.Name = "Label_Item_Origin";
            this.Label_Item_Origin.Size = new System.Drawing.Size(37, 13);
            this.Label_Item_Origin.TabIndex = 3;
            this.Label_Item_Origin.Text = "Origin:";
            // 
            // Label_Item_ID
            // 
            this.Label_Item_ID.AutoSize = true;
            this.Label_Item_ID.Location = new System.Drawing.Point(7, 20);
            this.Label_Item_ID.Name = "Label_Item_ID";
            this.Label_Item_ID.Size = new System.Drawing.Size(21, 13);
            this.Label_Item_ID.TabIndex = 2;
            this.Label_Item_ID.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional info";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(291, 74);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // PictureBox_Item_Picture
            // 
            this.PictureBox_Item_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_Item_Picture.Location = new System.Drawing.Point(166, 19);
            this.PictureBox_Item_Picture.Name = "PictureBox_Item_Picture";
            this.PictureBox_Item_Picture.Size = new System.Drawing.Size(142, 123);
            this.PictureBox_Item_Picture.TabIndex = 0;
            this.PictureBox_Item_Picture.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.Button_Add_Item);
            this.groupBox4.Location = new System.Drawing.Point(6, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 109);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Items";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(6, 311);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(492, 109);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remove Items";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ListView_ItemRange);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(480, 147);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Items";
            // 
            // Button_Add_Item
            // 
            this.Button_Add_Item.Location = new System.Drawing.Point(411, 80);
            this.Button_Add_Item.Name = "Button_Add_Item";
            this.Button_Add_Item.Size = new System.Drawing.Size(75, 23);
            this.Button_Add_Item.TabIndex = 0;
            this.Button_Add_Item.Text = "Add";
            this.Button_Add_Item.UseVisualStyleBackColor = true;
            this.Button_Add_Item.Click += new System.EventHandler(this.Button_Add_Item_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Remove All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TextBox_AddItem_ItemName
            // 
            this.TextBox_AddItem_ItemName.Location = new System.Drawing.Point(94, 13);
            this.TextBox_AddItem_ItemName.Name = "TextBox_AddItem_ItemName";
            this.TextBox_AddItem_ItemName.Size = new System.Drawing.Size(125, 20);
            this.TextBox_AddItem_ItemName.TabIndex = 3;
            // 
            // TextBox_AddItem_Quantity
            // 
            this.TextBox_AddItem_Quantity.Location = new System.Drawing.Point(94, 40);
            this.TextBox_AddItem_Quantity.Name = "TextBox_AddItem_Quantity";
            this.TextBox_AddItem_Quantity.Size = new System.Drawing.Size(38, 20);
            this.TextBox_AddItem_Quantity.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Item name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(225, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Item ID:";
            // 
            // TextBox_AddItem_ID
            // 
            this.TextBox_AddItem_ID.Location = new System.Drawing.Point(275, 13);
            this.TextBox_AddItem_ID.Name = "TextBox_AddItem_ID";
            this.TextBox_AddItem_ID.Size = new System.Drawing.Size(91, 20);
            this.TextBox_AddItem_ID.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(372, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Origin:";
            // 
            // TextBox_AddItem_Origin
            // 
            this.TextBox_AddItem_Origin.Location = new System.Drawing.Point(411, 13);
            this.TextBox_AddItem_Origin.Name = "TextBox_AddItem_Origin";
            this.TextBox_AddItem_Origin.Size = new System.Drawing.Size(75, 20);
            this.TextBox_AddItem_Origin.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Price:";
            // 
            // TextBox_AddItem_Price
            // 
            this.TextBox_AddItem_Price.Location = new System.Drawing.Point(181, 40);
            this.TextBox_AddItem_Price.Name = "TextBox_AddItem_Price";
            this.TextBox_AddItem_Price.Size = new System.Drawing.Size(38, 20);
            this.TextBox_AddItem_Price.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(224, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Status:";
            // 
            // ComboBox_AddItem_Status
            // 
            this.ComboBox_AddItem_Status.FormattingEnabled = true;
            this.ComboBox_AddItem_Status.Items.AddRange(new object[] {
            "In stock",
            "Out of stock",
            "Pending"});
            this.ComboBox_AddItem_Status.Location = new System.Drawing.Point(275, 38);
            this.ComboBox_AddItem_Status.Name = "ComboBox_AddItem_Status";
            this.ComboBox_AddItem_Status.Size = new System.Drawing.Size(91, 21);
            this.ComboBox_AddItem_Status.TabIndex = 13;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ComboBox_AddItem_Status);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.TextBox_AddItem_ID);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.TextBox_AddItem_Price);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.TextBox_AddItem_Quantity);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.TextBox_AddItem_Origin);
            this.groupBox7.Controls.Add(this.TextBox_AddItem_ItemName);
            this.groupBox7.Location = new System.Drawing.Point(0, 11);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(492, 66);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Item Info";
            // 
            // ListView_ItemRange
            // 
            this.ListView_ItemRange.Location = new System.Drawing.Point(6, 17);
            this.ListView_ItemRange.Name = "ListView_ItemRange";
            this.ListView_ItemRange.Size = new System.Drawing.Size(468, 124);
            this.ListView_ItemRange.TabIndex = 1;
            this.ListView_ItemRange.UseCompatibleStateImageBehavior = false;
            this.ListView_ItemRange.View = System.Windows.Forms.View.List;
            this.ListView_ItemRange.SelectedIndexChanged += new System.EventHandler(this.ListView_ItemRange_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Label_Item_Quantity
            // 
            this.Label_Item_Quantity.AutoSize = true;
            this.Label_Item_Quantity.Location = new System.Drawing.Point(7, 138);
            this.Label_Item_Quantity.Name = "Label_Item_Quantity";
            this.Label_Item_Quantity.Size = new System.Drawing.Size(49, 13);
            this.Label_Item_Quantity.TabIndex = 7;
            this.Label_Item_Quantity.Text = "Quantity:";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.System_Log);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Item_Picture)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox System_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label_Item_Price;
        private System.Windows.Forms.Label Label_Item_Status;
        private System.Windows.Forms.Label Label_Item_Name;
        private System.Windows.Forms.Label Label_Item_Origin;
        private System.Windows.Forms.Label Label_Item_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox PictureBox_Item_Picture;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox ComboBox_AddItem_Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextBox_AddItem_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBox_AddItem_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBox_AddItem_Quantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBox_AddItem_Origin;
        private System.Windows.Forms.TextBox TextBox_AddItem_ItemName;
        private System.Windows.Forms.Button Button_Add_Item;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView ListView_ItemRange;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Label_Item_Quantity;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

