namespace Bank_System_GUI
{
    partial class CheckingMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckingMenu));
            this.btnDeposite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnWithdraw = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBalance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelDeposite = new MetroFramework.Controls.MetroPanel();
            this.btnDepAmount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDeposite = new MetroFramework.Controls.MetroTextBox();
            this.PanelWithdraw = new MetroFramework.Controls.MetroPanel();
            this.btnWithdrawAmount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtWithdraw = new MetroFramework.Controls.MetroTextBox();
            this.PanelDeposite.SuspendLayout();
            this.PanelWithdraw.SuspendLayout();
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
            this.btnDeposite.Location = new System.Drawing.Point(23, 110);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeposite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeposite.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeposite.selected = false;
            this.btnDeposite.Size = new System.Drawing.Size(150, 48);
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
            this.btnWithdraw.Location = new System.Drawing.Point(23, 203);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithdraw.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnWithdraw.OnHoverTextColor = System.Drawing.Color.White;
            this.btnWithdraw.selected = false;
            this.btnWithdraw.Size = new System.Drawing.Size(150, 48);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Textcolor = System.Drawing.Color.White;
            this.btnWithdraw.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBalance.BorderRadius = 0;
            this.btnBalance.ButtonText = "Balance";
            this.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalance.DisabledColor = System.Drawing.Color.Gray;
            this.btnBalance.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBalance.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBalance.Iconimage")));
            this.btnBalance.Iconimage_right = null;
            this.btnBalance.Iconimage_right_Selected = null;
            this.btnBalance.Iconimage_Selected = null;
            this.btnBalance.IconMarginLeft = 0;
            this.btnBalance.IconMarginRight = 0;
            this.btnBalance.IconRightVisible = true;
            this.btnBalance.IconRightZoom = 0D;
            this.btnBalance.IconVisible = true;
            this.btnBalance.IconZoom = 90D;
            this.btnBalance.IsTab = false;
            this.btnBalance.Location = new System.Drawing.Point(23, 294);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBalance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBalance.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBalance.selected = false;
            this.btnBalance.Size = new System.Drawing.Size(150, 48);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "Balance";
            this.btnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalance.Textcolor = System.Drawing.Color.White;
            this.btnBalance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // PanelDeposite
            // 
            this.PanelDeposite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PanelDeposite.Controls.Add(this.btnDepAmount);
            this.PanelDeposite.Controls.Add(this.txtDeposite);
            this.PanelDeposite.HorizontalScrollbarBarColor = true;
            this.PanelDeposite.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelDeposite.HorizontalScrollbarSize = 10;
            this.PanelDeposite.Location = new System.Drawing.Point(195, 87);
            this.PanelDeposite.Name = "PanelDeposite";
            this.PanelDeposite.Size = new System.Drawing.Size(319, 279);
            this.PanelDeposite.TabIndex = 3;
            this.PanelDeposite.VerticalScrollbarBarColor = true;
            this.PanelDeposite.VerticalScrollbarHighlightOnWheel = false;
            this.PanelDeposite.VerticalScrollbarSize = 10;
            // 
            // btnDepAmount
            // 
            this.btnDepAmount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDepAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDepAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepAmount.BorderRadius = 0;
            this.btnDepAmount.ButtonText = "Deposite";
            this.btnDepAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepAmount.DisabledColor = System.Drawing.Color.Gray;
            this.btnDepAmount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDepAmount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDepAmount.Iconimage")));
            this.btnDepAmount.Iconimage_right = null;
            this.btnDepAmount.Iconimage_right_Selected = null;
            this.btnDepAmount.Iconimage_Selected = null;
            this.btnDepAmount.IconMarginLeft = 0;
            this.btnDepAmount.IconMarginRight = 0;
            this.btnDepAmount.IconRightVisible = true;
            this.btnDepAmount.IconRightZoom = 0D;
            this.btnDepAmount.IconVisible = true;
            this.btnDepAmount.IconZoom = 90D;
            this.btnDepAmount.IsTab = false;
            this.btnDepAmount.Location = new System.Drawing.Point(76, 174);
            this.btnDepAmount.Name = "btnDepAmount";
            this.btnDepAmount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDepAmount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDepAmount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDepAmount.selected = false;
            this.btnDepAmount.Size = new System.Drawing.Size(136, 48);
            this.btnDepAmount.TabIndex = 3;
            this.btnDepAmount.Text = "Deposite";
            this.btnDepAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepAmount.Textcolor = System.Drawing.Color.White;
            this.btnDepAmount.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepAmount.Click += new System.EventHandler(this.btnDepAmount_Click);
            // 
            // txtDeposite
            // 
            // 
            // 
            // 
            this.txtDeposite.CustomButton.Image = null;
            this.txtDeposite.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtDeposite.CustomButton.Name = "";
            this.txtDeposite.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDeposite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeposite.CustomButton.TabIndex = 1;
            this.txtDeposite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeposite.CustomButton.UseSelectable = true;
            this.txtDeposite.CustomButton.Visible = false;
            this.txtDeposite.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDeposite.Lines = new string[0];
            this.txtDeposite.Location = new System.Drawing.Point(58, 81);
            this.txtDeposite.MaxLength = 32767;
            this.txtDeposite.Name = "txtDeposite";
            this.txtDeposite.PasswordChar = '\0';
            this.txtDeposite.PromptText = "Enter Amount";
            this.txtDeposite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeposite.SelectedText = "";
            this.txtDeposite.SelectionLength = 0;
            this.txtDeposite.SelectionStart = 0;
            this.txtDeposite.ShortcutsEnabled = true;
            this.txtDeposite.Size = new System.Drawing.Size(179, 25);
            this.txtDeposite.TabIndex = 2;
            this.txtDeposite.UseSelectable = true;
            this.txtDeposite.WaterMark = "Enter Amount";
            this.txtDeposite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeposite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PanelWithdraw
            // 
            this.PanelWithdraw.BackColor = System.Drawing.Color.DarkGreen;
            this.PanelWithdraw.Controls.Add(this.btnWithdrawAmount);
            this.PanelWithdraw.Controls.Add(this.txtWithdraw);
            this.PanelWithdraw.HorizontalScrollbarBarColor = true;
            this.PanelWithdraw.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelWithdraw.HorizontalScrollbarSize = 10;
            this.PanelWithdraw.Location = new System.Drawing.Point(195, 87);
            this.PanelWithdraw.Name = "PanelWithdraw";
            this.PanelWithdraw.Size = new System.Drawing.Size(319, 279);
            this.PanelWithdraw.TabIndex = 4;
            this.PanelWithdraw.VerticalScrollbarBarColor = true;
            this.PanelWithdraw.VerticalScrollbarHighlightOnWheel = false;
            this.PanelWithdraw.VerticalScrollbarSize = 10;
            // 
            // btnWithdrawAmount
            // 
            this.btnWithdrawAmount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithdrawAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWithdrawAmount.BorderRadius = 0;
            this.btnWithdrawAmount.ButtonText = "Withdraw";
            this.btnWithdrawAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdrawAmount.DisabledColor = System.Drawing.Color.Gray;
            this.btnWithdrawAmount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWithdrawAmount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWithdrawAmount.Iconimage")));
            this.btnWithdrawAmount.Iconimage_right = null;
            this.btnWithdrawAmount.Iconimage_right_Selected = null;
            this.btnWithdrawAmount.Iconimage_Selected = null;
            this.btnWithdrawAmount.IconMarginLeft = 0;
            this.btnWithdrawAmount.IconMarginRight = 0;
            this.btnWithdrawAmount.IconRightVisible = true;
            this.btnWithdrawAmount.IconRightZoom = 0D;
            this.btnWithdrawAmount.IconVisible = true;
            this.btnWithdrawAmount.IconZoom = 90D;
            this.btnWithdrawAmount.IsTab = false;
            this.btnWithdrawAmount.Location = new System.Drawing.Point(76, 174);
            this.btnWithdrawAmount.Name = "btnWithdrawAmount";
            this.btnWithdrawAmount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWithdrawAmount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnWithdrawAmount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnWithdrawAmount.selected = false;
            this.btnWithdrawAmount.Size = new System.Drawing.Size(136, 48);
            this.btnWithdrawAmount.TabIndex = 3;
            this.btnWithdrawAmount.Text = "Withdraw";
            this.btnWithdrawAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdrawAmount.Textcolor = System.Drawing.Color.White;
            this.btnWithdrawAmount.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawAmount.Click += new System.EventHandler(this.btnWithdrawAmount_Click);
            // 
            // txtWithdraw
            // 
            // 
            // 
            // 
            this.txtWithdraw.CustomButton.Image = null;
            this.txtWithdraw.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtWithdraw.CustomButton.Name = "";
            this.txtWithdraw.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtWithdraw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWithdraw.CustomButton.TabIndex = 1;
            this.txtWithdraw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWithdraw.CustomButton.UseSelectable = true;
            this.txtWithdraw.CustomButton.Visible = false;
            this.txtWithdraw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWithdraw.Lines = new string[0];
            this.txtWithdraw.Location = new System.Drawing.Point(58, 81);
            this.txtWithdraw.MaxLength = 32767;
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.PasswordChar = '\0';
            this.txtWithdraw.PromptText = "Enter Amount";
            this.txtWithdraw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWithdraw.SelectedText = "";
            this.txtWithdraw.SelectionLength = 0;
            this.txtWithdraw.SelectionStart = 0;
            this.txtWithdraw.ShortcutsEnabled = true;
            this.txtWithdraw.Size = new System.Drawing.Size(179, 25);
            this.txtWithdraw.TabIndex = 2;
            this.txtWithdraw.UseSelectable = true;
            this.txtWithdraw.WaterMark = "Enter Amount";
            this.txtWithdraw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWithdraw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CheckingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 409);
            this.Controls.Add(this.PanelWithdraw);
            this.Controls.Add(this.PanelDeposite);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposite);
            this.Name = "CheckingMenu";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Choose an option";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckingMenu_FormClosed);
            this.Load += new System.EventHandler(this.CheckingMenu_Load);
            this.PanelDeposite.ResumeLayout(false);
            this.PanelWithdraw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnDeposite;
        private Bunifu.Framework.UI.BunifuFlatButton btnWithdraw;
        private Bunifu.Framework.UI.BunifuFlatButton btnBalance;
        private MetroFramework.Controls.MetroPanel PanelDeposite;
        private Bunifu.Framework.UI.BunifuFlatButton btnDepAmount;
        private MetroFramework.Controls.MetroTextBox txtDeposite;
        private MetroFramework.Controls.MetroPanel PanelWithdraw;
        private Bunifu.Framework.UI.BunifuFlatButton btnWithdrawAmount;
        private MetroFramework.Controls.MetroTextBox txtWithdraw;
    }
}