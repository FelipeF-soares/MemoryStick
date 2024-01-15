namespace MemoryStick.Views
{
    partial class UserControlSortWord
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxSortWord = new GroupBox();
            labelTotalHits = new Label();
            labelTotalWords = new Label();
            labelTotalHitsText = new Label();
            labelTotalWordText = new Label();
            buttonCompare = new Button();
            textBoxTranslation = new TextBox();
            labelTranslation = new Label();
            textBoxWordInPortuguese = new TextBox();
            labelWordInPortuguese = new Label();
            labelApresent = new Label();
            groupBoxSortWord.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSortWord
            // 
            groupBoxSortWord.Controls.Add(labelTotalHits);
            groupBoxSortWord.Controls.Add(labelTotalWords);
            groupBoxSortWord.Controls.Add(labelTotalHitsText);
            groupBoxSortWord.Controls.Add(labelTotalWordText);
            groupBoxSortWord.Controls.Add(buttonCompare);
            groupBoxSortWord.Controls.Add(textBoxTranslation);
            groupBoxSortWord.Controls.Add(labelTranslation);
            groupBoxSortWord.Controls.Add(textBoxWordInPortuguese);
            groupBoxSortWord.Controls.Add(labelWordInPortuguese);
            groupBoxSortWord.Controls.Add(labelApresent);
            groupBoxSortWord.Dock = DockStyle.Fill;
            groupBoxSortWord.Location = new Point(0, 0);
            groupBoxSortWord.Name = "groupBoxSortWord";
            groupBoxSortWord.Size = new Size(616, 479);
            groupBoxSortWord.TabIndex = 0;
            groupBoxSortWord.TabStop = false;
            // 
            // labelTotalHits
            // 
            labelTotalHits.AutoSize = true;
            labelTotalHits.Location = new Point(540, 57);
            labelTotalHits.Name = "labelTotalHits";
            labelTotalHits.Size = new Size(13, 15);
            labelTotalHits.TabIndex = 14;
            labelTotalHits.Text = "0";
            // 
            // labelTotalWords
            // 
            labelTotalWords.AutoSize = true;
            labelTotalWords.Location = new Point(540, 32);
            labelTotalWords.Name = "labelTotalWords";
            labelTotalWords.Size = new Size(13, 15);
            labelTotalWords.TabIndex = 13;
            labelTotalWords.Text = "0";
            // 
            // labelTotalHitsText
            // 
            labelTotalHitsText.AutoSize = true;
            labelTotalHitsText.ImageAlign = ContentAlignment.BottomLeft;
            labelTotalHitsText.Location = new Point(441, 57);
            labelTotalHitsText.Name = "labelTotalHitsText";
            labelTotalHitsText.Size = new Size(59, 15);
            labelTotalHitsText.TabIndex = 12;
            labelTotalHitsText.Text = "Total Hits:";
            // 
            // labelTotalWordText
            // 
            labelTotalWordText.AutoSize = true;
            labelTotalWordText.Location = new Point(441, 32);
            labelTotalWordText.Name = "labelTotalWordText";
            labelTotalWordText.Size = new Size(72, 15);
            labelTotalWordText.TabIndex = 11;
            labelTotalWordText.Text = "Total Words:";
            // 
            // buttonCompare
            // 
            buttonCompare.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCompare.Location = new Point(150, 303);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new Size(307, 44);
            buttonCompare.TabIndex = 10;
            buttonCompare.Text = "Compare Word";
            buttonCompare.UseVisualStyleBackColor = true;
            buttonCompare.Click += buttonCompare_Click;
            // 
            // textBoxTranslation
            // 
            textBoxTranslation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTranslation.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTranslation.Location = new Point(34, 212);
            textBoxTranslation.Name = "textBoxTranslation";
            textBoxTranslation.PlaceholderText = "Enter your word here!";
            textBoxTranslation.Size = new Size(544, 22);
            textBoxTranslation.TabIndex = 9;
            // 
            // labelTranslation
            // 
            labelTranslation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTranslation.AutoSize = true;
            labelTranslation.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTranslation.Location = new Point(34, 182);
            labelTranslation.Name = "labelTranslation";
            labelTranslation.Size = new Size(77, 16);
            labelTranslation.TabIndex = 8;
            labelTranslation.Text = "Translation:";
            // 
            // textBoxWordInPortuguese
            // 
            textBoxWordInPortuguese.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWordInPortuguese.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWordInPortuguese.Location = new Point(34, 120);
            textBoxWordInPortuguese.Name = "textBoxWordInPortuguese";
            textBoxWordInPortuguese.ReadOnly = true;
            textBoxWordInPortuguese.Size = new Size(544, 22);
            textBoxWordInPortuguese.TabIndex = 7;
            // 
            // labelWordInPortuguese
            // 
            labelWordInPortuguese.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWordInPortuguese.AutoSize = true;
            labelWordInPortuguese.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWordInPortuguese.Location = new Point(34, 90);
            labelWordInPortuguese.Name = "labelWordInPortuguese";
            labelWordInPortuguese.Size = new Size(128, 16);
            labelWordInPortuguese.TabIndex = 6;
            labelWordInPortuguese.Text = "Word In Portuguese:";
            // 
            // labelApresent
            // 
            labelApresent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelApresent.AutoSize = true;
            labelApresent.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelApresent.Location = new Point(150, 44);
            labelApresent.Name = "labelApresent";
            labelApresent.Size = new Size(264, 31);
            labelApresent.TabIndex = 5;
            labelApresent.Text = "What is the translation?";
            // 
            // UserControlSortWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxSortWord);
            Name = "UserControlSortWord";
            Size = new Size(616, 479);
            Load += UserControlSortWord_Load;
            groupBoxSortWord.ResumeLayout(false);
            groupBoxSortWord.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSortWord;
        private TextBox textBoxTranslation;
        private Label labelTranslation;
        private TextBox textBoxWordInPortuguese;
        private Label labelWordInPortuguese;
        private Label labelApresent;
        private Button buttonCompare;
        private Label labelTotalWordText;
        private Label labelTotalHitsText;
        private Label labelTotalHits;
        private Label labelTotalWords;
        protected Label label1;
    }
}
