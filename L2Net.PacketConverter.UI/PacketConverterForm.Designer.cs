namespace L2Net.PacketConverter.UI
{
    partial class PacketConverterForm
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
            this.rtbxHex = new System.Windows.Forms.RichTextBox();
            this.rtbxPlain = new System.Windows.Forms.RichTextBox();
            this.rbtnByte = new System.Windows.Forms.RadioButton();
            this.rbtnInt16 = new System.Windows.Forms.RadioButton();
            this.rbtnInt32 = new System.Windows.Forms.RadioButton();
            this.rbtnInt64 = new System.Windows.Forms.RadioButton();
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.labelHex = new System.Windows.Forms.Label();
            this.labelPlain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbxHex
            // 
            this.rtbxHex.Location = new System.Drawing.Point(12, 29);
            this.rtbxHex.Name = "rtbxHex";
            this.rtbxHex.Size = new System.Drawing.Size(247, 146);
            this.rtbxHex.TabIndex = 0;
            this.rtbxHex.Text = "";
            this.rtbxHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbxHex_KeyUp);
            // 
            // rtbxPlain
            // 
            this.rtbxPlain.Location = new System.Drawing.Point(291, 29);
            this.rtbxPlain.Name = "rtbxPlain";
            this.rtbxPlain.Size = new System.Drawing.Size(247, 146);
            this.rtbxPlain.TabIndex = 1;
            this.rtbxPlain.Text = "";
            this.rtbxPlain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbxPlain_KeyUp);
            // 
            // rbtnByte
            // 
            this.rbtnByte.AutoSize = true;
            this.rbtnByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByte.Location = new System.Drawing.Point(143, 192);
            this.rbtnByte.Name = "rbtnByte";
            this.rbtnByte.Size = new System.Drawing.Size(50, 17);
            this.rbtnByte.TabIndex = 2;
            this.rbtnByte.TabStop = true;
            this.rbtnByte.Text = "Byte";
            this.rbtnByte.UseVisualStyleBackColor = true;
            this.rbtnByte.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnInt16
            // 
            this.rbtnInt16.AutoSize = true;
            this.rbtnInt16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInt16.Location = new System.Drawing.Point(195, 192);
            this.rbtnInt16.Name = "rbtnInt16";
            this.rbtnInt16.Size = new System.Drawing.Size(54, 17);
            this.rbtnInt16.TabIndex = 3;
            this.rbtnInt16.TabStop = true;
            this.rbtnInt16.Text = "Int16";
            this.rbtnInt16.UseVisualStyleBackColor = true;
            this.rbtnInt16.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnInt32
            // 
            this.rbtnInt32.AutoSize = true;
            this.rbtnInt32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInt32.Location = new System.Drawing.Point(250, 192);
            this.rbtnInt32.Name = "rbtnInt32";
            this.rbtnInt32.Size = new System.Drawing.Size(54, 17);
            this.rbtnInt32.TabIndex = 4;
            this.rbtnInt32.TabStop = true;
            this.rbtnInt32.Text = "Int32";
            this.rbtnInt32.UseVisualStyleBackColor = true;
            this.rbtnInt32.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnInt64
            // 
            this.rbtnInt64.AutoSize = true;
            this.rbtnInt64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInt64.Location = new System.Drawing.Point(305, 192);
            this.rbtnInt64.Name = "rbtnInt64";
            this.rbtnInt64.Size = new System.Drawing.Size(54, 17);
            this.rbtnInt64.TabIndex = 5;
            this.rbtnInt64.TabStop = true;
            this.rbtnInt64.Text = "Int64";
            this.rbtnInt64.UseVisualStyleBackColor = true;
            this.rbtnInt64.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnString.Location = new System.Drawing.Point(360, 192);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(58, 17);
            this.rbtnString.TabIndex = 6;
            this.rbtnString.TabStop = true;
            this.rbtnString.Text = "String";
            this.rbtnString.UseVisualStyleBackColor = true;
            this.rbtnString.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHex.Location = new System.Drawing.Point(12, 7);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(70, 16);
            this.labelHex.TabIndex = 7;
            this.labelHex.Text = "Hex Value";
            // 
            // labelPlain
            // 
            this.labelPlain.AutoSize = true;
            this.labelPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlain.Location = new System.Drawing.Point(288, 7);
            this.labelPlain.Name = "labelPlain";
            this.labelPlain.Size = new System.Drawing.Size(67, 16);
            this.labelPlain.TabIndex = 8;
            this.labelPlain.Text = "Plain Text";
            // 
            // PacketConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 225);
            this.Controls.Add(this.labelPlain);
            this.Controls.Add(this.labelHex);
            this.Controls.Add(this.rbtnString);
            this.Controls.Add(this.rbtnInt64);
            this.Controls.Add(this.rbtnInt32);
            this.Controls.Add(this.rbtnInt16);
            this.Controls.Add(this.rbtnByte);
            this.Controls.Add(this.rtbxPlain);
            this.Controls.Add(this.rtbxHex);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(568, 264);
            this.MinimumSize = new System.Drawing.Size(568, 264);
            this.Name = "PacketConverterForm";
            this.Text = "L2NetPacketConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxHex;
        private System.Windows.Forms.RichTextBox rtbxPlain;
        private System.Windows.Forms.RadioButton rbtnByte;
        private System.Windows.Forms.RadioButton rbtnInt16;
        private System.Windows.Forms.RadioButton rbtnInt32;
        private System.Windows.Forms.RadioButton rbtnInt64;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.Label labelPlain;
    }
}

