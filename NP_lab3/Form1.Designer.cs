namespace NP_lab3
{
    partial class Form1
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
            this.PredictorKey = new System.Windows.Forms.TextBox();
            this.PredictorInput = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.Predict = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Hints = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PredictorLangs = new System.Windows.Forms.ComboBox();
            this.PredictorLimit = new System.Windows.Forms.TextBox();
            this.ClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PredictorKey
            // 
            this.PredictorKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictorKey.Location = new System.Drawing.Point(35, 12);
            this.PredictorKey.Name = "PredictorKey";
            this.PredictorKey.Size = new System.Drawing.Size(416, 20);
            this.PredictorKey.TabIndex = 39;
            this.PredictorKey.Text = "pdct.1.1.20180408T085800Z.762eb72b6bbeb677.cf04856104e00e2df249e4bd901303486f09ba" +
    "03";
            // 
            // PredictorInput
            // 
            this.PredictorInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictorInput.Location = new System.Drawing.Point(66, 123);
            this.PredictorInput.Name = "PredictorInput";
            this.PredictorInput.Size = new System.Drawing.Size(385, 20);
            this.PredictorInput.TabIndex = 25;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(5, 41);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(28, 13);
            this.label32.TabIndex = 42;
            this.label32.Text = "Limit";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(2, 428);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(291, 13);
            this.label28.TabIndex = 41;
            this.label28.Text = "Реализовано с помощью сервиса «Яндекс.Предиктор»";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(299, 428);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(152, 13);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://api.yandex.ru/predictor/";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 13);
            this.label25.TabIndex = 38;
            this.label25.Text = "Key";
            // 
            // Predict
            // 
            this.Predict.Location = new System.Drawing.Point(66, 299);
            this.Predict.Name = "Predict";
            this.Predict.Size = new System.Drawing.Size(137, 42);
            this.Predict.TabIndex = 37;
            this.Predict.Text = "Predict";
            this.Predict.UseVisualStyleBackColor = true;
            this.Predict.Click += new System.EventHandler(this.Predict_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Hints";
            // 
            // Hints
            // 
            this.Hints.FormattingEnabled = true;
            this.Hints.Location = new System.Drawing.Point(66, 159);
            this.Hints.Name = "Hints";
            this.Hints.Size = new System.Drawing.Size(385, 134);
            this.Hints.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Language";
            // 
            // PredictorLangs
            // 
            this.PredictorLangs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PredictorLangs.FormattingEnabled = true;
            this.PredictorLangs.Location = new System.Drawing.Point(78, 64);
            this.PredictorLangs.Name = "PredictorLangs";
            this.PredictorLangs.Size = new System.Drawing.Size(54, 21);
            this.PredictorLangs.TabIndex = 26;
            // 
            // PredictorLimit
            // 
            this.PredictorLimit.Location = new System.Drawing.Point(78, 38);
            this.PredictorLimit.Name = "PredictorLimit";
            this.PredictorLimit.Size = new System.Drawing.Size(54, 20);
            this.PredictorLimit.TabIndex = 44;
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(314, 299);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(137, 42);
            this.ClearList.TabIndex = 45;
            this.ClearList.Text = "Clear";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.PredictorLimit);
            this.Controls.Add(this.PredictorKey);
            this.Controls.Add(this.PredictorInput);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.Predict);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Hints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PredictorLangs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PredictorKey;
        private System.Windows.Forms.TextBox PredictorInput;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button Predict;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox Hints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PredictorLangs;
        private System.Windows.Forms.TextBox PredictorLimit;
        private System.Windows.Forms.Button ClearList;
    }
}

