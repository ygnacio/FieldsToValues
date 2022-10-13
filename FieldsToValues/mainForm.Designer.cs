
namespace FieldsToValues
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpPre = new System.Windows.Forms.GroupBox();
            this.preReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.preFind = new System.Windows.Forms.TextBox();
            this.grpPost = new System.Windows.Forms.GroupBox();
            this.postReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.postFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fields = new System.Windows.Forms.TextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpPre.SuspendLayout();
            this.grpPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // grpPre
            // 
            this.grpPre.Controls.Add(this.preReplace);
            this.grpPre.Controls.Add(this.label2);
            this.grpPre.Controls.Add(this.preFind);
            this.grpPre.Controls.Add(this.label1);
            this.grpPre.Location = new System.Drawing.Point(45, 21);
            this.grpPre.Name = "grpPre";
            this.grpPre.Size = new System.Drawing.Size(297, 83);
            this.grpPre.TabIndex = 1;
            this.grpPre.TabStop = false;
            this.grpPre.Text = "Pre:";
            // 
            // preReplace
            // 
            this.preReplace.Location = new System.Drawing.Point(85, 44);
            this.preReplace.Name = "preReplace";
            this.preReplace.Size = new System.Drawing.Size(189, 20);
            this.preReplace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Replace:";
            // 
            // preFind
            // 
            this.preFind.Location = new System.Drawing.Point(85, 18);
            this.preFind.Name = "preFind";
            this.preFind.Size = new System.Drawing.Size(189, 20);
            this.preFind.TabIndex = 1;
            // 
            // grpPost
            // 
            this.grpPost.Controls.Add(this.postReplace);
            this.grpPost.Controls.Add(this.label3);
            this.grpPost.Controls.Add(this.postFind);
            this.grpPost.Controls.Add(this.label4);
            this.grpPost.Location = new System.Drawing.Point(371, 21);
            this.grpPost.Name = "grpPost";
            this.grpPost.Size = new System.Drawing.Size(297, 83);
            this.grpPost.TabIndex = 2;
            this.grpPost.TabStop = false;
            this.grpPost.Text = "Post:";
            // 
            // postReplace
            // 
            this.postReplace.Location = new System.Drawing.Point(85, 44);
            this.postReplace.Name = "postReplace";
            this.postReplace.Size = new System.Drawing.Size(189, 20);
            this.postReplace.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Replace:";
            // 
            // postFind
            // 
            this.postFind.Location = new System.Drawing.Point(85, 18);
            this.postFind.Name = "postFind";
            this.postFind.Size = new System.Drawing.Size(189, 20);
            this.postFind.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Find:";
            // 
            // Fields
            // 
            this.Fields.Location = new System.Drawing.Point(45, 129);
            this.Fields.Multiline = true;
            this.Fields.Name = "Fields";
            this.Fields.Size = new System.Drawing.Size(623, 112);
            this.Fields.TabIndex = 3;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(320, 252);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(73, 30);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(45, 297);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(623, 112);
            this.Result.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Original:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Result:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Fields);
            this.Controls.Add(this.grpPost);
            this.Controls.Add(this.grpPre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "FieldsToValues";
            this.grpPre.ResumeLayout(false);
            this.grpPre.PerformLayout();
            this.grpPost.ResumeLayout(false);
            this.grpPost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPre;
        private System.Windows.Forms.TextBox preReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox preFind;
        private System.Windows.Forms.GroupBox grpPost;
        private System.Windows.Forms.TextBox postReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox postFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fields;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

