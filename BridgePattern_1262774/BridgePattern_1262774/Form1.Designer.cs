namespace BridgePattern_1262774
{
    partial class Form1
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
            this.btnBridgeBasic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefinedAbstraction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBridgeBasic
            // 
            this.btnBridgeBasic.Location = new System.Drawing.Point(25, 119);
            this.btnBridgeBasic.Name = "btnBridgeBasic";
            this.btnBridgeBasic.Size = new System.Drawing.Size(174, 23);
            this.btnBridgeBasic.TabIndex = 0;
            this.btnBridgeBasic.Text = "btnBridgeBasic";
            this.btnBridgeBasic.UseVisualStyleBackColor = true;
            this.btnBridgeBasic.Click += new System.EventHandler(this.btnBridgeBasic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Bridge Pattern";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRefinedAbstraction
            // 
            this.btnRefinedAbstraction.Location = new System.Drawing.Point(240, 119);
            this.btnRefinedAbstraction.Name = "btnRefinedAbstraction";
            this.btnRefinedAbstraction.Size = new System.Drawing.Size(160, 23);
            this.btnRefinedAbstraction.TabIndex = 2;
            this.btnRefinedAbstraction.Text = "btnRefinedAbstraction";
            this.btnRefinedAbstraction.UseVisualStyleBackColor = true;
            this.btnRefinedAbstraction.Click += new System.EventHandler(this.btnRefinedAbstraction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test Refined Abstraction";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefinedAbstraction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBridgeBasic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBridgeBasic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefinedAbstraction;
        private System.Windows.Forms.Label label2;
    }
}

