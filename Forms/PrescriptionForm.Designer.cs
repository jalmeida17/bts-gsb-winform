namespace bts_gsb.Forms
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            dataGridView1 = new DataGridView();
            dataGridView3 = new DataGridView();
            quantityTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 171);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 260);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(240, 178);
            dataGridView3.TabIndex = 2;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(12, 204);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(39, 23);
            quantityTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(57, 203);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 4;
            button1.Text = "Add Quantity";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 242);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 5;
            label1.Text = "Selected Medecines";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Medecines";
            // 
            // button2
            // 
            button2.Location = new Point(70, 447);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 7;
            button2.Text = "Create Prescription";
            button2.UseVisualStyleBackColor = true;
            // 
            // PrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 482);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(quantityTextBox);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrescriptionForm";
            Text = "- Create a Prescription";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView3;
        private TextBox quantityTextBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}