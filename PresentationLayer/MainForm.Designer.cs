namespace PresentationLayer
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssignments = new FontAwesome.Sharp.IconButton();
            this.panelDriverSubmenu = new System.Windows.Forms.Panel();
            this.btnReadDriver = new FontAwesome.Sharp.IconButton();
            this.btnAddDriver = new FontAwesome.Sharp.IconButton();
            this.btnDrivers = new FontAwesome.Sharp.IconButton();
            this.panelBusesSubmenu = new System.Windows.Forms.Panel();
            this.btnReadBuses = new FontAwesome.Sharp.IconButton();
            this.btnAddBus = new FontAwesome.Sharp.IconButton();
            this.btnBuses = new FontAwesome.Sharp.IconButton();
            this.panelRouteSubmenu = new System.Windows.Forms.Panel();
            this.btnSeeRoutes = new FontAwesome.Sharp.IconButton();
            this.btnAddRoute = new FontAwesome.Sharp.IconButton();
            this.btnRoutes = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDriverSubmenu.SuspendLayout();
            this.panelBusesSubmenu.SuspendLayout();
            this.panelRouteSubmenu.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(320, 876);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btnAssignments);
            this.panel1.Controls.Add(this.panelDriverSubmenu);
            this.panel1.Controls.Add(this.btnDrivers);
            this.panel1.Controls.Add(this.panelBusesSubmenu);
            this.panel1.Controls.Add(this.btnBuses);
            this.panel1.Controls.Add(this.panelRouteSubmenu);
            this.panel1.Controls.Add(this.btnRoutes);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 876);
            this.panel1.TabIndex = 1;
            // 
            // btnAssignments
            // 
            this.btnAssignments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignments.FlatAppearance.BorderSize = 0;
            this.btnAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignments.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignments.ForeColor = System.Drawing.Color.White;
            this.btnAssignments.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAssignments.IconColor = System.Drawing.Color.White;
            this.btnAssignments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssignments.IconSize = 35;
            this.btnAssignments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignments.Location = new System.Drawing.Point(0, 962);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAssignments.Size = new System.Drawing.Size(299, 69);
            this.btnAssignments.TabIndex = 8;
            this.btnAssignments.Text = "     Assignments";
            this.btnAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignments.UseVisualStyleBackColor = true;
            // 
            // panelDriverSubmenu
            // 
            this.panelDriverSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelDriverSubmenu.Controls.Add(this.btnReadDriver);
            this.panelDriverSubmenu.Controls.Add(this.btnAddDriver);
            this.panelDriverSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDriverSubmenu.Location = new System.Drawing.Point(0, 810);
            this.panelDriverSubmenu.Name = "panelDriverSubmenu";
            this.panelDriverSubmenu.Size = new System.Drawing.Size(299, 152);
            this.panelDriverSubmenu.TabIndex = 7;
            // 
            // btnReadDriver
            // 
            this.btnReadDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReadDriver.FlatAppearance.BorderSize = 0;
            this.btnReadDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadDriver.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadDriver.ForeColor = System.Drawing.Color.White;
            this.btnReadDriver.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnReadDriver.IconColor = System.Drawing.Color.White;
            this.btnReadDriver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReadDriver.IconSize = 35;
            this.btnReadDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadDriver.Location = new System.Drawing.Point(0, 69);
            this.btnReadDriver.Name = "btnReadDriver";
            this.btnReadDriver.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnReadDriver.Size = new System.Drawing.Size(299, 69);
            this.btnReadDriver.TabIndex = 6;
            this.btnReadDriver.Text = "     See Drivers";
            this.btnReadDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadDriver.UseVisualStyleBackColor = true;
            this.btnReadDriver.Click += new System.EventHandler(this.btnReadDriver_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDriver.FlatAppearance.BorderSize = 0;
            this.btnAddDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDriver.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDriver.ForeColor = System.Drawing.Color.White;
            this.btnAddDriver.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddDriver.IconColor = System.Drawing.Color.White;
            this.btnAddDriver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddDriver.IconSize = 35;
            this.btnAddDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDriver.Location = new System.Drawing.Point(0, 0);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnAddDriver.Size = new System.Drawing.Size(299, 69);
            this.btnAddDriver.TabIndex = 5;
            this.btnAddDriver.Text = "     Add Driver";
            this.btnAddDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnDrivers.IconColor = System.Drawing.Color.White;
            this.btnDrivers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDrivers.IconSize = 35;
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.Location = new System.Drawing.Point(0, 741);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDrivers.Size = new System.Drawing.Size(299, 69);
            this.btnDrivers.TabIndex = 6;
            this.btnDrivers.Text = "     Drivers";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // panelBusesSubmenu
            // 
            this.panelBusesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelBusesSubmenu.Controls.Add(this.btnReadBuses);
            this.panelBusesSubmenu.Controls.Add(this.btnAddBus);
            this.panelBusesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusesSubmenu.Location = new System.Drawing.Point(0, 589);
            this.panelBusesSubmenu.Name = "panelBusesSubmenu";
            this.panelBusesSubmenu.Size = new System.Drawing.Size(299, 152);
            this.panelBusesSubmenu.TabIndex = 5;
            // 
            // btnReadBuses
            // 
            this.btnReadBuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadBuses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReadBuses.FlatAppearance.BorderSize = 0;
            this.btnReadBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadBuses.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadBuses.ForeColor = System.Drawing.Color.White;
            this.btnReadBuses.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnReadBuses.IconColor = System.Drawing.Color.White;
            this.btnReadBuses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReadBuses.IconSize = 35;
            this.btnReadBuses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadBuses.Location = new System.Drawing.Point(0, 69);
            this.btnReadBuses.Name = "btnReadBuses";
            this.btnReadBuses.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnReadBuses.Size = new System.Drawing.Size(299, 69);
            this.btnReadBuses.TabIndex = 6;
            this.btnReadBuses.Text = "     See buses";
            this.btnReadBuses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadBuses.UseVisualStyleBackColor = true;
            this.btnReadBuses.Click += new System.EventHandler(this.btnReadBuses_Click);
            // 
            // btnAddBus
            // 
            this.btnAddBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBus.FlatAppearance.BorderSize = 0;
            this.btnAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBus.ForeColor = System.Drawing.Color.White;
            this.btnAddBus.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddBus.IconColor = System.Drawing.Color.White;
            this.btnAddBus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddBus.IconSize = 35;
            this.btnAddBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBus.Location = new System.Drawing.Point(0, 0);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnAddBus.Size = new System.Drawing.Size(299, 69);
            this.btnAddBus.TabIndex = 5;
            this.btnAddBus.Text = "     Add bus";
            this.btnAddBus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnBuses
            // 
            this.btnBuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuses.FlatAppearance.BorderSize = 0;
            this.btnBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuses.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuses.ForeColor = System.Drawing.Color.White;
            this.btnBuses.IconChar = FontAwesome.Sharp.IconChar.Bus;
            this.btnBuses.IconColor = System.Drawing.Color.White;
            this.btnBuses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuses.IconSize = 35;
            this.btnBuses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuses.Location = new System.Drawing.Point(0, 520);
            this.btnBuses.Name = "btnBuses";
            this.btnBuses.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBuses.Size = new System.Drawing.Size(299, 69);
            this.btnBuses.TabIndex = 4;
            this.btnBuses.Text = "     Buses";
            this.btnBuses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuses.UseVisualStyleBackColor = true;
            this.btnBuses.Click += new System.EventHandler(this.btnBuses_Click);
            // 
            // panelRouteSubmenu
            // 
            this.panelRouteSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelRouteSubmenu.Controls.Add(this.btnSeeRoutes);
            this.panelRouteSubmenu.Controls.Add(this.btnAddRoute);
            this.panelRouteSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRouteSubmenu.Location = new System.Drawing.Point(0, 368);
            this.panelRouteSubmenu.Name = "panelRouteSubmenu";
            this.panelRouteSubmenu.Size = new System.Drawing.Size(299, 152);
            this.panelRouteSubmenu.TabIndex = 3;
            // 
            // btnSeeRoutes
            // 
            this.btnSeeRoutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeRoutes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeeRoutes.FlatAppearance.BorderSize = 0;
            this.btnSeeRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeRoutes.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeRoutes.ForeColor = System.Drawing.Color.White;
            this.btnSeeRoutes.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnSeeRoutes.IconColor = System.Drawing.Color.White;
            this.btnSeeRoutes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeeRoutes.IconSize = 35;
            this.btnSeeRoutes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeRoutes.Location = new System.Drawing.Point(0, 69);
            this.btnSeeRoutes.Name = "btnSeeRoutes";
            this.btnSeeRoutes.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnSeeRoutes.Size = new System.Drawing.Size(299, 69);
            this.btnSeeRoutes.TabIndex = 6;
            this.btnSeeRoutes.Text = "     See routes";
            this.btnSeeRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeRoutes.UseVisualStyleBackColor = true;
            this.btnSeeRoutes.Click += new System.EventHandler(this.btnSeeRoutes_Click);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRoute.FlatAppearance.BorderSize = 0;
            this.btnAddRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoute.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoute.ForeColor = System.Drawing.Color.White;
            this.btnAddRoute.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddRoute.IconColor = System.Drawing.Color.White;
            this.btnAddRoute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddRoute.IconSize = 35;
            this.btnAddRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoute.Location = new System.Drawing.Point(0, 0);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnAddRoute.Size = new System.Drawing.Size(299, 69);
            this.btnAddRoute.TabIndex = 5;
            this.btnAddRoute.Text = "     Add route";
            this.btnAddRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoutes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoutes.FlatAppearance.BorderSize = 0;
            this.btnRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoutes.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutes.ForeColor = System.Drawing.Color.White;
            this.btnRoutes.IconChar = FontAwesome.Sharp.IconChar.Map;
            this.btnRoutes.IconColor = System.Drawing.Color.White;
            this.btnRoutes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoutes.IconSize = 35;
            this.btnRoutes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoutes.Location = new System.Drawing.Point(0, 299);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRoutes.Size = new System.Drawing.Size(299, 69);
            this.btnRoutes.TabIndex = 2;
            this.btnRoutes.Text = "     Routes";
            this.btnRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoutes.UseVisualStyleBackColor = true;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.LightGray;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 35;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 230);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(299, 69);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "     Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 230);
            this.panel2.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(320, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(896, 876);
            this.panelContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(269, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 876);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelDriverSubmenu.ResumeLayout(false);
            this.panelBusesSubmenu.ResumeLayout(false);
            this.panelRouteSubmenu.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnBuses;
        private System.Windows.Forms.Panel panelRouteSubmenu;
        private FontAwesome.Sharp.IconButton btnRoutes;
        private FontAwesome.Sharp.IconButton btnAddRoute;
        private FontAwesome.Sharp.IconButton btnSeeRoutes;
        private System.Windows.Forms.Panel panelBusesSubmenu;
        private FontAwesome.Sharp.IconButton btnReadBuses;
        private FontAwesome.Sharp.IconButton btnAddBus;
        private FontAwesome.Sharp.IconButton btnDrivers;
        private FontAwesome.Sharp.IconButton btnAssignments;
        private System.Windows.Forms.Panel panelDriverSubmenu;
        private FontAwesome.Sharp.IconButton btnReadDriver;
        private FontAwesome.Sharp.IconButton btnAddDriver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}