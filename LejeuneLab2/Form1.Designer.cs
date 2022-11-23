namespace LejeuneLab2
{
    partial class frmGregLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGregLab));
            this.grpMultiplier = new System.Windows.Forms.GroupBox();
            this.lblAnswerOutput = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.picSkiing = new System.Windows.Forms.PictureBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.grpMultiplier.SuspendLayout();
            this.grpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSkiing)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMultiplier
            // 
            this.grpMultiplier.Controls.Add(this.txtNumber);
            this.grpMultiplier.Controls.Add(this.lblAnswerOutput);
            this.grpMultiplier.Controls.Add(this.btnReset);
            this.grpMultiplier.Controls.Add(this.btnCalculate);
            this.grpMultiplier.Controls.Add(this.lblAnswer);
            this.grpMultiplier.Controls.Add(this.lblMultiplier);
            this.grpMultiplier.Controls.Add(this.lblNumber);
            this.grpMultiplier.Controls.Add(this.txtMultiplier);
            this.grpMultiplier.Location = new System.Drawing.Point(12, 26);
            this.grpMultiplier.Name = "grpMultiplier";
            this.grpMultiplier.Size = new System.Drawing.Size(272, 302);
            this.grpMultiplier.TabIndex = 0;
            this.grpMultiplier.TabStop = false;
            this.grpMultiplier.Text = "Multiplier";
            // 
            // lblAnswerOutput
            // 
            this.lblAnswerOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswerOutput.Location = new System.Drawing.Point(147, 169);
            this.lblAnswerOutput.Name = "lblAnswerOutput";
            this.lblAnswerOutput.Size = new System.Drawing.Size(104, 23);
            this.lblAnswerOutput.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(160, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 247);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 40);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(11, 170);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(57, 16);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(11, 115);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(67, 16);
            this.lblMultiplier.TabIndex = 0;
            this.lblMultiplier.Text = "Multiplier:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(11, 57);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(60, 16);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number:";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(147, 112);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(104, 23);
            this.txtMultiplier.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(147, 54);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(104, 23);
            this.txtNumber.TabIndex = 1;
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.btnExit);
            this.grpInformation.Controls.Add(this.btnHide);
            this.grpInformation.Controls.Add(this.btnData);
            this.grpInformation.Controls.Add(this.btnPicture);
            this.grpInformation.Controls.Add(this.picSkiing);
            this.grpInformation.Controls.Add(this.lblTopic);
            this.grpInformation.Controls.Add(this.lblInfo);
            this.grpInformation.Location = new System.Drawing.Point(299, 26);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(408, 302);
            this.grpInformation.TabIndex = 0;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(36, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(341, 177);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(211, 247);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(86, 40);
            this.btnHide.TabIndex = 7;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(112, 247);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(86, 40);
            this.btnData.TabIndex = 6;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(13, 247);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(86, 40);
            this.btnPicture.TabIndex = 5;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // picSkiing
            // 
            this.picSkiing.Image = ((System.Drawing.Image)(resources.GetObject("picSkiing.Image")));
            this.picSkiing.Location = new System.Drawing.Point(36, 50);
            this.picSkiing.Name = "picSkiing";
            this.picSkiing.Size = new System.Drawing.Size(341, 177);
            this.picSkiing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSkiing.TabIndex = 1;
            this.picSkiing.TabStop = false;
            this.picSkiing.Visible = false;
            this.picSkiing.Click += new System.EventHandler(this.picSkiing_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(165, 26);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(82, 16);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "Skiing in NB";
            // 
            // frmGregLab
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.grpMultiplier);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGregLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by Gregory Lejeune";
            this.grpMultiplier.ResumeLayout(false);
            this.grpMultiplier.PerformLayout();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSkiing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMultiplier;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.PictureBox picSkiing;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblAnswerOutput;
        private System.Windows.Forms.Label lblInfo;
    }
}

