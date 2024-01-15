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
            // buttonCompare
            // 
            buttonCompare.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            labelTranslation.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTranslation.Location = new Point(34, 182);
            labelTranslation.Name = "labelTranslation";
            labelTranslation.Size = new Size(85, 15);
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
            labelWordInPortuguese.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWordInPortuguese.Location = new Point(34, 90);
            labelWordInPortuguese.Name = "labelWordInPortuguese";
            labelWordInPortuguese.Size = new Size(138, 15);
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
    }
}
