
namespace Lab06
{
    partial class CreateForm
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
            this.done_button = new System.Windows.Forms.Button();
            this.xUpDown = new System.Windows.Forms.NumericUpDown();
            this.yUpDown = new System.Windows.Forms.NumericUpDown();
            this.add_vertex_button = new System.Windows.Forms.Button();
            this.from_vertex_combobox = new System.Windows.Forms.ComboBox();
            this.to_vertex_combobox = new System.Windows.Forms.ComboBox();
            this.add_edge_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vertex_ID_textbox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edge_ID_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.graph_ID_textbox = new System.Windows.Forms.TextBox();
            this.id_taken_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(585, 226);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(75, 23);
            this.done_button.TabIndex = 0;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // xUpDown
            // 
            this.xUpDown.Location = new System.Drawing.Point(264, 85);
            this.xUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.xUpDown.Name = "xUpDown";
            this.xUpDown.ReadOnly = true;
            this.xUpDown.Size = new System.Drawing.Size(106, 20);
            this.xUpDown.TabIndex = 1;
            // 
            // yUpDown
            // 
            this.yUpDown.Location = new System.Drawing.Point(453, 85);
            this.yUpDown.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.yUpDown.Name = "yUpDown";
            this.yUpDown.ReadOnly = true;
            this.yUpDown.Size = new System.Drawing.Size(106, 20);
            this.yUpDown.TabIndex = 2;
            // 
            // add_vertex_button
            // 
            this.add_vertex_button.Location = new System.Drawing.Point(585, 82);
            this.add_vertex_button.Name = "add_vertex_button";
            this.add_vertex_button.Size = new System.Drawing.Size(75, 23);
            this.add_vertex_button.TabIndex = 3;
            this.add_vertex_button.Text = "Add Vertex";
            this.add_vertex_button.UseVisualStyleBackColor = true;
            this.add_vertex_button.Click += new System.EventHandler(this.add_vertex_button_Click);
            // 
            // from_vertex_combobox
            // 
            this.from_vertex_combobox.FormattingEnabled = true;
            this.from_vertex_combobox.Location = new System.Drawing.Point(249, 154);
            this.from_vertex_combobox.Name = "from_vertex_combobox";
            this.from_vertex_combobox.Size = new System.Drawing.Size(121, 21);
            this.from_vertex_combobox.TabIndex = 4;
            // 
            // to_vertex_combobox
            // 
            this.to_vertex_combobox.FormattingEnabled = true;
            this.to_vertex_combobox.Location = new System.Drawing.Point(438, 154);
            this.to_vertex_combobox.Name = "to_vertex_combobox";
            this.to_vertex_combobox.Size = new System.Drawing.Size(121, 21);
            this.to_vertex_combobox.TabIndex = 5;
            // 
            // add_edge_button
            // 
            this.add_edge_button.Location = new System.Drawing.Point(585, 154);
            this.add_edge_button.Name = "add_edge_button";
            this.add_edge_button.Size = new System.Drawing.Size(75, 23);
            this.add_edge_button.TabIndex = 6;
            this.add_edge_button.Text = "Add Edge";
            this.add_edge_button.UseVisualStyleBackColor = true;
            this.add_edge_button.Click += new System.EventHandler(this.add_edge_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y:";
            // 
            // vertex_ID_textbox
            // 
            this.vertex_ID_textbox.Location = new System.Drawing.Point(65, 81);
            this.vertex_ID_textbox.MaxLength = 9;
            this.vertex_ID_textbox.Name = "vertex_ID_textbox";
            this.vertex_ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.vertex_ID_textbox.TabIndex = 9;
            this.vertex_ID_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vertex_ID_textbox_KeyPress);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(5, 84);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(54, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "Vertex ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "From Vertex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To Vertex:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Edge ID:";
            // 
            // edge_ID_textbox
            // 
            this.edge_ID_textbox.Location = new System.Drawing.Point(65, 152);
            this.edge_ID_textbox.MaxLength = 9;
            this.edge_ID_textbox.Name = "edge_ID_textbox";
            this.edge_ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.edge_ID_textbox.TabIndex = 13;
            this.edge_ID_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vertex_ID_textbox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Graph ID:";
            // 
            // graph_ID_textbox
            // 
            this.graph_ID_textbox.Location = new System.Drawing.Point(270, 24);
            this.graph_ID_textbox.MaxLength = 9;
            this.graph_ID_textbox.Name = "graph_ID_textbox";
            this.graph_ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.graph_ID_textbox.TabIndex = 15;
            this.graph_ID_textbox.TextChanged += new System.EventHandler(this.graph_ID_textbox_TextChanged);
            this.graph_ID_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vertex_ID_textbox_KeyPress);
            // 
            // id_taken_label
            // 
            this.id_taken_label.AutoSize = true;
            this.id_taken_label.BackColor = System.Drawing.SystemColors.Control;
            this.id_taken_label.ForeColor = System.Drawing.Color.Red;
            this.id_taken_label.Location = new System.Drawing.Point(402, 27);
            this.id_taken_label.Name = "id_taken_label";
            this.id_taken_label.Size = new System.Drawing.Size(85, 13);
            this.id_taken_label.TabIndex = 23;
            this.id_taken_label.Text = "ID already taken";
            this.id_taken_label.Visible = false;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 278);
            this.ControlBox = false;
            this.Controls.Add(this.id_taken_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.graph_ID_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edge_ID_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.vertex_ID_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_edge_button);
            this.Controls.Add(this.to_vertex_combobox);
            this.Controls.Add(this.from_vertex_combobox);
            this.Controls.Add(this.add_vertex_button);
            this.Controls.Add(this.yUpDown);
            this.Controls.Add(this.xUpDown);
            this.Controls.Add(this.done_button);
            this.Name = "CreateForm";
            this.Text = "Create Graph";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.NumericUpDown xUpDown;
        private System.Windows.Forms.NumericUpDown yUpDown;
        private System.Windows.Forms.Button add_vertex_button;
        private System.Windows.Forms.ComboBox from_vertex_combobox;
        private System.Windows.Forms.ComboBox to_vertex_combobox;
        private System.Windows.Forms.Button add_edge_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vertex_ID_textbox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edge_ID_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox graph_ID_textbox;
        private System.Windows.Forms.Label id_taken_label;
    }
}