namespace MemoryStick.Views
{
    partial class UserControlAddNewWord
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
            labelApresent = new Label();
            labelWordInPortuguese = new Label();
            groupBoxAddNewWord = new GroupBox();
            buttonAddNewWord = new Button();
            textBoxOtherLanguage = new TextBox();
            labelWordInOtherLanguage = new Label();
            textBoxWordInPortuguese = new TextBox();
            groupBoxAddNewWord.SuspendLayout();
            SuspendLayout();
            // 
            // labelApresent
            // 
            labelApresent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelApresent.AutoSize = true;
            labelApresent.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelApresent.Location = new Point(151, 44);
            labelApresent.Name = "labelApresent";
            labelApresent.Size = new Size(294, 31);
            labelApresent.TabIndex = 0;
            labelApresent.Text = "Add your new words here!";
            // 
            // labelWordInPortuguese
            // 
            labelWordInPortuguese.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWordInPortuguese.AutoSize = true;
            labelWordInPortuguese.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWordInPortuguese.Location = new Point(35, 90);
            labelWordInPortuguese.Name = "labelWordInPortuguese";
            labelWordInPortuguese.Size = new Size(138, 15);
            labelWordInPortuguese.TabIndex = 1;
            labelWordInPortuguese.Text = "Word In Portuguese:";
            // 
            // groupBoxAddNewWord
            // 
            groupBoxAddNewWord.Controls.Add(buttonAddNewWord);
            groupBoxAddNewWord.Controls.Add(textBoxOtherLanguage);
            groupBoxAddNewWord.Controls.Add(labelWordInOtherLanguage);
            groupBoxAddNewWord.Controls.Add(textBoxWordInPortuguese);
            groupBoxAddNewWord.Controls.Add(labelWordInPortuguese);
            groupBoxAddNewWord.Controls.Add(labelApresent);
            groupBoxAddNewWord.Dock = DockStyle.Fill;
            groupBoxAddNewWord.Location = new Point(0, 0);
            groupBoxAddNewWord.Name = "groupBoxAddNewWord";
            groupBoxAddNewWord.Size = new Size(616, 479);
            groupBoxAddNewWord.TabIndex = 2;
            groupBoxAddNewWord.TabStop = false;
            // 
            // buttonAddNewWord
            // 
            buttonAddNewWord.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddNewWord.Location = new Point(127, 289);
            buttonAddNewWord.Name = "buttonAddNewWord";
            buttonAddNewWord.Size = new Size(307, 44);
            buttonAddNewWord.TabIndex = 5;
            buttonAddNewWord.Text = "Add";
            buttonAddNewWord.UseVisualStyleBackColor = true;
            buttonAddNewWord.Click += buttonAddNewWord_Click;
            // 
            // textBoxOtherLanguage
            // 
            textBoxOtherLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOtherLanguage.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOtherLanguage.Location = new Point(35, 212);
            textBoxOtherLanguage.Name = "textBoxOtherLanguage";
            textBoxOtherLanguage.Size = new Size(544, 22);
            textBoxOtherLanguage.TabIndex = 4;
            // 
            // labelWordInOtherLanguage
            // 
            labelWordInOtherLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWordInOtherLanguage.AutoSize = true;
            labelWordInOtherLanguage.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWordInOtherLanguage.Location = new Point(35, 182);
            labelWordInOtherLanguage.Name = "labelWordInOtherLanguage";
            labelWordInOtherLanguage.Size = new Size(167, 15);
            labelWordInOtherLanguage.TabIndex = 3;
            labelWordInOtherLanguage.Text = "Word In Other Language:";
            // 
            // textBoxWordInPortuguese
            // 
            textBoxWordInPortuguese.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWordInPortuguese.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWordInPortuguese.Location = new Point(35, 120);
            textBoxWordInPortuguese.Name = "textBoxWordInPortuguese";
            textBoxWordInPortuguese.Size = new Size(544, 22);
            textBoxWordInPortuguese.TabIndex = 2;
            // 
            // UserControlAddNewWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxAddNewWord);
            Name = "UserControlAddNewWord";
            Size = new Size(616, 479);
            groupBoxAddNewWord.ResumeLayout(false);
            groupBoxAddNewWord.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelApresent;
        private Label labelWordInPortuguese;
        private GroupBox groupBoxAddNewWord;
        private TextBox textBoxWordInPortuguese;
        private TextBox textBoxOtherLanguage;
        private Label labelWordInOtherLanguage;
        private Button buttonAddNewWord;
    }
}
