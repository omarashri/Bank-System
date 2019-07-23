namespace Bank_System_GUI
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Bank_System_GUI.DataSet1();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSearchID = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Passtxt = new MetroFramework.Controls.MetroTextBox();
            this.Lnametxt = new MetroFramework.Controls.MetroTextBox();
            this.Fnametxt = new MetroFramework.Controls.MetroTextBox();
            this.idtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.ID_txt = new MetroFramework.Controls.MetroTextBox();
            this.btnView = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.txtAccID = new MetroFramework.Controls.MetroTextBox();
            this.txtNewAccID = new MetroFramework.Controls.MetroTextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboNewAccType = new System.Windows.Forms.ComboBox();
            this.txtNewID = new MetroFramework.Controls.MetroTextBox();
            this.txtNewBalance = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPassAgain = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.comboAccType = new System.Windows.Forms.ComboBox();
            this.txtBalance = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.radNewUser = new MetroFramework.Controls.MetroRadioButton();
            this.radExistedUser = new MetroFramework.Controls.MetroRadioButton();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new Bank_System_GUI.DataSet1TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search by ID";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(18, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(134, 48);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search by ID";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccount.BorderRadius = 0;
            this.btnAddAccount.ButtonText = "Add account";
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddAccount.Iconimage = null;
            this.btnAddAccount.Iconimage_right = null;
            this.btnAddAccount.Iconimage_right_Selected = null;
            this.btnAddAccount.Iconimage_Selected = null;
            this.btnAddAccount.IconMarginLeft = 0;
            this.btnAddAccount.IconMarginRight = 0;
            this.btnAddAccount.IconRightVisible = true;
            this.btnAddAccount.IconRightZoom = 0D;
            this.btnAddAccount.IconVisible = true;
            this.btnAddAccount.IconZoom = 90D;
            this.btnAddAccount.IsTab = false;
            this.btnAddAccount.Location = new System.Drawing.Point(18, 242);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddAccount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddAccount.selected = false;
            this.btnAddAccount.Size = new System.Drawing.Size(134, 48);
            this.btnAddAccount.TabIndex = 14;
            this.btnAddAccount.Text = "Add account";
            this.btnAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAccount.Textcolor = System.Drawing.Color.White;
            this.btnAddAccount.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.metroLabel6);
            this.pnlSearch.Controls.Add(this.metroLabel5);
            this.pnlSearch.Controls.Add(this.metroLabel4);
            this.pnlSearch.Controls.Add(this.metroLabel3);
            this.pnlSearch.Controls.Add(this.metroLabel2);
            this.pnlSearch.Controls.Add(this.metroLabel1);
            this.pnlSearch.Controls.Add(this.btnSearchID);
            this.pnlSearch.Controls.Add(this.Passtxt);
            this.pnlSearch.Controls.Add(this.Lnametxt);
            this.pnlSearch.Controls.Add(this.Fnametxt);
            this.pnlSearch.Controls.Add(this.idtxt);
            this.pnlSearch.Controls.Add(this.metroListView1);
            this.pnlSearch.Controls.Add(this.ID_txt);
            this.pnlSearch.Location = new System.Drawing.Point(178, 107);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(641, 392);
            this.pnlSearch.TabIndex = 15;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(266, 184);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 25);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Accounts :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(29, 24);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Enter ID :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 255);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Password :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Last Name :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 155);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "First Name :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(28, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "ID :";
            // 
            // btnSearchID
            // 
            this.btnSearchID.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearchID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchID.BorderRadius = 0;
            this.btnSearchID.ButtonText = "Search";
            this.btnSearchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchID.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchID.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchID.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearchID.Iconimage")));
            this.btnSearchID.Iconimage_right = null;
            this.btnSearchID.Iconimage_right_Selected = null;
            this.btnSearchID.Iconimage_Selected = null;
            this.btnSearchID.IconMarginLeft = 0;
            this.btnSearchID.IconMarginRight = 0;
            this.btnSearchID.IconRightVisible = true;
            this.btnSearchID.IconRightZoom = 0D;
            this.btnSearchID.IconVisible = true;
            this.btnSearchID.IconZoom = 90D;
            this.btnSearchID.IsTab = false;
            this.btnSearchID.Location = new System.Drawing.Point(416, 8);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearchID.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearchID.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchID.selected = false;
            this.btnSearchID.Size = new System.Drawing.Size(140, 44);
            this.btnSearchID.TabIndex = 19;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchID.Textcolor = System.Drawing.Color.White;
            this.btnSearchID.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // Passtxt
            // 
            // 
            // 
            // 
            this.Passtxt.CustomButton.Image = null;
            this.Passtxt.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.Passtxt.CustomButton.Name = "";
            this.Passtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Passtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Passtxt.CustomButton.TabIndex = 1;
            this.Passtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passtxt.CustomButton.UseSelectable = true;
            this.Passtxt.CustomButton.Visible = false;
            this.Passtxt.Lines = new string[0];
            this.Passtxt.Location = new System.Drawing.Point(127, 255);
            this.Passtxt.MaxLength = 32767;
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '\0';
            this.Passtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Passtxt.SelectedText = "";
            this.Passtxt.SelectionLength = 0;
            this.Passtxt.SelectionStart = 0;
            this.Passtxt.ShortcutsEnabled = true;
            this.Passtxt.Size = new System.Drawing.Size(120, 23);
            this.Passtxt.TabIndex = 18;
            this.Passtxt.UseSelectable = true;
            this.Passtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Passtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lnametxt
            // 
            // 
            // 
            // 
            this.Lnametxt.CustomButton.Image = null;
            this.Lnametxt.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.Lnametxt.CustomButton.Name = "";
            this.Lnametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Lnametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Lnametxt.CustomButton.TabIndex = 1;
            this.Lnametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Lnametxt.CustomButton.UseSelectable = true;
            this.Lnametxt.CustomButton.Visible = false;
            this.Lnametxt.Lines = new string[0];
            this.Lnametxt.Location = new System.Drawing.Point(127, 204);
            this.Lnametxt.MaxLength = 32767;
            this.Lnametxt.Name = "Lnametxt";
            this.Lnametxt.PasswordChar = '\0';
            this.Lnametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Lnametxt.SelectedText = "";
            this.Lnametxt.SelectionLength = 0;
            this.Lnametxt.SelectionStart = 0;
            this.Lnametxt.ShortcutsEnabled = true;
            this.Lnametxt.Size = new System.Drawing.Size(120, 23);
            this.Lnametxt.TabIndex = 17;
            this.Lnametxt.UseSelectable = true;
            this.Lnametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lnametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Fnametxt
            // 
            // 
            // 
            // 
            this.Fnametxt.CustomButton.Image = null;
            this.Fnametxt.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.Fnametxt.CustomButton.Name = "";
            this.Fnametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Fnametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Fnametxt.CustomButton.TabIndex = 1;
            this.Fnametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Fnametxt.CustomButton.UseSelectable = true;
            this.Fnametxt.CustomButton.Visible = false;
            this.Fnametxt.Lines = new string[0];
            this.Fnametxt.Location = new System.Drawing.Point(127, 155);
            this.Fnametxt.MaxLength = 32767;
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.PasswordChar = '\0';
            this.Fnametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Fnametxt.SelectedText = "";
            this.Fnametxt.SelectionLength = 0;
            this.Fnametxt.SelectionStart = 0;
            this.Fnametxt.ShortcutsEnabled = true;
            this.Fnametxt.Size = new System.Drawing.Size(120, 23);
            this.Fnametxt.TabIndex = 16;
            this.Fnametxt.UseSelectable = true;
            this.Fnametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Fnametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idtxt
            // 
            // 
            // 
            // 
            this.idtxt.CustomButton.Image = null;
            this.idtxt.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.idtxt.CustomButton.Name = "";
            this.idtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idtxt.CustomButton.TabIndex = 1;
            this.idtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idtxt.CustomButton.UseSelectable = true;
            this.idtxt.CustomButton.Visible = false;
            this.idtxt.Lines = new string[0];
            this.idtxt.Location = new System.Drawing.Point(127, 97);
            this.idtxt.MaxLength = 32767;
            this.idtxt.Name = "idtxt";
            this.idtxt.PasswordChar = '\0';
            this.idtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idtxt.SelectedText = "";
            this.idtxt.SelectionLength = 0;
            this.idtxt.SelectionStart = 0;
            this.idtxt.ShortcutsEnabled = true;
            this.idtxt.Size = new System.Drawing.Size(120, 23);
            this.idtxt.TabIndex = 15;
            this.idtxt.UseSelectable = true;
            this.idtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroListView1
            // 
            this.metroListView1.AutoArrange = false;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.LabelEdit = true;
            this.metroListView1.Location = new System.Drawing.Point(362, 76);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(246, 263);
            this.metroListView1.TabIndex = 14;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.List;
            // 
            // ID_txt
            // 
            // 
            // 
            // 
            this.ID_txt.CustomButton.Image = null;
            this.ID_txt.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.ID_txt.CustomButton.Name = "";
            this.ID_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ID_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ID_txt.CustomButton.TabIndex = 1;
            this.ID_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ID_txt.CustomButton.UseSelectable = true;
            this.ID_txt.CustomButton.Visible = false;
            this.ID_txt.Lines = new string[0];
            this.ID_txt.Location = new System.Drawing.Point(124, 20);
            this.ID_txt.MaxLength = 32767;
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.PasswordChar = '\0';
            this.ID_txt.PromptText = "ID";
            this.ID_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ID_txt.SelectedText = "";
            this.ID_txt.SelectionLength = 0;
            this.ID_txt.SelectionStart = 0;
            this.ID_txt.ShortcutsEnabled = true;
            this.ID_txt.Size = new System.Drawing.Size(123, 23);
            this.ID_txt.TabIndex = 13;
            this.ID_txt.UseSelectable = true;
            this.ID_txt.WaterMark = "ID";
            this.ID_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ID_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnView
            // 
            this.btnView.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.BorderRadius = 0;
            this.btnView.ButtonText = "View all";
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.DisabledColor = System.Drawing.Color.Gray;
            this.btnView.Iconcolor = System.Drawing.Color.Transparent;
            this.btnView.Iconimage = null;
            this.btnView.Iconimage_right = null;
            this.btnView.Iconimage_right_Selected = null;
            this.btnView.Iconimage_Selected = null;
            this.btnView.IconMarginLeft = 0;
            this.btnView.IconMarginRight = 0;
            this.btnView.IconRightVisible = true;
            this.btnView.IconRightZoom = 0D;
            this.btnView.IconVisible = true;
            this.btnView.IconZoom = 90D;
            this.btnView.IsTab = false;
            this.btnView.Location = new System.Drawing.Point(18, 354);
            this.btnView.Name = "btnView";
            this.btnView.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnView.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnView.OnHoverTextColor = System.Drawing.Color.White;
            this.btnView.selected = false;
            this.btnView.Size = new System.Drawing.Size(134, 48);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "View all";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnView.Textcolor = System.Drawing.Color.White;
            this.btnView.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.txtAccID);
            this.pnlAdd.Controls.Add(this.txtNewAccID);
            this.pnlAdd.Controls.Add(this.lblPass);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.comboNewAccType);
            this.pnlAdd.Controls.Add(this.txtNewID);
            this.pnlAdd.Controls.Add(this.txtNewBalance);
            this.pnlAdd.Controls.Add(this.txtNewPassAgain);
            this.pnlAdd.Controls.Add(this.txtNewPass);
            this.pnlAdd.Controls.Add(this.txtLastName);
            this.pnlAdd.Controls.Add(this.txtFirstName);
            this.pnlAdd.Controls.Add(this.comboAccType);
            this.pnlAdd.Controls.Add(this.txtBalance);
            this.pnlAdd.Controls.Add(this.txtID);
            this.pnlAdd.Controls.Add(this.radNewUser);
            this.pnlAdd.Controls.Add(this.radExistedUser);
            this.pnlAdd.Location = new System.Drawing.Point(158, 63);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(700, 452);
            this.pnlAdd.TabIndex = 26;
            // 
            // txtAccID
            // 
            // 
            // 
            // 
            this.txtAccID.CustomButton.Image = null;
            this.txtAccID.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtAccID.CustomButton.Name = "";
            this.txtAccID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAccID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccID.CustomButton.TabIndex = 1;
            this.txtAccID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccID.CustomButton.UseSelectable = true;
            this.txtAccID.CustomButton.Visible = false;
            this.txtAccID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAccID.Lines = new string[0];
            this.txtAccID.Location = new System.Drawing.Point(270, 107);
            this.txtAccID.MaxLength = 32767;
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.PasswordChar = '\0';
            this.txtAccID.PromptText = "Account ID";
            this.txtAccID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccID.SelectedText = "";
            this.txtAccID.SelectionLength = 0;
            this.txtAccID.SelectionStart = 0;
            this.txtAccID.ShortcutsEnabled = true;
            this.txtAccID.Size = new System.Drawing.Size(129, 25);
            this.txtAccID.TabIndex = 17;
            this.txtAccID.UseSelectable = true;
            this.txtAccID.WaterMark = "Account ID";
            this.txtAccID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewAccID
            // 
            // 
            // 
            // 
            this.txtNewAccID.CustomButton.Image = null;
            this.txtNewAccID.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtNewAccID.CustomButton.Name = "";
            this.txtNewAccID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNewAccID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewAccID.CustomButton.TabIndex = 1;
            this.txtNewAccID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewAccID.CustomButton.UseSelectable = true;
            this.txtNewAccID.CustomButton.Visible = false;
            this.txtNewAccID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewAccID.Lines = new string[0];
            this.txtNewAccID.Location = new System.Drawing.Point(297, 332);
            this.txtNewAccID.MaxLength = 32767;
            this.txtNewAccID.Name = "txtNewAccID";
            this.txtNewAccID.PasswordChar = '\0';
            this.txtNewAccID.PromptText = "Account ID";
            this.txtNewAccID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewAccID.SelectedText = "";
            this.txtNewAccID.SelectionLength = 0;
            this.txtNewAccID.SelectionStart = 0;
            this.txtNewAccID.ShortcutsEnabled = true;
            this.txtNewAccID.Size = new System.Drawing.Size(129, 25);
            this.txtNewAccID.TabIndex = 16;
            this.txtNewAccID.UseSelectable = true;
            this.txtNewAccID.WaterMark = "Account ID";
            this.txtNewAccID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewAccID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.Red;
            this.lblPass.Location = new System.Drawing.Point(471, 271);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(128, 13);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Password doesn\'t match !";
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add";
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
            this.btnAdd.Location = new System.Drawing.Point(226, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(109, 48);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboNewAccType
            // 
            this.comboNewAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNewAccType.FormattingEnabled = true;
            this.comboNewAccType.Items.AddRange(new object[] {
            "Account type",
            "Saving",
            "Checking",
            "Loan"});
            this.comboNewAccType.Location = new System.Drawing.Point(391, 376);
            this.comboNewAccType.Name = "comboNewAccType";
            this.comboNewAccType.Size = new System.Drawing.Size(129, 24);
            this.comboNewAccType.TabIndex = 13;
            this.comboNewAccType.SelectedIndexChanged += new System.EventHandler(this.comboNewAccType_SelectedIndexChanged);
            // 
            // txtNewID
            // 
            // 
            // 
            // 
            this.txtNewID.CustomButton.Image = null;
            this.txtNewID.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtNewID.CustomButton.Name = "";
            this.txtNewID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNewID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewID.CustomButton.TabIndex = 1;
            this.txtNewID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewID.CustomButton.UseSelectable = true;
            this.txtNewID.CustomButton.Visible = false;
            this.txtNewID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewID.Lines = new string[0];
            this.txtNewID.Location = new System.Drawing.Point(378, 198);
            this.txtNewID.MaxLength = 32767;
            this.txtNewID.Name = "txtNewID";
            this.txtNewID.PasswordChar = '\0';
            this.txtNewID.PromptText = "ID";
            this.txtNewID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewID.SelectedText = "";
            this.txtNewID.SelectionLength = 0;
            this.txtNewID.SelectionStart = 0;
            this.txtNewID.ShortcutsEnabled = true;
            this.txtNewID.Size = new System.Drawing.Size(129, 25);
            this.txtNewID.TabIndex = 12;
            this.txtNewID.UseSelectable = true;
            this.txtNewID.WaterMark = "ID";
            this.txtNewID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewBalance
            // 
            // 
            // 
            // 
            this.txtNewBalance.CustomButton.Image = null;
            this.txtNewBalance.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtNewBalance.CustomButton.Name = "";
            this.txtNewBalance.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNewBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewBalance.CustomButton.TabIndex = 1;
            this.txtNewBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewBalance.CustomButton.UseSelectable = true;
            this.txtNewBalance.CustomButton.Visible = false;
            this.txtNewBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewBalance.Lines = new string[0];
            this.txtNewBalance.Location = new System.Drawing.Point(470, 332);
            this.txtNewBalance.MaxLength = 32767;
            this.txtNewBalance.Name = "txtNewBalance";
            this.txtNewBalance.PasswordChar = '\0';
            this.txtNewBalance.PromptText = "Balance";
            this.txtNewBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewBalance.SelectedText = "";
            this.txtNewBalance.SelectionLength = 0;
            this.txtNewBalance.SelectionStart = 0;
            this.txtNewBalance.ShortcutsEnabled = true;
            this.txtNewBalance.Size = new System.Drawing.Size(129, 25);
            this.txtNewBalance.TabIndex = 11;
            this.txtNewBalance.UseSelectable = true;
            this.txtNewBalance.WaterMark = "Balance";
            this.txtNewBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewPassAgain
            // 
            // 
            // 
            // 
            this.txtNewPassAgain.CustomButton.Image = null;
            this.txtNewPassAgain.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtNewPassAgain.CustomButton.Name = "";
            this.txtNewPassAgain.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNewPassAgain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassAgain.CustomButton.TabIndex = 1;
            this.txtNewPassAgain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassAgain.CustomButton.UseSelectable = true;
            this.txtNewPassAgain.CustomButton.Visible = false;
            this.txtNewPassAgain.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewPassAgain.Lines = new string[0];
            this.txtNewPassAgain.Location = new System.Drawing.Point(470, 287);
            this.txtNewPassAgain.MaxLength = 32767;
            this.txtNewPassAgain.Name = "txtNewPassAgain";
            this.txtNewPassAgain.PasswordChar = '●';
            this.txtNewPassAgain.PromptText = "Reenter password";
            this.txtNewPassAgain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassAgain.SelectedText = "";
            this.txtNewPassAgain.SelectionLength = 0;
            this.txtNewPassAgain.SelectionStart = 0;
            this.txtNewPassAgain.ShortcutsEnabled = true;
            this.txtNewPassAgain.Size = new System.Drawing.Size(129, 25);
            this.txtNewPassAgain.TabIndex = 9;
            this.txtNewPassAgain.UseSelectable = true;
            this.txtNewPassAgain.UseSystemPasswordChar = true;
            this.txtNewPassAgain.WaterMark = "Reenter password";
            this.txtNewPassAgain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassAgain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(297, 287);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PromptText = "Password";
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(129, 25);
            this.txtNewPass.TabIndex = 8;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.WaterMark = "Password";
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(470, 239);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PromptText = "Last Name";
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(129, 25);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMark = "Last Name";
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(297, 239);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PromptText = "First Name";
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(129, 25);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMark = "First Name";
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboAccType
            // 
            this.comboAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAccType.FormattingEnabled = true;
            this.comboAccType.Items.AddRange(new object[] {
            "Account Type",
            "Saving",
            "Checking",
            "Loan"});
            this.comboAccType.Location = new System.Drawing.Point(450, 106);
            this.comboAccType.Name = "comboAccType";
            this.comboAccType.Size = new System.Drawing.Size(129, 24);
            this.comboAccType.TabIndex = 5;
            // 
            // txtBalance
            // 
            // 
            // 
            // 
            this.txtBalance.CustomButton.Image = null;
            this.txtBalance.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtBalance.CustomButton.Name = "";
            this.txtBalance.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBalance.CustomButton.TabIndex = 1;
            this.txtBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBalance.CustomButton.UseSelectable = true;
            this.txtBalance.CustomButton.Visible = false;
            this.txtBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBalance.Lines = new string[0];
            this.txtBalance.Location = new System.Drawing.Point(450, 52);
            this.txtBalance.MaxLength = 32767;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PromptText = "User Balance";
            this.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBalance.SelectedText = "";
            this.txtBalance.SelectionLength = 0;
            this.txtBalance.SelectionStart = 0;
            this.txtBalance.ShortcutsEnabled = true;
            this.txtBalance.Size = new System.Drawing.Size(129, 25);
            this.txtBalance.TabIndex = 4;
            this.txtBalance.UseSelectable = true;
            this.txtBalance.WaterMark = "User Balance";
            this.txtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(270, 52);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PromptText = "User ID";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(129, 25);
            this.txtID.TabIndex = 2;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMark = "User ID";
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // radNewUser
            // 
            this.radNewUser.AutoSize = true;
            this.radNewUser.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radNewUser.Location = new System.Drawing.Point(19, 214);
            this.radNewUser.Name = "radNewUser";
            this.radNewUser.Size = new System.Drawing.Size(82, 19);
            this.radNewUser.Style = MetroFramework.MetroColorStyle.Green;
            this.radNewUser.TabIndex = 1;
            this.radNewUser.Text = "New user";
            this.radNewUser.UseSelectable = true;
            this.radNewUser.CheckedChanged += new System.EventHandler(this.radNewUser_CheckedChanged);
            // 
            // radExistedUser
            // 
            this.radExistedUser.AutoSize = true;
            this.radExistedUser.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radExistedUser.Location = new System.Drawing.Point(19, 75);
            this.radExistedUser.Name = "radExistedUser";
            this.radExistedUser.Size = new System.Drawing.Size(97, 19);
            this.radExistedUser.Style = MetroFramework.MetroColorStyle.Green;
            this.radExistedUser.TabIndex = 0;
            this.radExistedUser.Text = "Existed user";
            this.radExistedUser.UseSelectable = true;
            this.radExistedUser.CheckedChanged += new System.EventHandler(this.radExistedUser_CheckedChanged);
            // 
            // pnlReport
            // 
            this.pnlReport.AutoSize = true;
            this.pnlReport.Controls.Add(this.reportViewer1);
            this.pnlReport.Location = new System.Drawing.Point(161, 51);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(681, 483);
            this.pnlReport.TabIndex = 18;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bank_System_GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(658, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 538);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnSearch);
            this.Name = "AdminMenu";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Choose option";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenu_FormClosed);
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddAccount;
        private System.Windows.Forms.Panel pnlSearch;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchID;
        private MetroFramework.Controls.MetroTextBox Passtxt;
        private MetroFramework.Controls.MetroTextBox Lnametxt;
        private MetroFramework.Controls.MetroTextBox Fnametxt;
        private MetroFramework.Controls.MetroTextBox idtxt;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroTextBox ID_txt;
        private Bunifu.Framework.UI.BunifuFlatButton btnView;
        private System.Windows.Forms.Panel pnlAdd;
        private MetroFramework.Controls.MetroRadioButton radNewUser;
        private System.Windows.Forms.ComboBox comboNewAccType;
        private MetroFramework.Controls.MetroTextBox txtNewID;
        private MetroFramework.Controls.MetroTextBox txtNewBalance;
        private MetroFramework.Controls.MetroTextBox txtNewPassAgain;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.Label lblPass;
        private MetroFramework.Controls.MetroTextBox txtNewAccID;
        private MetroFramework.Controls.MetroTextBox txtAccID;
        private System.Windows.Forms.ComboBox comboAccType;
        private MetroFramework.Controls.MetroTextBox txtBalance;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroRadioButton radExistedUser;
    
        private System.Windows.Forms.Panel pnlReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}