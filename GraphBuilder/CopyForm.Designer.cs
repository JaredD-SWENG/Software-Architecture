
namespace Lab06
{
    partial class CopyForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.graph_ID_textbox = new System.Windows.Forms.TextBox();
            this.done_button = new System.Windows.Forms.Button();
            this.id_taken_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "New Graph ID:";
            // 
            // graph_ID_textbox
            // 
            this.graph_ID_textbox.Location = new System.Drawing.Point(117, 28);
            this.graph_ID_textbox.Name = "graph_ID_textbox";
            this.graph_ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.graph_ID_textbox.TabIndex = 17;
            this.graph_ID_textbox.TextChanged += new System.EventHandler(this.graph_ID_textbox_TextChanged);
            this.graph_ID_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.graph_ID_textbox_KeyPress);
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(80, 103);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(75, 23);
            this.done_button.TabIndex = 21;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // id_taken_label
            // 
            this.id_taken_label.AutoSize = true;
            this.id_taken_label.BackColor = System.Drawing.SystemColors.Control;
            this.id_taken_label.ForeColor = System.Drawing.Color.Red;
            this.id_taken_label.Location = new System.Drawing.Point(77, 66);
            this.id_taken_label.Name = "id_taken_label";
            this.id_taken_label.Size = new System.Drawing.Size(85, 13);
            this.id_taken_label.TabIndex = 22;
            this.id_taken_label.Text = "ID already taken";
            this.id_taken_label.Visible = false;
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 150);
            this.ControlBox = false;
            this.Controls.Add(this.id_taken_label);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.graph_ID_textbox);
            this.Name = "CopyForm";
            this.Text = "Copy Graph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox graph_ID_textbox;
        private System.Windows.Forms.ComboBox graph_ID_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Label id_taken_label;
    }
}