namespace Bank_System_GUI
{
    partial class SavingMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingMenu));
            this.btnDeposite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnWithdraw = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelDeposite = new MetroFramework.Controls.MetroPanel();
            this.btnDepAmn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDeposite = new MetroFramework.Controls.MetroTextBox();
            this.PanelWithdraw = new MetroFramework.Controls.MetroPanel();
            this.btnWithAmn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtWithdraw = new MetroFramework.Controls.MetroTextBox();
            this.btnTransfer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.txtBalance = new MetroFramework.Controls.MetroTextBox();
            this.btnTransAmn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ComboTrans = new MetroFramework.Controls.MetroComboBox();
            this.PanelDeposite.SuspendLayout();
            this.PanelWithdraw.SuspendLayout();
            this.pnlTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeposite
            // 
            this.btnDeposite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeposite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeposite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeposite.BorderRadius = 0;
            this.btnDeposite.ButtonText = "Deposite";
            this.btnDeposite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposite.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeposite.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeposite.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeposite.Iconimage")));
            this.btnDeposite.Iconimage_right = null;
            this.btnDeposite.Iconimage_right_Selected = null;
            this.btnDeposite.Iconimage_Selected = null;
            this.btnDeposite.IconMarginLeft = 0;
            this.btnDeposite.IconMarginRight = 0;
            this.btnDeposite.IconRightVisible = true;
            this.btnDeposite.IconRightZoom = 0D;
            this.btnDeposite.IconVisible = true;
            this.btnDeposite.IconZoom = 90D;
            this.btnDeposite.IsTab = false;
            this.btnDeposite.Location = new System.Drawing.Point(23, 112);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeposite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeposite.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeposite.selected = false;
            this.btnDeposite.Size = new System.Drawing.Size(133, 48);
            this.btnDeposite.TabIndex = 0;
            this.btnDeposite.Text = "Deposite";
            this.btnDeposite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposite.Textcolor = System.Drawing.Color.White;
            this.btnDeposite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWithdraw.BorderRadius = 0;
            this.btnWithdraw.ButtonText = "Withdraw";
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.DisabledColor = System.Drawing.Color.Gray;
            this.btnWithdraw.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.Iconimage")));
            this.btnWithdraw.Iconimage_right = null;
            this.btnWithdraw.Iconimage_right_Selected = null;
            this.btnWithdraw.Iconimage_Selected = null;
            this.btnWithdraw.IconMarginLeft = 0;
            this.btnWithdraw.IconMarginRight = 0;
            this.btnWithdraw.IconRightVisible = true;
            this.btnWithdraw.IconRightZoom = 0D;
            this.btnWithdraw.IconVisible = true;
            this.btnWithdraw.IconZoom = 90D;
            this.btnWithdraw.IsTab = false;
            this.btnWithdraw.Location = new System.Drawing.Point(23, 184);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithdraw.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnWithdraw.OnHoverTextColor = System.Drawing.Color.White;
            this.btnWithdraw.selected = false;
            this.btnWithdraw.Size = new System.Drawing.Size(133, 48);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Textcolor = System.Drawing.Color.White;
            this.btnWithdraw.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Balance";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(23, 254);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(133, 48);
            this.bunifuFlatButton3.TabIndex = 2;
            this.bunifuFlatButton3.Text = "Balance";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // PanelDeposite
            // 
            this.PanelDeposite.Controls.Add(this.btnDepAmn);
            this.PanelDeposite.Controls.Add(this.txtDeposite);
            this.PanelDeposite.HorizontalScrollbarBarColor = true;
            this.PanelDeposite.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelDeposite.HorizontalScrollbarSize = 10;
            this.PanelDeposite.Location = new System.Drawing.Point(188, 112);
            this.PanelDeposite.Name = "PanelDeposite";
            this.PanelDeposite.Size = new System.Drawing.Size(314, 233);
            this.PanelDeposite.TabIndex = 3;
            this.PanelDeposite.VerticalScrollbarBarColor = true;
            this.PanelDeposite.VerticalScrollbarHighlightOnWheel = false;
            this.PanelDeposite.VerticalScrollbarSize = 10;
            // 
            // btnDepAmn
            // 
            this.btnDepAmn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDepAmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDepAmn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepAmn.BorderRadius = 0;
            this.btnDepAmn.ButtonText = "Deposite";
            this.btnDepAmn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepAmn.DisabledColor = System.Drawing.Color.Gray;
            this.btnDepAmn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDepAmn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDepAmn.Iconimage")));
            this.btnDepAmn.Iconimage_right = null;
            this.btnDepAmn.Iconimage_right_Selected = null;
            this.btnDepAmn.Iconimage_Selected = null;
            this.btnDepAmn.IconMarginLeft = 0;
            this.btnDepAmn.IconMarginRight = 0;
            this.btnDepAmn.IconRightVisible = true;
            this.btnDepAmn.IconRightZoom = 0D;
            this.btnDepAmn.IconVisible = true;
            this.btnDepAmn.IconZoom = 90D;
            this.btnDepAmn.IsTab = false;
            this.btnDepAmn.Location = new System.Drawing.Point(90, 138);
            this.btnDepAmn.Name = "btnDepAmn";
            this.btnDepAmn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDepAmn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDepAmn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDepAmn.selected = false;
            this.btnDepAmn.Size = new System.Drawing.Size(128, 48);
            this.btnDepAmn.TabIndex = 3;
            this.btnDepAmn.Text = "Deposite";
            this.btnDepAmn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepAmn.Textcolor = System.Drawing.Color.White;
            this.btnDepAmn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepAmn.Click += new System.EventHandler(this.btnDepAmn_Click);
            // 
            // txtDeposite
            // 
            // 
            // 
            // 
            this.txtDeposite.CustomButton.Image = null;
            this.txtDeposite.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtDeposite.CustomButton.Name = "";
            this.txtDeposite.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDeposite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeposite.CustomButton.TabIndex = 1;
            this.txtDeposite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeposite.CustomButton.UseSelectable = true;
            this.txtDeposite.CustomButton.Visible = false;
            this.txtDeposite.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDeposite.Lines = new string[0];
            this.txtDeposite.Location = new System.Drawing.Point(66, 55);
            this.txtDeposite.MaxLength = 32767;
            this.txtDeposite.Name = "txtDeposite";
            this.txtDeposite.PasswordChar = '\0';
            this.txtDeposite.PromptText = "Enter amount";
            this.txtDeposite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeposite.SelectedText = "";
            this.txtDeposite.SelectionLength = 0;
            this.txtDeposite.SelectionStart = 0;
            this.txtDeposite.ShortcutsEnabled = true;
            this.txtDeposite.Size = new System.Drawing.Size(171, 25);
            this.txtDeposite.TabIndex = 2;
            this.txtDeposite.UseSelectable = true;
            this.txtDeposite.WaterMark = "Enter amount";
            this.txtDeposite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeposite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PanelWithdraw
            // 
            this.PanelWithdraw.Controls.Add(this.btnWithAmn);
            this.PanelWithdraw.Controls.Add(this.txtWithdraw);
            this.PanelWithdraw.HorizontalScrollbarBarColor = true;
            this.PanelWithdraw.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelWithdraw.HorizontalScrollbarSize = 10;
            this.PanelWithdraw.Location = new System.Drawing.Point(188, 112);
            this.PanelWithdraw.Name = "PanelWithdraw";
            this.PanelWithdraw.Size = new System.Drawing.Size(314, 233);
            this.PanelWithdraw.TabIndex = 4;
            this.PanelWithdraw.VerticalScrollbarBarColor = true;
            this.PanelWithdraw.VerticalScrollbarHighlightOnWheel = false;
            this.PanelWithdraw.VerticalScrollbarSize = 10;
            // 
            // btnWithAmn
            // 
            this.btnWithAmn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithAmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithAmn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWithAmn.BorderRadius = 0;
            this.btnWithAmn.ButtonText = "Withdraw";
            this.btnWithAmn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithAmn.DisabledColor = System.Drawing.Color.Gray;
            this.btnWithAmn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWithAmn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWithAmn.Iconimage")));
            this.btnWithAmn.Iconimage_right = null;
            this.btnWithAmn.Iconimage_right_Selected = null;
            this.btnWithAmn.Iconimage_Selected = null;
            this.btnWithAmn.IconMarginLeft = 0;
            this.btnWithAmn.IconMarginRight = 0;
            this.btnWithAmn.IconRightVisible = true;
            this.btnWithAmn.IconRightZoom = 0D;
            this.btnWithAmn.IconVisible = true;
            this.btnWithAmn.IconZoom = 90D;
            this.btnWithAmn.IsTab = false;
            this.btnWithAmn.Location = new System.Drawing.Point(90, 138);
            this.btnWithAmn.Name = "btnWithAmn";
            this.btnWithAmn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithAmn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnWithAmn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnWithAmn.selected = false;
            this.btnWithAmn.Size = new System.Drawing.Size(127, 48);
            this.btnWithAmn.TabIndex = 3;
            this.btnWithAmn.Text = "Withdraw";
            this.btnWithAmn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithAmn.Textcolor = System.Drawing.Color.White;
            this.btnWithAmn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithAmn.Click += new System.EventHandler(this.btnWithAmn_Click);
            // 
            // txtWithdraw
            // 
            // 
            // 
            // 
            this.txtWithdraw.CustomButton.Image = null;
            this.txtWithdraw.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtWithdraw.CustomButton.Name = "";
            this.txtWithdraw.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtWithdraw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWithdraw.CustomButton.TabIndex = 1;
            this.txtWithdraw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWithdraw.CustomButton.UseSelectable = true;
            this.txtWithdraw.CustomButton.Visible = false;
            this.txtWithdraw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWithdraw.Lines = new string[0];
            this.txtWithdraw.Location = new System.Drawing.Point(66, 55);
            this.txtWithdraw.MaxLength = 32767;
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.PasswordChar = '\0';
            this.txtWithdraw.PromptText = "Enter amount";
            this.txtWithdraw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWithdraw.SelectedText = "";
            this.txtWithdraw.SelectionLength = 0;
            this.txtWithdraw.SelectionStart = 0;
            this.txtWithdraw.ShortcutsEnabled = true;
            this.txtWithdraw.Size = new System.Drawing.Size(172, 25);
            this.txtWithdraw.TabIndex = 2;
            this.txtWithdraw.UseSelectable = true;
            this.txtWithdraw.WaterMark = "Enter amount";
            this.txtWithdraw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWithdraw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransfer.BorderRadius = 0;
            this.btnTransfer.ButtonText = "Money Transfer";
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.DisabledColor = System.Drawing.Color.Gray;
            this.btnTransfer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTransfer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Iconimage")));
            this.btnTransfer.Iconimage_right = null;
            this.btnTransfer.Iconimage_right_Selected = null;
            this.btnTransfer.Iconimage_Selected = null;
            this.btnTransfer.IconMarginLeft = 0;
            this.btnTransfer.IconMarginRight = 0;
            this.btnTransfer.IconRightVisible = true;
            this.btnTransfer.IconRightZoom = 0D;
            this.btnTransfer.IconVisible = true;
            this.btnTransfer.IconZoom = 90D;
            this.btnTransfer.IsTab = false;
            this.btnTransfer.Location = new System.Drawing.Point(23, 334);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTransfer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTransfer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTransfer.selected = false;
            this.btnTransfer.Size = new System.Drawing.Size(133, 44);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Money Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Textcolor = System.Drawing.Color.White;
            this.btnTransfer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.Controls.Add(this.ComboTrans);
            this.pnlTransfer.Controls.Add(this.btnTransAmn);
            this.pnlTransfer.Controls.Add(this.txtBalance);
            this.pnlTransfer.Location = new System.Drawing.Point(188, 112);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(313, 243);
            this.pnlTransfer.TabIndex = 6;
            // 
            // txtBalance
            // 
            // 
            // 
            // 
            this.txtBalance.CustomButton.Image = null;
            this.txtBalance.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtBalance.CustomButton.Name = "";
            this.txtBalance.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBalance.CustomButton.TabIndex = 1;
            this.txtBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBalance.CustomButton.UseSelectable = true;
            this.txtBalance.CustomButton.Visible = false;
            this.txtBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBalance.Lines = new string[0];
            this.txtBalance.Location = new System.Drawing.Point(90, 107);
            this.txtBalance.MaxLength = 32767;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PromptText = "Enter amount";
            this.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBalance.SelectedText = "";
            this.txtBalance.SelectionLength = 0;
            this.txtBalance.SelectionStart = 0;
            this.txtBalance.ShortcutsEnabled = true;
            this.txtBalance.Size = new System.Drawing.Size(128, 25);
            this.txtBalance.TabIndex = 1;
            this.txtBalance.UseSelectable = true;
            this.txtBalance.WaterMark = "Enter amount";
            this.txtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnTransAmn
            // 
            this.btnTransAmn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTransAmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTransAmn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransAmn.BorderRadius = 0;
            this.btnTransAmn.ButtonText = "Transfer";
            this.btnTransAmn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransAmn.DisabledColor = System.Drawing.Color.Gray;
            this.btnTransAmn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTransAmn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTransAmn.Iconimage")));
            this.btnTransAmn.Iconimage_right = null;
            this.btnTransAmn.Iconimage_right_Selected = null;
            this.btnTransAmn.Iconimage_Selected = null;
            this.btnTransAmn.IconMarginLeft = 0;
            this.btnTransAmn.IconMarginRight = 0;
            this.btnTransAmn.IconRightVisible = true;
            this.btnTransAmn.IconRightZoom = 0D;
            this.btnTransAmn.IconVisible = true;
            this.btnTransAmn.IconZoom = 90D;
            this.btnTransAmn.IsTab = false;
            this.btnTransAmn.Location = new System.Drawing.Point(90, 182);
            this.btnTransAmn.Name = "btnTransAmn";
            this.btnTransAmn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTransAmn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTransAmn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTransAmn.selected = false;
            this.btnTransAmn.Size = new System.Drawing.Size(124, 39);
            this.btnTransAmn.TabIndex = 2;
            this.btnTransAmn.Text = "Transfer";
            this.btnTransAmn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransAmn.Textcolor = System.Drawing.Color.White;
            this.btnTransAmn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransAmn.Click += new System.EventHandler(this.btnTransAmn_Click);
            // 
            // ComboTrans
            // 
            this.ComboTrans.FormattingEnabled = true;
            this.ComboTrans.ItemHeight = 23;
            this.ComboTrans.Items.AddRange(new object[] {
            "Choose account"});
            this.ComboTrans.Location = new System.Drawing.Point(75, 28);
            this.ComboTrans.Name = "ComboTrans";
            this.ComboTrans.Size = new System.Drawing.Size(162, 29);
            this.ComboTrans.TabIndex = 3;
            this.ComboTrans.UseSelectable = true;
            // 
            // SavingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 410);
            this.Controls.Add(this.pnlTransfer);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.PanelWithdraw);
            this.Controls.Add(this.PanelDeposite);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposite);
            this.Name = "SavingMenu";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Choose option";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SavingMenu_FormClosed);
            this.Load += new System.EventHandler(this.SavingMenu_Load);
            this.PanelDeposite.ResumeLayout(false);
            this.PanelWithdraw.ResumeLayout(false);
            this.pnlTransfer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnDeposite;
        private Bunifu.Framework.UI.BunifuFlatButton btnWithdraw;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private MetroFramework.Controls.MetroPanel PanelDeposite;
        private MetroFramework.Controls.MetroTextBox txtDeposite;
        private Bunifu.Framework.UI.BunifuFlatButton btnDepAmn;
        private MetroFramework.Controls.MetroPanel PanelWithdraw;
        private Bunifu.Framework.UI.BunifuFlatButton btnWithAmn;
        private MetroFramework.Controls.MetroTextBox txtWithdraw;
        private Bunifu.Framework.UI.BunifuFlatButton btnTransfer;
        private System.Windows.Forms.Panel pnlTransfer;
        private MetroFramework.Controls.MetroTextBox txtBalance;
        private Bunifu.Framework.UI.BunifuFlatButton btnTransAmn;
        private MetroFramework.Controls.MetroComboBox ComboTrans;
    }
}