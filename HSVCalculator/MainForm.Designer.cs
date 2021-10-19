
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
            this.copyHSVButton = new System.Windows.Forms.Button();
            this.copyRGBButton = new System.Windows.Forms.Button();
            this.hueValue = new System.Windows.Forms.Label();
            this.saturationValue = new System.Windows.Forms.Label();
            this.brightnessValue = new System.Windows.Forms.Label();
            this.blueValue = new System.Windows.Forms.Label();
            this.greenValue = new System.Windows.Forms.Label();
            this.redValue = new System.Windows.Forms.Label();
            this.colorVisualisation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hueSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorVisualisation)).BeginInit();
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
            this.hueSetter.Scroll += new System.EventHandler(this.hueSetter_Scroll);
            // 
            // saturationSetter
            // 
            this.saturationSetter.BackColor = System.Drawing.Color.Black;
            this.saturationSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saturationSetter.Location = new System.Drawing.Point(60, 200);
            this.saturationSetter.Name = "saturationSetter";
            this.saturationSetter.Size = new System.Drawing.Size(165, 56);
            this.saturationSetter.TabIndex = 1;
            this.saturationSetter.Scroll += new System.EventHandler(this.saturationSetter_Scroll);
            // 
            // brightnessSetter
            // 
            this.brightnessSetter.BackColor = System.Drawing.Color.Black;
            this.brightnessSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brightnessSetter.Location = new System.Drawing.Point(60, 300);
            this.brightnessSetter.Name = "brightnessSetter";
            this.brightnessSetter.Size = new System.Drawing.Size(165, 56);
            this.brightnessSetter.TabIndex = 2;
            this.brightnessSetter.Scroll += new System.EventHandler(this.brightnessSetter_Scroll);
            // 
            // blueSetter
            // 
            this.blueSetter.BackColor = System.Drawing.Color.Black;
            this.blueSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueSetter.Location = new System.Drawing.Point(560, 300);
            this.blueSetter.Name = "blueSetter";
            this.blueSetter.Size = new System.Drawing.Size(165, 56);
            this.blueSetter.TabIndex = 5;
            this.blueSetter.Scroll += new System.EventHandler(this.blueSetter_Scroll);
            // 
            // greenSetter
            // 
            this.greenSetter.BackColor = System.Drawing.Color.Black;
            this.greenSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenSetter.Location = new System.Drawing.Point(560, 200);
            this.greenSetter.Name = "greenSetter";
            this.greenSetter.Size = new System.Drawing.Size(165, 56);
            this.greenSetter.TabIndex = 4;
            this.greenSetter.Scroll += new System.EventHandler(this.greenSetter_Scroll);
            // 
            // redSetter
            // 
            this.redSetter.BackColor = System.Drawing.Color.Black;
            this.redSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redSetter.Location = new System.Drawing.Point(560, 100);
            this.redSetter.Name = "redSetter";
            this.redSetter.Size = new System.Drawing.Size(165, 56);
            this.redSetter.TabIndex = 3;
            this.redSetter.Scroll += new System.EventHandler(this.redSetter_Scroll);
            // 
            // hueLabel
            // 
            this.hueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hueLabel.ForeColor = System.Drawing.Color.White;
            this.hueLabel.Location = new System.Drawing.Point(30, 100);
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
            this.saturationLabel.Location = new System.Drawing.Point(30, 200);
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
            this.brightnessLabel.Location = new System.Drawing.Point(30, 300);
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
            this.blueLabel.Location = new System.Drawing.Point(730, 300);
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
            this.greenLabel.Location = new System.Drawing.Point(730, 200);
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
            this.redLabel.Location = new System.Drawing.Point(730, 100);
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
            this.infoButton.Location = new System.Drawing.Point(313, 381);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(161, 37);
            this.infoButton.TabIndex = 12;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // copyHSVButton
            // 
            this.copyHSVButton.BackColor = System.Drawing.Color.White;
            this.copyHSVButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.copyHSVButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.copyHSVButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.copyHSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyHSVButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyHSVButton.Location = new System.Drawing.Point(35, 381);
            this.copyHSVButton.Name = "copyHSVButton";
            this.copyHSVButton.Size = new System.Drawing.Size(190, 38);
            this.copyHSVButton.TabIndex = 13;
            this.copyHSVButton.Text = "Копировать HSV";
            this.copyHSVButton.UseVisualStyleBackColor = false;
            this.copyHSVButton.Click += new System.EventHandler(this.copyHSVButton_Click);
            // 
            // copyRGBButton
            // 
            this.copyRGBButton.BackColor = System.Drawing.Color.White;
            this.copyRGBButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.copyRGBButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.copyRGBButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.copyRGBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyRGBButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyRGBButton.Location = new System.Drawing.Point(560, 380);
            this.copyRGBButton.Name = "copyRGBButton";
            this.copyRGBButton.Size = new System.Drawing.Size(190, 38);
            this.copyRGBButton.TabIndex = 14;
            this.copyRGBButton.Text = "Копировать RGB";
            this.copyRGBButton.UseVisualStyleBackColor = false;
            this.copyRGBButton.Click += new System.EventHandler(this.copyRGBButton_Click);
            // 
            // hueValue
            // 
            this.hueValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hueValue.ForeColor = System.Drawing.Color.White;
            this.hueValue.Location = new System.Drawing.Point(231, 100);
            this.hueValue.Name = "hueValue";
            this.hueValue.Size = new System.Drawing.Size(66, 23);
            this.hueValue.TabIndex = 15;
            this.hueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saturationValue
            // 
            this.saturationValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saturationValue.ForeColor = System.Drawing.Color.White;
            this.saturationValue.Location = new System.Drawing.Point(231, 200);
            this.saturationValue.Name = "saturationValue";
            this.saturationValue.Size = new System.Drawing.Size(66, 23);
            this.saturationValue.TabIndex = 16;
            this.saturationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brightnessValue
            // 
            this.brightnessValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brightnessValue.ForeColor = System.Drawing.Color.White;
            this.brightnessValue.Location = new System.Drawing.Point(231, 300);
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Size = new System.Drawing.Size(66, 23);
            this.brightnessValue.TabIndex = 17;
            this.brightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueValue
            // 
            this.blueValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueValue.ForeColor = System.Drawing.Color.White;
            this.blueValue.Location = new System.Drawing.Point(488, 300);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(66, 23);
            this.blueValue.TabIndex = 20;
            this.blueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenValue
            // 
            this.greenValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenValue.ForeColor = System.Drawing.Color.White;
            this.greenValue.Location = new System.Drawing.Point(488, 200);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(66, 23);
            this.greenValue.TabIndex = 19;
            this.greenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redValue
            // 
            this.redValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redValue.ForeColor = System.Drawing.Color.White;
            this.redValue.Location = new System.Drawing.Point(488, 100);
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(66, 23);
            this.redValue.TabIndex = 18;
            this.redValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorVisualisation
            // 
            this.colorVisualisation.BackColor = System.Drawing.Color.Transparent;
            this.colorVisualisation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorVisualisation.Location = new System.Drawing.Point(313, 100);
            this.colorVisualisation.Name = "colorVisualisation";
            this.colorVisualisation.Size = new System.Drawing.Size(161, 223);
            this.colorVisualisation.TabIndex = 21;
            this.colorVisualisation.TabStop = false;
            this.colorVisualisation.Paint += new System.Windows.Forms.PaintEventHandler(this.colorVisualisation_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.colorVisualisation);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.greenValue);
            this.Controls.Add(this.redValue);
            this.Controls.Add(this.brightnessValue);
            this.Controls.Add(this.saturationValue);
            this.Controls.Add(this.hueValue);
            this.Controls.Add(this.copyRGBButton);
            this.Controls.Add(this.copyHSVButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.colorVisualisation)).EndInit();
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
        private System.Windows.Forms.Button copyHSVButton;
        private System.Windows.Forms.Button copyRGBButton;
        private System.Windows.Forms.Label hueValue;
        private System.Windows.Forms.Label saturationValue;
        private System.Windows.Forms.Label brightnessValue;
        private System.Windows.Forms.Label blueValue;
        private System.Windows.Forms.Label greenValue;
        private System.Windows.Forms.Label redValue;
        private System.Windows.Forms.PictureBox colorVisualisation;
    }
}

