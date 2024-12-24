
namespace Lab06
{
    partial class ReviseForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.change_edge_button = new System.Windows.Forms.Button();
            this.to_vertex_combobox = new System.Windows.Forms.ComboBox();
            this.from_vertex_combobox = new System.Windows.Forms.ComboBox();
            this.change_vertex_button = new System.Windows.Forms.Button();
            this.yUpDown = new System.Windows.Forms.NumericUpDown();
            this.xUpDown = new System.Windows.Forms.NumericUpDown();
            this.done_button = new System.Windows.Forms.Button();
            this.vertex_ID_combobox = new System.Windows.Forms.ComboBox();
            this.edge_ID_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Edge ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "To Vertex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "From Vertex:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(7, 69);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(54, 13);
            this.ID.TabIndex = 25;
            this.ID.Text = "Vertex ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "X:";
            // 
            // change_edge_button
            // 
            this.change_edge_button.Location = new System.Drawing.Point(590, 140);
            this.change_edge_button.Name = "change_edge_button";
            this.change_edge_button.Size = new System.Drawing.Size(93, 23);
            this.change_edge_button.TabIndex = 21;
            this.change_edge_button.Text = "Change Edge";
            this.change_edge_button.UseVisualStyleBackColor = true;
            this.change_edge_button.Click += new System.EventHandler(this.change_edge_button_Click);
            // 
            // to_vertex_combobox
            // 
            this.to_vertex_combobox.FormattingEnabled = true;
            this.to_vertex_combobox.Location = new System.Drawing.Point(443, 140);
            this.to_vertex_combobox.Name = "to_vertex_combobox";
            this.to_vertex_combobox.Size = new System.Drawing.Size(121, 21);
            this.to_vertex_combobox.TabIndex = 20;
            // 
            // from_vertex_combobox
            // 
            this.from_vertex_combobox.FormattingEnabled = true;
            this.from_vertex_combobox.Location = new System.Drawing.Point(254, 140);
            this.from_vertex_combobox.Name = "from_vertex_combobox";
            this.from_vertex_combobox.Size = new System.Drawing.Size(121, 21);
            this.from_vertex_combobox.TabIndex = 19;
            // 
            // change_vertex_button
            // 
            this.change_vertex_button.Location = new System.Drawing.Point(590, 68);
            this.change_vertex_button.Name = "change_vertex_button";
            this.change_vertex_button.Size = new System.Drawing.Size(93, 23);
            this.change_vertex_button.TabIndex = 18;
            this.change_vertex_button.Text = "Change Vertex";
            this.change_vertex_button.UseVisualStyleBackColor = true;
            this.change_vertex_button.Click += new System.EventHandler(this.change_vertex_button_Click);
            // 
            // yUpDown
            // 
            this.yUpDown.Location = new System.Drawing.Point(458, 71);
            this.yUpDown.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.yUpDown.Name = "yUpDown";
            this.yUpDown.ReadOnly = true;
            this.yUpDown.Size = new System.Drawing.Size(106, 20);
            this.yUpDown.TabIndex = 17;
            // 
            // xUpDown
            // 
            this.xUpDown.Location = new System.Drawing.Point(269, 71);
            this.xUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.xUpDown.Name = "xUpDown";
            this.xUpDown.ReadOnly = true;
            this.xUpDown.Size = new System.Drawing.Size(106, 20);
            this.xUpDown.TabIndex = 16;
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(608, 197);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(75, 23);
            this.done_button.TabIndex = 15;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // vertex_ID_combobox
            // 
            this.vertex_ID_combobox.FormattingEnabled = true;
            this.vertex_ID_combobox.Location = new System.Drawing.Point(60, 66);
            this.vertex_ID_combobox.Name = "vertex_ID_combobox";
            this.vertex_ID_combobox.Size = new System.Drawing.Size(121, 21);
            this.vertex_ID_combobox.TabIndex = 30;
            // 
            // edge_ID_combobox
            // 
            this.edge_ID_combobox.FormattingEnabled = true;
            this.edge_ID_combobox.Location = new System.Drawing.Point(60, 137);
            this.edge_ID_combobox.Name = "edge_ID_combobox";
            this.edge_ID_combobox.Size = new System.Drawing.Size(121, 21);
            this.edge_ID_combobox.TabIndex = 31;
            // 
            // ReviseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 246);
            this.ControlBox = false;
            this.Controls.Add(this.edge_ID_combobox);
            this.Controls.Add(this.vertex_ID_combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.change_edge_button);
            this.Controls.Add(this.to_vertex_combobox);
            this.Controls.Add(this.from_vertex_combobox);
            this.Controls.Add(this.change_vertex_button);
            this.Controls.Add(this.yUpDown);
            this.Controls.Add(this.xUpDown);
            this.Controls.Add(this.done_button);
            this.Name = "ReviseForm";
            this.Text = "Revise Graph";
            this.Load += new System.EventHandler(this.ReviseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button change_edge_button;
        private System.Windows.Forms.ComboBox to_vertex_combobox;
        private System.Windows.Forms.ComboBox from_vertex_combobox;
        private System.Windows.Forms.Button change_vertex_button;
        private System.Windows.Forms.NumericUpDown yUpDown;
        private System.Windows.Forms.NumericUpDown xUpDown;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.ComboBox vertex_ID_combobox;
        private System.Windows.Forms.ComboBox edge_ID_combobox;
    }
}