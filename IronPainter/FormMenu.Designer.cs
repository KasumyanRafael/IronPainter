namespace IronPainter
{
    partial class FormMenu
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
            this.buttonEditorGameOssetianLoto = new System.Windows.Forms.Button();
            this.buttonEditorGameTrain = new System.Windows.Forms.Button();
            this.buttonMyCards = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditorGameOssetianLoto
            // 
            this.buttonEditorGameOssetianLoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditorGameOssetianLoto.Location = new System.Drawing.Point(28, 131);
            this.buttonEditorGameOssetianLoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditorGameOssetianLoto.Name = "buttonEditorGameOssetianLoto";
            this.buttonEditorGameOssetianLoto.Size = new System.Drawing.Size(326, 73);
            this.buttonEditorGameOssetianLoto.TabIndex = 0;
            this.buttonEditorGameOssetianLoto.Text = "РЕДАКТОР ИГРЫ \"ОСЕТИНСКОЕ ЛОТО\"";
            this.buttonEditorGameOssetianLoto.UseVisualStyleBackColor = true;
            this.buttonEditorGameOssetianLoto.Click += new System.EventHandler(this.buttonEditorGameOssetianLoto_Click);
            // 
            // buttonEditorGameTrain
            // 
            this.buttonEditorGameTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditorGameTrain.Location = new System.Drawing.Point(28, 31);
            this.buttonEditorGameTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditorGameTrain.Name = "buttonEditorGameTrain";
            this.buttonEditorGameTrain.Size = new System.Drawing.Size(326, 73);
            this.buttonEditorGameTrain.TabIndex = 1;
            this.buttonEditorGameTrain.Text = "РЕДАКТОР ИГРЫ \"ПОЕЗД\"";
            this.buttonEditorGameTrain.UseVisualStyleBackColor = true;
            this.buttonEditorGameTrain.Click += new System.EventHandler(this.buttonEditorGameTrain_Click);
            // 
            // buttonMyCards
            // 
            this.buttonMyCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMyCards.Location = new System.Drawing.Point(28, 231);
            this.buttonMyCards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMyCards.Name = "buttonMyCards";
            this.buttonMyCards.Size = new System.Drawing.Size(326, 73);
            this.buttonMyCards.TabIndex = 2;
            this.buttonMyCards.Text = "МОИ КАРТОЧКИ";
            this.buttonMyCards.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "ВЫХОД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMyCards);
            this.Controls.Add(this.buttonEditorGameTrain);
            this.Controls.Add(this.buttonEditorGameOssetianLoto);
            this.Name = "FormMenu";
            this.Text = "IronPainter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditorGameOssetianLoto;
        private System.Windows.Forms.Button buttonEditorGameTrain;
        private System.Windows.Forms.Button buttonMyCards;
        private System.Windows.Forms.Button button1;
    }
}

