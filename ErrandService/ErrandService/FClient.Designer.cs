﻿namespace DormManagementApp
{
	partial class FClient
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
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.btnSendFile = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCMsg = new System.Windows.Forms.TextBox();
			this.btnCSend = new System.Windows.Forms.Button();
			this.txtMsg = new System.Windows.Forms.TextBox();
			this.btnConnectToServer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(445, 338);
			this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(100, 29);
			this.btnSelectFile.TabIndex = 45;
			this.btnSelectFile.Text = "选择文件";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(56, 342);
			this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(356, 25);
			this.txtFileName.TabIndex = 44;
			// 
			// btnSendFile
			// 
			this.btnSendFile.Location = new System.Drawing.Point(583, 338);
			this.btnSendFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSendFile.Name = "btnSendFile";
			this.btnSendFile.Size = new System.Drawing.Size(100, 29);
			this.btnSendFile.TabIndex = 43;
			this.btnSendFile.Text = "发送文件";
			this.btnSendFile.UseVisualStyleBackColor = true;
			this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(64, 283);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 15);
			this.label4.TabIndex = 42;
			this.label4.Text = "客户端:";
			// 
			// txtCMsg
			// 
			this.txtCMsg.Location = new System.Drawing.Point(232, 283);
			this.txtCMsg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCMsg.Multiline = true;
			this.txtCMsg.Name = "txtCMsg";
			this.txtCMsg.Size = new System.Drawing.Size(317, 22);
			this.txtCMsg.TabIndex = 40;
			this.txtCMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMsg_KeyDown);
			// 
			// btnCSend
			// 
			this.btnCSend.Location = new System.Drawing.Point(583, 283);
			this.btnCSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnCSend.Name = "btnCSend";
			this.btnCSend.Size = new System.Drawing.Size(100, 29);
			this.btnCSend.TabIndex = 38;
			this.btnCSend.Text = "发送消息";
			this.btnCSend.UseVisualStyleBackColor = true;
			this.btnCSend.Click += new System.EventHandler(this.btnCSend_Click);
			// 
			// txtMsg
			// 
			this.txtMsg.Location = new System.Drawing.Point(232, 69);
			this.txtMsg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMsg.Multiline = true;
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMsg.Size = new System.Drawing.Size(443, 192);
			this.txtMsg.TabIndex = 37;
			// 
			// btnConnectToServer
			// 
			this.btnConnectToServer.Location = new System.Drawing.Point(68, 188);
			this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnConnectToServer.Name = "btnConnectToServer";
			this.btnConnectToServer.Size = new System.Drawing.Size(100, 29);
			this.btnConnectToServer.TabIndex = 36;
			this.btnConnectToServer.Text = "连接服务端";
			this.btnConnectToServer.UseVisualStyleBackColor = true;
			this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(69, 235);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(100, 27);
			this.btnExit.TabIndex = 48;
			this.btnExit.Text = "关闭客户端";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtPort);
			this.groupBox2.Controls.Add(this.txtIP);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(56, 46);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Size = new System.Drawing.Size(153, 113);
			this.groupBox2.TabIndex = 49;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "服务端:";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(45, 69);
			this.txtPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(99, 25);
			this.txtPort.TabIndex = 3;
			this.txtPort.Text = "6666";
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(45, 20);
			this.txtIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(99, 25);
			this.txtIP.TabIndex = 2;
			this.txtIP.Text = "192.168.213.1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 73);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 15);
			this.label6.TabIndex = 1;
			this.label6.Text = "Port: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 23);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "IP: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(228, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 15);
			this.label1.TabIndex = 50;
			this.label1.Text = "聊天内容:";
			// 
			// FClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 423);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSelectFile);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.btnSendFile);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCMsg);
			this.Controls.Add(this.btnCSend);
			this.Controls.Add(this.txtMsg);
			this.Controls.Add(this.btnConnectToServer);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FClient";
			this.Text = "客户端";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Button btnSendFile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCMsg;
		private System.Windows.Forms.Button btnCSend;
		private System.Windows.Forms.TextBox txtMsg;
		private System.Windows.Forms.Button btnConnectToServer;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
	}
}

