namespace Bank_System_GUI
{
    partial class LoanMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanMenu));
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCheck = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelAdd = new MetroFramework.Controls.MetroPanel();
            this.enteryPayment_txt = new MetroFramework.Controls.MetroTextBox();
            this.btnAddAmn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelCheck = new MetroFramework.Controls.MetroPanel();
            this.CurrentBalance_txt = new MetroFramework.Controls.MetroTextBox();
            this.Payment_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PanelAdd.SuspendLayout();
            this.PanelCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add monthly payment";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(13, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(126, 57);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add monthly payment";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.BorderRadius = 0;
            this.btnCheck.ButtonText = "Check remaining";
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheck.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheck.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCheck.Iconimage")));
            this.btnCheck.Iconimage_right = null;
            this.btnCheck.Iconimage_right_Selected = null;
            this.btnCheck.Iconimage_Selected = null;
            this.btnCheck.IconMarginLeft = 0;
            this.btnCheck.IconMarginRight = 0;
            this.btnCheck.IconRightVisible = true;
            this.btnCheck.IconRightZoom = 0D;
            this.btnCheck.IconVisible = true;
            this.btnCheck.IconZoom = 90D;
            this.btnCheck.IsTab = false;
            this.btnCheck.Location = new System.Drawing.Point(13, 209);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCheck.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCheck.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheck.selected = false;
            this.btnCheck.Size = new System.Drawing.Size(126, 55);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check remaining";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Textcolor = System.Drawing.Color.White;
            this.btnCheck.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.btnAddAmn);
            this.PanelAdd.Controls.Add(this.enteryPayment_txt);
            this.PanelAdd.HorizontalScrollbarBarColor = true;
            this.PanelAdd.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelAdd.HorizontalScrollbarSize = 10;
            this.PanelAdd.Location = new System.Drawing.Point(187, 73);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(281, 240);
            this.PanelAdd.TabIndex = 2;
            this.PanelAdd.VerticalScrollbarBarColor = true;
            this.PanelAdd.VerticalScrollbarHighlightOnWheel = false;
            this.PanelAdd.VerticalScrollbarSize = 10;
            // 
            // enteryPayment_txt
            // 
            // 
            // 
            // 
            this.enteryPayment_txt.CustomButton.Image = null;
            this.enteryPayment_txt.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.enteryPayment_txt.CustomButton.Name = "";
            this.enteryPayment_txt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.enteryPayment_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.enteryPayment_txt.CustomButton.TabIndex = 1;
            this.enteryPayment_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.enteryPayment_txt.CustomButton.UseSelectable = true;
            this.enteryPayment_txt.CustomButton.Visible = false;
            this.enteryPayment_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.enteryPayment_txt.Lines = new string[0];
            this.enteryPayment_txt.Location = new System.Drawing.Point(43, 42);
            this.enteryPayment_txt.MaxLength = 32767;
            this.enteryPayment_txt.Name = "enteryPayment_txt";
            this.enteryPayment_txt.PasswordChar = '\0';
            this.enteryPayment_txt.PromptText = "Enter amount";
            this.enteryPayment_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.enteryPayment_txt.SelectedText = "";
            this.enteryPayment_txt.SelectionLength = 0;
            this.enteryPayment_txt.SelectionStart = 0;
            this.enteryPayment_txt.ShortcutsEnabled = true;
            this.enteryPayment_txt.Size = new System.Drawing.Size(192, 25);
            this.enteryPayment_txt.TabIndex = 2;
            this.enteryPayment_txt.UseSelectable = true;
            this.enteryPayment_txt.WaterMark = "Enter amount";
            this.enteryPayment_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.enteryPayment_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddAmn
            // 
            this.btnAddAmn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAmn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAmn.BorderRadius = 0;
            this.btnAddAmn.ButtonText = "Add";
            this.btnAddAmn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAmn.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddAmn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddAmn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddAmn.Iconimage")));
            this.btnAddAmn.Iconimage_right = null;
            this.btnAddAmn.Iconimage_right_Selected = null;
            this.btnAddAmn.Iconimage_Selected = null;
            this.btnAddAmn.IconMarginLeft = 0;
            this.btnAddAmn.IconMarginRight = 0;
            this.btnAddAmn.IconRightVisible = true;
            this.btnAddAmn.IconRightZoom = 0D;
            this.btnAddAmn.IconVisible = true;
            this.btnAddAmn.IconZoom = 90D;
            this.btnAddAmn.IsTab = false;
            this.btnAddAmn.Location = new System.Drawing.Point(84, 143);
            this.btnAddAmn.Name = "btnAddAmn";
            this.btnAddAmn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAmn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddAmn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddAmn.selected = false;
            this.btnAddAmn.Size = new System.Drawing.Size(109, 48);
            this.btnAddAmn.TabIndex = 3;
            this.btnAddAmn.Text = "Add";
            this.btnAddAmn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAmn.Textcolor = System.Drawing.Color.White;
            this.btnAddAmn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAmn.Click += new System.EventHandler(this.btnAddAmn_Click);
            // 
            // PanelCheck
            // 
            this.PanelCheck.Controls.Add(this.metroLabel2);
            this.PanelCheck.Controls.Add(this.metroLabel1);
            this.PanelCheck.Controls.Add(this.Payment_txt);
            this.PanelCheck.Controls.Add(this.CurrentBalance_txt);
            this.PanelCheck.HorizontalScrollbarBarColor = true;
            this.PanelCheck.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelCheck.HorizontalScrollbarSize = 10;
            this.PanelCheck.Location = new System.Drawing.Point(187, 73);
            this.PanelCheck.Name = "PanelCheck";
            this.PanelCheck.Size = new System.Drawing.Size(281, 240);
            this.PanelCheck.TabIndex = 4;
            this.PanelCheck.VerticalScrollbarBarColor = true;
            this.PanelCheck.VerticalScrollbarHighlightOnWheel = false;
            this.PanelCheck.VerticalScrollbarSize = 10;
            // 
            // CurrentBalance_txt
            // 
            // 
            // 
            // 
            this.CurrentBalance_txt.CustomButton.Image = null;
            this.CurrentBalance_txt.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.CurrentBalance_txt.CustomButton.Name = "";
            this.CurrentBalance_txt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.CurrentBalance_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CurrentBalance_txt.CustomButton.TabIndex = 1;
            this.CurrentBalance_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CurrentBalance_txt.CustomButton.UseSelectable = true;
            this.CurrentBalance_txt.CustomButton.Visible = false;
            this.CurrentBalance_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CurrentBalance_txt.Lines = new string[0];
            this.CurrentBalance_txt.Location = new System.Drawing.Point(126, 42);
            this.CurrentBalance_txt.MaxLength = 32767;
            this.CurrentBalance_txt.Name = "CurrentBalance_txt";
            this.CurrentBalance_txt.PasswordChar = '\0';
            this.CurrentBalance_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CurrentBalance_txt.SelectedText = "";
            this.CurrentBalance_txt.SelectionLength = 0;
            this.CurrentBalance_txt.SelectionStart = 0;
            this.CurrentBalance_txt.ShortcutsEnabled = true;
            this.CurrentBalance_txt.Size = new System.Drawing.Size(109, 25);
            this.CurrentBalance_txt.TabIndex = 2;
            this.CurrentBalance_txt.UseSelectable = true;
            this.CurrentBalance_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CurrentBalance_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment_txt
            // 
            // 
            // 
            // 
            this.Payment_txt.CustomButton.Image = null;
            this.Payment_txt.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.Payment_txt.CustomButton.Name = "";
            this.Payment_txt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Payment_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_txt.CustomButton.TabIndex = 1;
            this.Payment_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_txt.CustomButton.UseSelectable = true;
            this.Payment_txt.CustomButton.Visible = false;
            this.Payment_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Payment_txt.Lines = new string[0];
            this.Payment_txt.Location = new System.Drawing.Point(126, 136);
            this.Payment_txt.MaxLength = 32767;
            this.Payment_txt.Name = "Payment_txt";
            this.Payment_txt.PasswordChar = '\0';
            this.Payment_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_txt.SelectedText = "";
            this.Payment_txt.SelectionLength = 0;
            this.Payment_txt.SelectionStart = 0;
            this.Payment_txt.ShortcutsEnabled = true;
            this.Payment_txt.Size = new System.Drawing.Size(109, 25);
            this.Payment_txt.TabIndex = 3;
            this.Payment_txt.UseSelectable = true;
            this.Payment_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Current Loan :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Total payment :";
            // 
            // LoanMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 367);
            this.Controls.Add(this.PanelCheck);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnAdd);
            this.Name = "LoanMenu";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Choose option";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoanMenu_FormClosed);
            this.Load += new System.EventHandler(this.LoanMenu_Load);
            this.PanelAdd.ResumeLayout(false);
            this.PanelCheck.ResumeLayout(false);
            this.PanelCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheck;
        private MetroFramework.Controls.MetroPanel PanelAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddAmn;
        private MetroFramework.Controls.MetroTextBox enteryPayment_txt;
        private MetroFramework.Controls.MetroPanel PanelCheck;
        private MetroFramework.Controls.MetroTextBox Payment_txt;
        private MetroFramework.Controls.MetroTextBox CurrentBalance_txt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}