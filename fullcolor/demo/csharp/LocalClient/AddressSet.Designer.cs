namespace LocalClient
{
    partial class AddressSet
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDeviceID = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DeviceAddr = new System.Windows.Forms.TabPage();
            this.btnReget = new System.Windows.Forms.Button();
            this.lbAddressTip = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbDNS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.cbDhcpEnable = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ServerAddr = new System.Windows.Forms.TabPage();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSVRefresh = new System.Windows.Forms.Button();
            this.btnSVOK = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.DeviceAddr.SuspendLayout();
            this.ServerAddr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DeviceID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbDeviceID
            // 
            this.cbbDeviceID.FormattingEnabled = true;
            this.cbbDeviceID.Location = new System.Drawing.Point(87, 26);
            this.cbbDeviceID.Name = "cbbDeviceID";
            this.cbbDeviceID.Size = new System.Drawing.Size(121, 21);
            this.cbbDeviceID.TabIndex = 1;
            this.cbbDeviceID.Text = "1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DeviceAddr);
            this.tabControl1.Controls.Add(this.ServerAddr);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 324);
            this.tabControl1.TabIndex = 2;
            // 
            // DeviceAddr
            // 
            this.DeviceAddr.Controls.Add(this.btnReget);
            this.DeviceAddr.Controls.Add(this.lbAddressTip);
            this.DeviceAddr.Controls.Add(this.btnOK);
            this.DeviceAddr.Controls.Add(this.tbDNS);
            this.DeviceAddr.Controls.Add(this.label12);
            this.DeviceAddr.Controls.Add(this.tbGateway);
            this.DeviceAddr.Controls.Add(this.label11);
            this.DeviceAddr.Controls.Add(this.tbMask);
            this.DeviceAddr.Controls.Add(this.label10);
            this.DeviceAddr.Controls.Add(this.tbIP);
            this.DeviceAddr.Controls.Add(this.cbDhcpEnable);
            this.DeviceAddr.Controls.Add(this.label9);
            this.DeviceAddr.Controls.Add(this.label8);
            this.DeviceAddr.Location = new System.Drawing.Point(4, 22);
            this.DeviceAddr.Name = "DeviceAddr";
            this.DeviceAddr.Padding = new System.Windows.Forms.Padding(3);
            this.DeviceAddr.Size = new System.Drawing.Size(396, 298);
            this.DeviceAddr.TabIndex = 0;
            this.DeviceAddr.Text = "Thẻ điều khiển IP";
            this.DeviceAddr.UseVisualStyleBackColor = true;
            // 
            // btnReget
            // 
            this.btnReget.Location = new System.Drawing.Point(191, 256);
            this.btnReget.Name = "btnReget";
            this.btnReget.Size = new System.Drawing.Size(75, 25);
            this.btnReget.TabIndex = 25;
            this.btnReget.Text = "refresh";
            this.btnReget.UseVisualStyleBackColor = true;
            this.btnReget.Click += new System.EventHandler(this.btnReget_Click);
            // 
            // lbAddressTip
            // 
            this.lbAddressTip.AutoSize = true;
            this.lbAddressTip.Location = new System.Drawing.Point(19, 261);
            this.lbAddressTip.Name = "lbAddressTip";
            this.lbAddressTip.Size = new System.Drawing.Size(19, 13);
            this.lbAddressTip.TabIndex = 24;
            this.lbAddressTip.Text = "    ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(277, 256);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "setting";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbDNS
            // 
            this.tbDNS.Location = new System.Drawing.Point(90, 196);
            this.tbDNS.Name = "tbDNS";
            this.tbDNS.Size = new System.Drawing.Size(100, 20);
            this.tbDNS.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "DNS";
            // 
            // tbGateway
            // 
            this.tbGateway.Location = new System.Drawing.Point(90, 145);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(100, 20);
            this.tbGateway.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Gateway";
            // 
            // tbMask
            // 
            this.tbMask.Location = new System.Drawing.Point(90, 95);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(100, 20);
            this.tbMask.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "mask";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(90, 49);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 16;
            // 
            // cbDhcpEnable
            // 
            this.cbDhcpEnable.AutoSize = true;
            this.cbDhcpEnable.Location = new System.Drawing.Point(90, 15);
            this.cbDhcpEnable.Name = "cbDhcpEnable";
            this.cbDhcpEnable.Size = new System.Drawing.Size(85, 17);
            this.cbDhcpEnable.TabIndex = 15;
            this.cbDhcpEnable.Text = "DhcpEnable";
            this.cbDhcpEnable.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dhcp";
            // 
            // ServerAddr
            // 
            this.ServerAddr.Controls.Add(this.tbPort);
            this.ServerAddr.Controls.Add(this.tbHost);
            this.ServerAddr.Controls.Add(this.label3);
            this.ServerAddr.Controls.Add(this.label2);
            this.ServerAddr.Controls.Add(this.btnSVRefresh);
            this.ServerAddr.Controls.Add(this.btnSVOK);
            this.ServerAddr.Location = new System.Drawing.Point(4, 22);
            this.ServerAddr.Name = "ServerAddr";
            this.ServerAddr.Padding = new System.Windows.Forms.Padding(3);
            this.ServerAddr.Size = new System.Drawing.Size(396, 298);
            this.ServerAddr.TabIndex = 1;
            this.ServerAddr.Text = "địa chỉ máy chủ";
            this.ServerAddr.UseVisualStyleBackColor = true;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(109, 88);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(157, 20);
            this.tbPort.TabIndex = 31;
            this.tbPort.Text = "80";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(109, 42);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(157, 20);
            this.tbHost.TabIndex = 30;
            this.tbHost.Text = "192.168.2.195";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Host";
            // 
            // btnSVRefresh
            // 
            this.btnSVRefresh.Location = new System.Drawing.Point(191, 256);
            this.btnSVRefresh.Name = "btnSVRefresh";
            this.btnSVRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnSVRefresh.TabIndex = 27;
            this.btnSVRefresh.Text = "refresh";
            this.btnSVRefresh.UseVisualStyleBackColor = true;
            this.btnSVRefresh.Click += new System.EventHandler(this.btnSVRefresh_Click);
            // 
            // btnSVOK
            // 
            this.btnSVOK.Location = new System.Drawing.Point(277, 256);
            this.btnSVOK.Name = "btnSVOK";
            this.btnSVOK.Size = new System.Drawing.Size(75, 25);
            this.btnSVOK.TabIndex = 26;
            this.btnSVOK.Text = "Ok";
            this.btnSVOK.UseVisualStyleBackColor = true;
            this.btnSVOK.Click += new System.EventHandler(this.btnSVOK_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(337, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AddressSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 402);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbbDeviceID);
            this.Controls.Add(this.label1);
            this.Name = "AddressSet";
            this.Text = "地址设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddressSet_FormClosed);
            this.Load += new System.EventHandler(this.AddressSet_Load);
            this.tabControl1.ResumeLayout(false);
            this.DeviceAddr.ResumeLayout(false);
            this.DeviceAddr.PerformLayout();
            this.ServerAddr.ResumeLayout(false);
            this.ServerAddr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDeviceID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DeviceAddr;
        private System.Windows.Forms.TabPage ServerAddr;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReget;
        private System.Windows.Forms.Label lbAddressTip;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbDNS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMask;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.CheckBox cbDhcpEnable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSVRefresh;
        private System.Windows.Forms.Button btnSVOK;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

