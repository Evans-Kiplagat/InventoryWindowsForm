namespace DeviceInventoryApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            listViewDevice = new ListView();
            lblDeviceTypesCount = new Label();
            panelTop = new Panel();
            btnRefresh = new Button();
            btnExport = new Button();
            lblHeader = new Label();
            pictureBoxLogo = new PictureBox();
            tabControl = new TabControl();
            tabDevices = new TabPage();
            panelDeviceActions = new Panel();
            btnAddDevice = new Button();
            btnEditDevice = new Button();
            btnDeleteDevice = new Button();
            tabPanels = new TabPage();
            listViewPanels = new ListView();
            panelPanelActions = new Panel();
            btnAddPanel = new Button();
            btnEditPanel = new Button();
            btnDeletePanel = new Button();
            lblPanelsCount = new Label();
            statusStrip = new StatusStrip();
            statusLabelInfo = new ToolStripStatusLabel();
            statusLabelDate = new ToolStripStatusLabel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tabControl.SuspendLayout();
            tabDevices.SuspendLayout();
            panelDeviceActions.SuspendLayout();
            tabPanels.SuspendLayout();
            panelPanelActions.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // listViewDevice
            // 
            listViewDevice.BackColor = Color.White;
            listViewDevice.BorderStyle = BorderStyle.FixedSingle;
            listViewDevice.Dock = DockStyle.Fill;
            listViewDevice.FullRowSelect = true;
            listViewDevice.GridLines = true;
            listViewDevice.Location = new Point(5, 72);
            listViewDevice.Margin = new Padding(5, 6, 5, 6);
            listViewDevice.MultiSelect = false;
            listViewDevice.Name = "listViewDevice";
            listViewDevice.Size = new Size(1656, 709);
            listViewDevice.TabIndex = 1;
            listViewDevice.UseCompatibleStateImageBehavior = false;
            listViewDevice.View = View.Details;
            // 
            // lblDeviceTypesCount
            // 
            lblDeviceTypesCount.AutoSize = true;
            lblDeviceTypesCount.Dock = DockStyle.Top;
            lblDeviceTypesCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceTypesCount.ForeColor = Color.FromArgb(0, 70, 140);
            lblDeviceTypesCount.Location = new Point(5, 6);
            lblDeviceTypesCount.Margin = new Padding(5, 0, 5, 0);
            lblDeviceTypesCount.Name = "lblDeviceTypesCount";
            lblDeviceTypesCount.Padding = new Padding(8, 19, 0, 19);
            lblDeviceTypesCount.Size = new Size(222, 66);
            lblDeviceTypesCount.TabIndex = 2;
            lblDeviceTypesCount.Text = "Total Device Count: 0";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.MidnightBlue;
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(btnExport);
            panelTop.Controls.Add(lblHeader);
            panelTop.Controls.Add(pictureBoxLogo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5, 6, 5, 6);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1674, 115);
            panelTop.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(240, 240, 240);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 140);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(0, 70, 140);
            btnRefresh.Location = new Point(1408, 38);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 40);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.FromArgb(240, 240, 240);
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 140);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.FromArgb(0, 70, 140);
            btnExport.Location = new Point(1537, 38);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(112, 40);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(492, 38);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(446, 45);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Device Inventory Dashboard";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, -3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(127, 118);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabDevices);
            tabControl.Controls.Add(tabPanels);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(0, 115);
            tabControl.Margin = new Padding(5, 6, 5, 6);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1674, 865);
            tabControl.TabIndex = 4;
            // 
            // tabDevices
            // 
            tabDevices.BackColor = Color.FromArgb(245, 245, 250);
            tabDevices.Controls.Add(listViewDevice);
            tabDevices.Controls.Add(panelDeviceActions);
            tabDevices.Controls.Add(lblDeviceTypesCount);
            tabDevices.Location = new Point(4, 47);
            tabDevices.Margin = new Padding(5, 6, 5, 6);
            tabDevices.Name = "tabDevices";
            tabDevices.Padding = new Padding(5, 6, 5, 6);
            tabDevices.Size = new Size(1666, 814);
            tabDevices.TabIndex = 0;
            tabDevices.Text = "Device Types";
            // 
            // panelDeviceActions
            // 
            panelDeviceActions.BackColor = Color.FromArgb(240, 240, 240);
            panelDeviceActions.Controls.Add(btnAddDevice);
            panelDeviceActions.Controls.Add(btnEditDevice);
            panelDeviceActions.Controls.Add(btnDeleteDevice);
            panelDeviceActions.Dock = DockStyle.Bottom;
            panelDeviceActions.Location = new Point(5, 781);
            panelDeviceActions.Name = "panelDeviceActions";
            panelDeviceActions.Size = new Size(1656, 27);
            panelDeviceActions.TabIndex = 3;
            // 
            // btnAddDevice
            // 
            btnAddDevice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddDevice.BackColor = Color.FromArgb(0, 122, 204);
            btnAddDevice.FlatAppearance.BorderSize = 0;
            btnAddDevice.FlatStyle = FlatStyle.Flat;
            btnAddDevice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.Location = new Point(1363, 3);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.Size = new Size(90, 21);
            btnAddDevice.TabIndex = 2;
            btnAddDevice.Text = "Add";
            btnAddDevice.UseVisualStyleBackColor = false;
            // 
            // btnEditDevice
            // 
            btnEditDevice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditDevice.BackColor = Color.FromArgb(255, 169, 0);
            btnEditDevice.FlatAppearance.BorderSize = 0;
            btnEditDevice.FlatStyle = FlatStyle.Flat;
            btnEditDevice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditDevice.ForeColor = Color.White;
            btnEditDevice.Location = new Point(1465, 3);
            btnEditDevice.Name = "btnEditDevice";
            btnEditDevice.Size = new Size(90, 21);
            btnEditDevice.TabIndex = 1;
            btnEditDevice.Text = "Edit";
            btnEditDevice.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDevice
            // 
            btnDeleteDevice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteDevice.BackColor = Color.FromArgb(209, 17, 65);
            btnDeleteDevice.FlatAppearance.BorderSize = 0;
            btnDeleteDevice.FlatStyle = FlatStyle.Flat;
            btnDeleteDevice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteDevice.ForeColor = Color.White;
            btnDeleteDevice.Location = new Point(1566, 3);
            btnDeleteDevice.Name = "btnDeleteDevice";
            btnDeleteDevice.Size = new Size(90, 21);
            btnDeleteDevice.TabIndex = 0;
            btnDeleteDevice.Text = "Delete";
            btnDeleteDevice.UseVisualStyleBackColor = false;
            // 
            // tabPanels
            // 
            tabPanels.BackColor = Color.FromArgb(245, 245, 250);
            tabPanels.Controls.Add(listViewPanels);
            tabPanels.Controls.Add(panelPanelActions);
            tabPanels.Controls.Add(lblPanelsCount);
            tabPanels.Location = new Point(4, 47);
            tabPanels.Margin = new Padding(5, 6, 5, 6);
            tabPanels.Name = "tabPanels";
            tabPanels.Padding = new Padding(5, 6, 5, 6);
            tabPanels.Size = new Size(1666, 814);
            tabPanels.TabIndex = 1;
            tabPanels.Text = "Panels in Workstations";
            // 
            // listViewPanels
            // 
            listViewPanels.BackColor = Color.White;
            listViewPanels.BorderStyle = BorderStyle.FixedSingle;
            listViewPanels.Dock = DockStyle.Fill;
            listViewPanels.FullRowSelect = true;
            listViewPanels.GridLines = true;
            listViewPanels.Location = new Point(5, 72);
            listViewPanels.Margin = new Padding(5, 6, 5, 6);
            listViewPanels.MultiSelect = false;
            listViewPanels.Name = "listViewPanels";
            listViewPanels.Size = new Size(1656, 709);
            listViewPanels.TabIndex = 2;
            listViewPanels.UseCompatibleStateImageBehavior = false;
            listViewPanels.View = View.Details;
            // 
            // panelPanelActions
            // 
            panelPanelActions.BackColor = Color.FromArgb(240, 240, 240);
            panelPanelActions.Controls.Add(btnAddPanel);
            panelPanelActions.Controls.Add(btnEditPanel);
            panelPanelActions.Controls.Add(btnDeletePanel);
            panelPanelActions.Dock = DockStyle.Bottom;
            panelPanelActions.Location = new Point(5, 781);
            panelPanelActions.Name = "panelPanelActions";
            panelPanelActions.Size = new Size(1656, 27);
            panelPanelActions.TabIndex = 4;
            // 
            // btnAddPanel
            // 
            btnAddPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddPanel.BackColor = Color.FromArgb(0, 122, 204);
            btnAddPanel.FlatAppearance.BorderSize = 0;
            btnAddPanel.FlatStyle = FlatStyle.Flat;
            btnAddPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPanel.ForeColor = Color.White;
            btnAddPanel.Location = new Point(1363, 3);
            btnAddPanel.Name = "btnAddPanel";
            btnAddPanel.Size = new Size(90, 21);
            btnAddPanel.TabIndex = 2;
            btnAddPanel.Text = "Add";
            btnAddPanel.UseVisualStyleBackColor = false;
            // 
            // btnEditPanel
            // 
            btnEditPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditPanel.BackColor = Color.FromArgb(255, 169, 0);
            btnEditPanel.FlatAppearance.BorderSize = 0;
            btnEditPanel.FlatStyle = FlatStyle.Flat;
            btnEditPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditPanel.ForeColor = Color.White;
            btnEditPanel.Location = new Point(1465, 3);
            btnEditPanel.Name = "btnEditPanel";
            btnEditPanel.Size = new Size(90, 21);
            btnEditPanel.TabIndex = 1;
            btnEditPanel.Text = "Edit";
            btnEditPanel.UseVisualStyleBackColor = false;
            // 
            // btnDeletePanel
            // 
            btnDeletePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletePanel.BackColor = Color.FromArgb(209, 17, 65);
            btnDeletePanel.FlatAppearance.BorderSize = 0;
            btnDeletePanel.FlatStyle = FlatStyle.Flat;
            btnDeletePanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePanel.ForeColor = Color.White;
            btnDeletePanel.Location = new Point(1566, 3);
            btnDeletePanel.Name = "btnDeletePanel";
            btnDeletePanel.Size = new Size(90, 21);
            btnDeletePanel.TabIndex = 0;
            btnDeletePanel.Text = "Delete";
            btnDeletePanel.UseVisualStyleBackColor = false;
            // 
            // lblPanelsCount
            // 
            lblPanelsCount.AutoSize = true;
            lblPanelsCount.Dock = DockStyle.Top;
            lblPanelsCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPanelsCount.ForeColor = Color.FromArgb(0, 70, 140);
            lblPanelsCount.Location = new Point(5, 6);
            lblPanelsCount.Margin = new Padding(5, 0, 5, 0);
            lblPanelsCount.Name = "lblPanelsCount";
            lblPanelsCount.Padding = new Padding(8, 19, 0, 19);
            lblPanelsCount.Size = new Size(219, 66);
            lblPanelsCount.TabIndex = 3;
            lblPanelsCount.Text = "Total Panels Count: 0";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabelInfo, statusLabelDate });
            statusStrip.Location = new Point(0, 980);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1674, 32);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabelInfo
            // 
            statusLabelInfo.Name = "statusLabelInfo";
            statusLabelInfo.Size = new Size(60, 25);
            statusLabelInfo.Text = "Ready";
            // 
            // statusLabelDate
            // 
            statusLabelDate.Name = "statusLabelDate";
            statusLabelDate.Size = new Size(1599, 25);
            statusLabelDate.Spring = true;
            statusLabelDate.Text = "Date: 15-May-2025";
            statusLabelDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1674, 1012);
            Controls.Add(tabControl);
            Controls.Add(panelTop);
            Controls.Add(statusStrip);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1000, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Device Inventory Manager";
            Load += MainForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tabControl.ResumeLayout(false);
            tabDevices.ResumeLayout(false);
            tabDevices.PerformLayout();
            panelDeviceActions.ResumeLayout(false);
            tabPanels.ResumeLayout(false);
            tabPanels.PerformLayout();
            panelPanelActions.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewDevice;
        private Label lblDeviceTypesCount;
        private Panel panelTop;
        private TabControl tabControl;
        private TabPage tabDevices;
        private TabPage tabPanels;
        private ListView listViewPanels;
        private Label lblPanelsCount;
        private Label lblHeader;
        private PictureBox pictureBoxLogo;
        private Button btnExport;
        private Button btnRefresh;
        private Panel panelDeviceActions;
        private Button btnAddDevice;
        private Button btnEditDevice;
        private Button btnDeleteDevice;
        private Panel panelPanelActions;
        private Button btnAddPanel;
        private Button btnEditPanel;
        private Button btnDeletePanel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabelInfo;
        private ToolStripStatusLabel statusLabelDate;

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize the form
            InitializeListViews();
            LoadData();

            // Set the current date in the status bar
            statusLabelDate.Text = "Date: " + DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void InitializeListViews()
        {
            // Configure Device ListView
            listViewDevice.Columns.Add("ID", 60);
            listViewDevice.Columns.Add("Device Name", 200);
            listViewDevice.Columns.Add("Category", 150);
            listViewDevice.Columns.Add("Manufacturer", 180);
            listViewDevice.Columns.Add("Model", 150);
            listViewDevice.Columns.Add("Serial Number", 150);
            listViewDevice.Columns.Add("Purchase Date", 120);
            listViewDevice.Columns.Add("Status", 100);
            listViewDevice.Columns.Add("Location", 150);

            // Configure Panels ListView
            listViewPanels.Columns.Add("ID", 60);
            listViewPanels.Columns.Add("Panel Name", 200);
            listViewPanels.Columns.Add("Workstation", 150);
            listViewPanels.Columns.Add("Panel Type", 150);
            listViewPanels.Columns.Add("Installation Date", 120);
            listViewPanels.Columns.Add("Status", 100);
            listViewPanels.Columns.Add("Connected Devices", 150);
        }

        private void LoadData()
        {
            // This would be replaced with your actual data loading logic
            statusLabelInfo.Text = "Loading data...";

            // Update counts
            lblDeviceTypesCount.Text = $"Total Device Count: {listViewDevice.Items.Count}";
            lblPanelsCount.Text = $"Total Panels Count: {listViewPanels.Items.Count}";

            statusLabelInfo.Text = "Ready";
        }
    }
}