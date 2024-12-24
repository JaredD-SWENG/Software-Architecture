
namespace Lab06
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_button = new System.Windows.Forms.Button();
            this.revise_button = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.graph_ID_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.print_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(160, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(40, 56);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 2;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // revise_button
            // 
            this.revise_button.Location = new System.Drawing.Point(40, 217);
            this.revise_button.Name = "revise_button";
            this.revise_button.Size = new System.Drawing.Size(75, 23);
            this.revise_button.TabIndex = 3;
            this.revise_button.Text = "Revise";
            this.revise_button.UseVisualStyleBackColor = true;
            this.revise_button.Click += new System.EventHandler(this.revise_button_Click);
            // 
            // copy_button
            // 
            this.copy_button.Location = new System.Drawing.Point(40, 256);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(75, 23);
            this.copy_button.TabIndex = 4;
            this.copy_button.Text = "Copy";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // graph_ID_combobox
            // 
            this.graph_ID_combobox.FormattingEnabled = true;
            this.graph_ID_combobox.Location = new System.Drawing.Point(22, 190);
            this.graph_ID_combobox.Name = "graph_ID_combobox";
            this.graph_ID_combobox.Size = new System.Drawing.Size(121, 21);
            this.graph_ID_combobox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Graph";
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(40, 296);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(75, 23);
            this.print_button.TabIndex = 7;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 483);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graph_ID_combobox);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.revise_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button revise_button;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.ComboBox graph_ID_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button print_button;
    }
}

