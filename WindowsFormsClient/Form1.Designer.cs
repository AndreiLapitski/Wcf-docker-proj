namespace WindowsFormsClient
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_price_create = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_event_create = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox_update = new System.Windows.Forms.GroupBox();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_price_update = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_event_update = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_variables = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 290);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_create);
            this.groupBox1.Controls.Add(this.textBox_price_create);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_event_create);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(212, 17);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(321, 50);
            this.button_create.TabIndex = 4;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click_1);
            // 
            // textBox_price_create
            // 
            this.textBox_price_create.Location = new System.Drawing.Point(48, 47);
            this.textBox_price_create.Name = "textBox_price_create";
            this.textBox_price_create.Size = new System.Drawing.Size(158, 20);
            this.textBox_price_create.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // textBox_event_create
            // 
            this.textBox_event_create.Location = new System.Drawing.Point(48, 17);
            this.textBox_event_create.Name = "textBox_event_create";
            this.textBox_event_create.Size = new System.Drawing.Size(158, 20);
            this.textBox_event_create.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(249, 223);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(325, 79);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox_update
            // 
            this.groupBox_update.Controls.Add(this.button_update);
            this.groupBox_update.Controls.Add(this.textBox_price_update);
            this.groupBox_update.Controls.Add(this.label3);
            this.groupBox_update.Controls.Add(this.textBox_event_update);
            this.groupBox_update.Controls.Add(this.label4);
            this.groupBox_update.Location = new System.Drawing.Point(249, 104);
            this.groupBox_update.Name = "groupBox_update";
            this.groupBox_update.Size = new System.Drawing.Size(539, 113);
            this.groupBox_update.TabIndex = 3;
            this.groupBox_update.TabStop = false;
            this.groupBox_update.Text = "Update";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(212, 31);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(321, 50);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_price_update
            // 
            this.textBox_price_update.Location = new System.Drawing.Point(48, 61);
            this.textBox_price_update.Name = "textBox_price_update";
            this.textBox_price_update.Size = new System.Drawing.Size(158, 20);
            this.textBox_price_update.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // textBox_event_update
            // 
            this.textBox_event_update.Location = new System.Drawing.Point(48, 31);
            this.textBox_event_update.Name = "textBox_event_update";
            this.textBox_event_update.Size = new System.Drawing.Size(158, 20);
            this.textBox_event_update.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Event";
            // 
            // button_variables
            // 
            this.button_variables.Location = new System.Drawing.Point(580, 223);
            this.button_variables.Name = "button_variables";
            this.button_variables.Size = new System.Drawing.Size(208, 79);
            this.button_variables.TabIndex = 4;
            this.button_variables.Text = "Get env variables";
            this.button_variables.UseVisualStyleBackColor = true;
            this.button_variables.Click += new System.EventHandler(this.button_variables_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.button_variables);
            this.Controls.Add(this.groupBox_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_update.ResumeLayout(false);
            this.groupBox_update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_price_create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_event_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox_update;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_price_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_event_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_variables;
    }
}

