using System;

namespace RawTcpProxy
{
    public partial class frmServerAccept
    {
        private void InitializeComponent()
        {
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtClientInput = new System.Windows.Forms.TextBox();
            this.btnSendToServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtServerInput = new System.Windows.Forms.TextBox();
            this.btnSendToClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(98, 12);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(221, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "2.224.243.132";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target server";
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Location = new System.Drawing.Point(325, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(72, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "80";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(412, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtClientInput
            // 
            this.txtClientInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientInput.Location = new System.Drawing.Point(3, 32);
            this.txtClientInput.Multiline = true;
            this.txtClientInput.Name = "txtClientInput";
            this.txtClientInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtClientInput.Size = new System.Drawing.Size(157, 330);
            this.txtClientInput.TabIndex = 4;
            this.txtClientInput.WordWrap = false;
            // 
            // btnSendToServer
            // 
            this.btnSendToServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToServer.Location = new System.Drawing.Point(3, 364);
            this.btnSendToServer.Name = "btnSendToServer";
            this.btnSendToServer.Size = new System.Drawing.Size(157, 23);
            this.btnSendToServer.TabIndex = 5;
            this.btnSendToServer.Text = "Send to server";
            this.btnSendToServer.UseVisualStyleBackColor = true;
            this.btnSendToServer.Click += new System.EventHandler(this.btnSendToServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input from client";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(2, 38);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.btnSendToServer);
            this.splitContainer.Panel1.Controls.Add(this.txtClientInput);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.btnSendToClient);
            this.splitContainer.Panel2.Controls.Add(this.txtServerInput);
            this.splitContainer.Size = new System.Drawing.Size(491, 398);
            this.splitContainer.SplitterDistance = 163;
            this.splitContainer.TabIndex = 6;
            // 
            // txtServerInput
            // 
            this.txtServerInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerInput.Location = new System.Drawing.Point(3, 32);
            this.txtServerInput.Multiline = true;
            this.txtServerInput.Name = "txtServerInput";
            this.txtServerInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtServerInput.Size = new System.Drawing.Size(315, 330);
            this.txtServerInput.TabIndex = 4;
            this.txtServerInput.WordWrap = false;
            // 
            // btnSendToClient
            // 
            this.btnSendToClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToClient.Location = new System.Drawing.Point(3, 364);
            this.btnSendToClient.Name = "btnSendToClient";
            this.btnSendToClient.Size = new System.Drawing.Size(315, 23);
            this.btnSendToClient.TabIndex = 5;
            this.btnSendToClient.Text = "Send to client";
            this.btnSendToClient.UseVisualStyleBackColor = true;
            this.btnSendToClient.Click += new System.EventHandler(this.btnSendToClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input from server";
            // 
            // frmServerAccept
            // 
            this.ClientSize = new System.Drawing.Size(494, 437);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Name = "frmServerAccept";
            this.Load += new System.EventHandler(this.frmServerAccept_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtClientInput;
        private System.Windows.Forms.Button btnSendToServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendToClient;
        private System.Windows.Forms.TextBox txtServerInput;
    }
}