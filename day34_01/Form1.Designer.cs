
namespace day34_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BTN_CHECKORDER1 = new System.Windows.Forms.Button();
            this.BTN_CHECKORDER2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(360, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(428, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(360, 188);
            this.dataGridView2.TabIndex = 1;
            // 
            // BTN_CHECKORDER1
            // 
            this.BTN_CHECKORDER1.Location = new System.Drawing.Point(13, 207);
            this.BTN_CHECKORDER1.Name = "BTN_CHECKORDER1";
            this.BTN_CHECKORDER1.Size = new System.Drawing.Size(136, 29);
            this.BTN_CHECKORDER1.TabIndex = 2;
            this.BTN_CHECKORDER1.Text = "아이디로 찾기";
            this.BTN_CHECKORDER1.UseVisualStyleBackColor = true;
            this.BTN_CHECKORDER1.Click += new System.EventHandler(this.BTN_CHECKORDER1_Click);
            // 
            // BTN_CHECKORDER2
            // 
            this.BTN_CHECKORDER2.Location = new System.Drawing.Point(428, 206);
            this.BTN_CHECKORDER2.Name = "BTN_CHECKORDER2";
            this.BTN_CHECKORDER2.Size = new System.Drawing.Size(145, 29);
            this.BTN_CHECKORDER2.TabIndex = 3;
            this.BTN_CHECKORDER2.Text = "주문번호로 찾기";
            this.BTN_CHECKORDER2.UseVisualStyleBackColor = true;
            this.BTN_CHECKORDER2.Click += new System.EventHandler(this.BTN_CHECKORDER2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_CHECKORDER2);
            this.Controls.Add(this.BTN_CHECKORDER1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTN_CHECKORDER1;
        private System.Windows.Forms.Button BTN_CHECKORDER2;
    }
}

