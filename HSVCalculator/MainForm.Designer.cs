
namespace HSVCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.hueSetter = new System.Windows.Forms.TrackBar();
            this.saturationSetter = new System.Windows.Forms.TrackBar();
            this.brightnessSetter = new System.Windows.Forms.TrackBar();
            this.blueSetter = new System.Windows.Forms.TrackBar();
            this.greenSetter = new System.Windows.Forms.TrackBar();
            this.redSetter = new System.Windows.Forms.TrackBar();
            this.hueLabel = new System.Windows.Forms.Label();
            this.saturationLabel = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hueSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSetter)).BeginInit();
            this.SuspendLayout();
            // 
            // hueSetter
            // 
            this.hueSetter.BackColor = System.Drawing.Color.Black;
            this.hueSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hueSetter.Location = new System.Drawing.Point(60, 100);
            this.hueSetter.Name = "hueSetter";
            this.hueSetter.Size = new System.Drawing.Size(165, 56);
            this.hueSetter.TabIndex = 0;
            // 
            // saturationSetter
            // 
            this.saturationSetter.BackColor = System.Drawing.Color.Black;
            this.saturationSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saturationSetter.Location = new System.Drawing.Point(60, 200);
            this.saturationSetter.Name = "saturationSetter";
            this.saturationSetter.Size = new System.Drawing.Size(165, 56);
            this.saturationSetter.TabIndex = 1;
            // 
            // brightnessSetter
            // 
            this.brightnessSetter.BackColor = System.Drawing.Color.Black;
            this.brightnessSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brightnessSetter.Location = new System.Drawing.Point(60, 300);
            this.brightnessSetter.Name = "brightnessSetter";
            this.brightnessSetter.Size = new System.Drawing.Size(165, 56);
            this.brightnessSetter.TabIndex = 2;
            // 
            // blueSetter
            // 
            this.blueSetter.BackColor = System.Drawing.Color.Black;
            this.blueSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueSetter.Location = new System.Drawing.Point(560, 300);
            this.blueSetter.Name = "blueSetter";
            this.blueSetter.Size = new System.Drawing.Size(165, 56);
            this.blueSetter.TabIndex = 5;
            // 
            // greenSetter
            // 
            this.greenSetter.BackColor = System.Drawing.Color.Black;
            this.greenSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenSetter.Location = new System.Drawing.Point(560, 200);
            this.greenSetter.Name = "greenSetter";
            this.greenSetter.Size = new System.Drawing.Size(165, 56);
            this.greenSetter.TabIndex = 4;
            // 
            // redSetter
            // 
            this.redSetter.BackColor = System.Drawing.Color.Black;
            this.redSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redSetter.Location = new System.Drawing.Point(560, 100);
            this.redSetter.Name = "redSetter";
            this.redSetter.Size = new System.Drawing.Size(165, 56);
            this.redSetter.TabIndex = 3;
            // 
            // hueLabel
            // 
            this.hueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hueLabel.ForeColor = System.Drawing.Color.White;
            this.hueLabel.Location = new System.Drawing.Point(230, 100);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(30, 23);
            this.hueLabel.TabIndex = 6;
            this.hueLabel.Text = "H";
            this.hueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saturationLabel
            // 
            this.saturationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saturationLabel.ForeColor = System.Drawing.Color.White;
            this.saturationLabel.Location = new System.Drawing.Point(230, 200);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(30, 23);
            this.saturationLabel.TabIndex = 7;
            this.saturationLabel.Text = "S";
            this.saturationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brightnessLabel.ForeColor = System.Drawing.Color.White;
            this.brightnessLabel.Location = new System.Drawing.Point(230, 300);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(30, 23);
            this.brightnessLabel.TabIndex = 8;
            this.brightnessLabel.Text = "V";
            this.brightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(530, 300);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(30, 23);
            this.blueLabel.TabIndex = 11;
            this.blueLabel.Text = "B";
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenLabel.ForeColor = System.Drawing.Color.White;
            this.greenLabel.Location = new System.Drawing.Point(530, 200);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(30, 23);
            this.greenLabel.TabIndex = 10;
            this.greenLabel.Text = "G";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(530, 100);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(30, 23);
            this.redLabel.TabIndex = 9;
            this.redLabel.Text = "R";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.White;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.Location = new System.Drawing.Point(560, 384);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(161, 37);
            this.infoButton.TabIndex = 12;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.White;
            this.copyButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.copyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.copyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyButton.Location = new System.Drawing.Point(330, 384);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(125, 37);
            this.copyButton.TabIndex = 13;
            this.copyButton.Text = "Копировать RGB";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.saturationLabel);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.blueSetter);
            this.Controls.Add(this.greenSetter);
            this.Controls.Add(this.redSetter);
            this.Controls.Add(this.brightnessSetter);
            this.Controls.Add(this.saturationSetter);
            this.Controls.Add(this.hueSetter);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSV/RGB calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hueSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar hueSetter;
        private System.Windows.Forms.TrackBar saturationSetter;
        private System.Windows.Forms.TrackBar brightnessSetter;
        private System.Windows.Forms.TrackBar blueSetter;
        private System.Windows.Forms.TrackBar greenSetter;
        private System.Windows.Forms.TrackBar redSetter;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.Label saturationLabel;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button copyButton;
    }
}

