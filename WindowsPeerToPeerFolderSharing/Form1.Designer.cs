namespace WindowsPeerToPeerFolderSharing
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
			this.splitContainerHorizontal = new System.Windows.Forms.SplitContainer();
			this.splitContainerBottomVertical = new System.Windows.Forms.SplitContainer();
			this.buttonSendMessage = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.treeViewShared = new System.Windows.Forms.TreeView();
			this.folderBrowserDialogAdd = new System.Windows.Forms.FolderBrowserDialog();
			this.textBoxLog = new WindowsPeerToPeerFolderSharing.ThreadSafeTextbox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).BeginInit();
			this.splitContainerHorizontal.Panel1.SuspendLayout();
			this.splitContainerHorizontal.Panel2.SuspendLayout();
			this.splitContainerHorizontal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerBottomVertical)).BeginInit();
			this.splitContainerBottomVertical.Panel1.SuspendLayout();
			this.splitContainerBottomVertical.Panel2.SuspendLayout();
			this.splitContainerBottomVertical.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerHorizontal
			// 
			this.splitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
			this.splitContainerHorizontal.Name = "splitContainerHorizontal";
			this.splitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerHorizontal.Panel1
			// 
			this.splitContainerHorizontal.Panel1.Controls.Add(this.splitContainer3);
			// 
			// splitContainerHorizontal.Panel2
			// 
			this.splitContainerHorizontal.Panel2.Controls.Add(this.splitContainerBottomVertical);
			this.splitContainerHorizontal.Size = new System.Drawing.Size(715, 554);
			this.splitContainerHorizontal.SplitterDistance = 502;
			this.splitContainerHorizontal.TabIndex = 0;
			// 
			// splitContainerBottomVertical
			// 
			this.splitContainerBottomVertical.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerBottomVertical.Location = new System.Drawing.Point(0, 0);
			this.splitContainerBottomVertical.Name = "splitContainerBottomVertical";
			// 
			// splitContainerBottomVertical.Panel1
			// 
			this.splitContainerBottomVertical.Panel1.Controls.Add(this.splitContainer1);
			// 
			// splitContainerBottomVertical.Panel2
			// 
			this.splitContainerBottomVertical.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainerBottomVertical.Size = new System.Drawing.Size(715, 48);
			this.splitContainerBottomVertical.SplitterDistance = 349;
			this.splitContainerBottomVertical.TabIndex = 0;
			// 
			// buttonSendMessage
			// 
			this.buttonSendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSendMessage.Location = new System.Drawing.Point(0, 0);
			this.buttonSendMessage.Name = "buttonSendMessage";
			this.buttonSendMessage.Size = new System.Drawing.Size(183, 48);
			this.buttonSendMessage.TabIndex = 0;
			this.buttonSendMessage.Text = "Send Message";
			this.buttonSendMessage.UseVisualStyleBackColor = true;
			this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.buttonAdd);
			this.splitContainer1.Size = new System.Drawing.Size(349, 48);
			this.splitContainer1.SplitterDistance = 172;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.buttonRemove);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.buttonSendMessage);
			this.splitContainer2.Size = new System.Drawing.Size(362, 48);
			this.splitContainer2.SplitterDistance = 175;
			this.splitContainer2.TabIndex = 0;
			// 
			// buttonStart
			// 
			this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonStart.Location = new System.Drawing.Point(0, 0);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(172, 48);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Start Server";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStartStop_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAdd.Location = new System.Drawing.Point(0, 0);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(173, 48);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add Folder";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonRemove
			// 
			this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonRemove.Location = new System.Drawing.Point(0, 0);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(175, 48);
			this.buttonRemove.TabIndex = 0;
			this.buttonRemove.Text = "Remove Folder";
			this.buttonRemove.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.textBoxLog);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.treeViewShared);
			this.splitContainer3.Size = new System.Drawing.Size(715, 502);
			this.splitContainer3.SplitterDistance = 348;
			this.splitContainer3.TabIndex = 1;
			// 
			// treeViewShared
			// 
			this.treeViewShared.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewShared.Location = new System.Drawing.Point(0, 0);
			this.treeViewShared.Name = "treeViewShared";
			this.treeViewShared.Size = new System.Drawing.Size(363, 502);
			this.treeViewShared.TabIndex = 0;
			// 
			// textBoxLog
			// 
			this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLog.Location = new System.Drawing.Point(0, 0);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.Size = new System.Drawing.Size(348, 502);
			this.textBoxLog.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 554);
			this.Controls.Add(this.splitContainerHorizontal);
			this.Name = "MainForm";
			this.Text = "Peer to Peer Folder Sharing";
			this.splitContainerHorizontal.Panel1.ResumeLayout(false);
			this.splitContainerHorizontal.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).EndInit();
			this.splitContainerHorizontal.ResumeLayout(false);
			this.splitContainerBottomVertical.Panel1.ResumeLayout(false);
			this.splitContainerBottomVertical.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerBottomVertical)).EndInit();
			this.splitContainerBottomVertical.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.SplitContainer splitContainerHorizontal;
		private System.Windows.Forms.SplitContainer splitContainerBottomVertical;
		private System.Windows.Forms.Button buttonSendMessage;
		private ThreadSafeTextbox textBoxLog;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.TreeView treeViewShared;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAdd;
    }
}

