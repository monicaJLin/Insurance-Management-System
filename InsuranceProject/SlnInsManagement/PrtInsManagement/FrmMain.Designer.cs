namespace PrtInsManagement
{
    partial class FrmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAgent = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Customer = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_CustomerPolicy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAgent,
            this.tsbtn_Customer,
            this.tsbtn_CustomerPolicy,
            this.toolStripButton1,
            this.tsbtn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 103);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAgent
            // 
            this.tsbtnAgent.AutoSize = false;
            this.tsbtnAgent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgent.Image")));
            this.tsbtnAgent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnAgent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgent.Name = "tsbtnAgent";
            this.tsbtnAgent.Size = new System.Drawing.Size(100, 100);
            this.tsbtnAgent.Text = "Agent";
            this.tsbtnAgent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAgent.Click += new System.EventHandler(this.tsbtnAgent_Click);
            // 
            // tsbtn_Customer
            // 
            this.tsbtn_Customer.AutoSize = false;
            this.tsbtn_Customer.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Customer.Image")));
            this.tsbtn_Customer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtn_Customer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Customer.Name = "tsbtn_Customer";
            this.tsbtn_Customer.Size = new System.Drawing.Size(100, 100);
            this.tsbtn_Customer.Text = "Customer";
            this.tsbtn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Customer.Click += new System.EventHandler(this.tsbtn_Customer_Click);
            // 
            // tsbtn_CustomerPolicy
            // 
            this.tsbtn_CustomerPolicy.AutoSize = false;
            this.tsbtn_CustomerPolicy.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_CustomerPolicy.Image")));
            this.tsbtn_CustomerPolicy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtn_CustomerPolicy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_CustomerPolicy.Name = "tsbtn_CustomerPolicy";
            this.tsbtn_CustomerPolicy.Size = new System.Drawing.Size(100, 100);
            this.tsbtn_CustomerPolicy.Text = "Policies";
            this.tsbtn_CustomerPolicy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_CustomerPolicy.Click += new System.EventHandler(this.tsbtn_CustomerPolicy_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 100);
            this.toolStripButton1.Text = "Billing";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtn_Exit
            // 
            this.tsbtn_Exit.AutoSize = false;
            this.tsbtn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Exit.Image")));
            this.tsbtn_Exit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Exit.Name = "tsbtn_Exit";
            this.tsbtn_Exit.Size = new System.Drawing.Size(100, 100);
            this.tsbtn_Exit.Text = "Exit";
            this.tsbtn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Exit.Click += new System.EventHandler(this.tsbtn_Exit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Insurance Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAgent;
        private System.Windows.Forms.ToolStripButton tsbtn_CustomerPolicy;
        private System.Windows.Forms.ToolStripButton tsbtn_Customer;
        private System.Windows.Forms.ToolStripButton tsbtn_Exit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

