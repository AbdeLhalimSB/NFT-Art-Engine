
namespace NFT_Art_Engine
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
            this.load_layers = new System.Windows.Forms.Button();
            this.output_path = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ntf_count = new System.Windows.Forms.NumericUpDown();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ntf_count)).BeginInit();
            this.SuspendLayout();
            // 
            // load_layers
            // 
            this.load_layers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.load_layers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_layers.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_layers.ForeColor = System.Drawing.Color.Crimson;
            this.load_layers.Location = new System.Drawing.Point(42, 33);
            this.load_layers.Name = "load_layers";
            this.load_layers.Size = new System.Drawing.Size(209, 48);
            this.load_layers.TabIndex = 0;
            this.load_layers.Text = "Load Layers";
            this.load_layers.UseVisualStyleBackColor = true;
            this.load_layers.Click += new System.EventHandler(this.load_layers_Click);
            // 
            // output_path
            // 
            this.output_path.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.output_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.output_path.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_path.ForeColor = System.Drawing.Color.Crimson;
            this.output_path.Location = new System.Drawing.Point(42, 126);
            this.output_path.Name = "output_path";
            this.output_path.Size = new System.Drawing.Size(209, 48);
            this.output_path.TabIndex = 1;
            this.output_path.Text = "Select output";
            this.output_path.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Crimson;
            this.Start.Location = new System.Drawing.Point(42, 523);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(209, 48);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "NFT Count : ";
            // 
            // ntf_count
            // 
            this.ntf_count.Location = new System.Drawing.Point(214, 224);
            this.ntf_count.Name = "ntf_count";
            this.ntf_count.Size = new System.Drawing.Size(120, 20);
            this.ntf_count.TabIndex = 4;
            this.ntf_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(581, 78);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(323, 384);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(577, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Logs :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(950, 601);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.ntf_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.output_path);
            this.Controls.Add(this.load_layers);
            this.Name = "Form1";
            this.Text = "NFT Art Engine";
            ((System.ComponentModel.ISupportInitialize)(this.ntf_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_layers;
        private System.Windows.Forms.Button output_path;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ntf_count;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Label label2;
    }
}

