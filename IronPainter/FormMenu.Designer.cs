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
            this.SuspendLayout();
            // 
            // buttonEditorGameOssetianLoto
            // 
            this.buttonEditorGameOssetianLoto.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditorGameOssetianLoto.Location = new System.Drawing.Point(37, 161);
            this.buttonEditorGameOssetianLoto.Name = "buttonEditorGameOssetianLoto";
            this.buttonEditorGameOssetianLoto.Size = new System.Drawing.Size(434, 90);
            this.buttonEditorGameOssetianLoto.TabIndex = 0;
            this.buttonEditorGameOssetianLoto.Text = "РЕДАКТОР ИГРЫ \"ОСЕТИНСКОЕ ЛОТО\"";
            this.buttonEditorGameOssetianLoto.UseVisualStyleBackColor = true;
            this.buttonEditorGameOssetianLoto.Click += new System.EventHandler(this.buttonEditorGameOssetianLoto_Click);
            // 
            // buttonEditorGameTrain
            // 
            this.buttonEditorGameTrain.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditorGameTrain.Location = new System.Drawing.Point(37, 38);
            this.buttonEditorGameTrain.Name = "buttonEditorGameTrain";
            this.buttonEditorGameTrain.Size = new System.Drawing.Size(434, 90);
            this.buttonEditorGameTrain.TabIndex = 1;
            this.buttonEditorGameTrain.Text = "РЕДАКТОР ИГРЫ \"ПОЕЗД\"";
            this.buttonEditorGameTrain.UseVisualStyleBackColor = true;
            this.buttonEditorGameTrain.Click += new System.EventHandler(this.buttonEditorGameTrain_Click);
            // 
            // buttonMyCards
            // 
            this.buttonMyCards.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMyCards.Location = new System.Drawing.Point(37, 284);
            this.buttonMyCards.Name = "buttonMyCards";
            this.buttonMyCards.Size = new System.Drawing.Size(434, 90);
            this.buttonMyCards.TabIndex = 2;
            this.buttonMyCards.Text = "МОИ КАРТОЧКИ";
            this.buttonMyCards.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 415);
            this.Controls.Add(this.buttonMyCards);
            this.Controls.Add(this.buttonEditorGameTrain);
            this.Controls.Add(this.buttonEditorGameOssetianLoto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "IronPainter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditorGameOssetianLoto;
        private System.Windows.Forms.Button buttonEditorGameTrain;
        private System.Windows.Forms.Button buttonMyCards;
    }
}

