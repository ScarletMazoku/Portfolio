namespace DIPLOM
{
    partial class BALDA
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
            this.components = new System.ComponentModel.Container();
            this.Cell4x4 = new System.Windows.Forms.TextBox();
            this.Cell0x0 = new System.Windows.Forms.TextBox();
            this.Cell0x1 = new System.Windows.Forms.TextBox();
            this.Cell0x3 = new System.Windows.Forms.TextBox();
            this.Cell0x2 = new System.Windows.Forms.TextBox();
            this.Cell0x4 = new System.Windows.Forms.TextBox();
            this.Cell1x4 = new System.Windows.Forms.TextBox();
            this.Cell1x3 = new System.Windows.Forms.TextBox();
            this.Cell1x2 = new System.Windows.Forms.TextBox();
            this.Cell1x1 = new System.Windows.Forms.TextBox();
            this.Cell1x0 = new System.Windows.Forms.TextBox();
            this.Cell3x4 = new System.Windows.Forms.TextBox();
            this.Cell3x3 = new System.Windows.Forms.TextBox();
            this.Cell3x2 = new System.Windows.Forms.TextBox();
            this.Cell3x1 = new System.Windows.Forms.TextBox();
            this.Cell3x0 = new System.Windows.Forms.TextBox();
            this.Cell2x4 = new System.Windows.Forms.TextBox();
            this.Cell2x3 = new System.Windows.Forms.TextBox();
            this.Cell2x2 = new System.Windows.Forms.TextBox();
            this.Cell2x1 = new System.Windows.Forms.TextBox();
            this.Cell2x0 = new System.Windows.Forms.TextBox();
            this.Cell4x3 = new System.Windows.Forms.TextBox();
            this.Cell4x2 = new System.Windows.Forms.TextBox();
            this.Cell4x1 = new System.Windows.Forms.TextBox();
            this.Cell4x0 = new System.Windows.Forms.TextBox();
            this.Word_verification_textbox = new System.Windows.Forms.TextBox();
            this.Word_verification_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Surrend_button = new System.Windows.Forms.Button();
            this.Hint_button = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.Player1_label = new System.Windows.Forms.Label();
            this.Score_label = new System.Windows.Forms.Label();
            this.Player2_label = new System.Windows.Forms.Label();
            this.PlayerTurn_label = new System.Windows.Forms.Label();
            this.Find_word = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Cell4x4
            // 
            this.Cell4x4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell4x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell4x4.Location = new System.Drawing.Point(234, 190);
            this.Cell4x4.MaxLength = 1;
            this.Cell4x4.Name = "Cell4x4";
            this.Cell4x4.ReadOnly = true;
            this.Cell4x4.Size = new System.Drawing.Size(32, 32);
            this.Cell4x4.TabIndex = 24;
            this.Cell4x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell4x4.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell4x4.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell0x0
            // 
            this.Cell0x0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell0x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell0x0.Location = new System.Drawing.Point(106, 62);
            this.Cell0x0.MaxLength = 1;
            this.Cell0x0.Name = "Cell0x0";
            this.Cell0x0.ReadOnly = true;
            this.Cell0x0.Size = new System.Drawing.Size(32, 32);
            this.Cell0x0.TabIndex = 0;
            this.Cell0x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell0x0.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell0x0.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell0x1
            // 
            this.Cell0x1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell0x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell0x1.Location = new System.Drawing.Point(138, 62);
            this.Cell0x1.MaxLength = 1;
            this.Cell0x1.Name = "Cell0x1";
            this.Cell0x1.ReadOnly = true;
            this.Cell0x1.Size = new System.Drawing.Size(32, 32);
            this.Cell0x1.TabIndex = 1;
            this.Cell0x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell0x1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell0x1.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell0x3
            // 
            this.Cell0x3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell0x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell0x3.Location = new System.Drawing.Point(202, 62);
            this.Cell0x3.MaxLength = 1;
            this.Cell0x3.Name = "Cell0x3";
            this.Cell0x3.ReadOnly = true;
            this.Cell0x3.Size = new System.Drawing.Size(32, 32);
            this.Cell0x3.TabIndex = 3;
            this.Cell0x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell0x3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell0x3.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell0x2
            // 
            this.Cell0x2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell0x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell0x2.Location = new System.Drawing.Point(170, 62);
            this.Cell0x2.MaxLength = 1;
            this.Cell0x2.Name = "Cell0x2";
            this.Cell0x2.ReadOnly = true;
            this.Cell0x2.Size = new System.Drawing.Size(32, 32);
            this.Cell0x2.TabIndex = 2;
            this.Cell0x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell0x2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell0x2.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell0x4
            // 
            this.Cell0x4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell0x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell0x4.Location = new System.Drawing.Point(234, 62);
            this.Cell0x4.MaxLength = 1;
            this.Cell0x4.Name = "Cell0x4";
            this.Cell0x4.ReadOnly = true;
            this.Cell0x4.Size = new System.Drawing.Size(32, 32);
            this.Cell0x4.TabIndex = 4;
            this.Cell0x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell0x4.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell0x4.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell1x4
            // 
            this.Cell1x4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell1x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell1x4.Location = new System.Drawing.Point(234, 94);
            this.Cell1x4.MaxLength = 1;
            this.Cell1x4.Name = "Cell1x4";
            this.Cell1x4.ReadOnly = true;
            this.Cell1x4.Size = new System.Drawing.Size(32, 32);
            this.Cell1x4.TabIndex = 9;
            this.Cell1x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell1x4.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell1x4.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell1x3
            // 
            this.Cell1x3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell1x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell1x3.Location = new System.Drawing.Point(202, 94);
            this.Cell1x3.MaxLength = 1;
            this.Cell1x3.Name = "Cell1x3";
            this.Cell1x3.ReadOnly = true;
            this.Cell1x3.Size = new System.Drawing.Size(32, 32);
            this.Cell1x3.TabIndex = 8;
            this.Cell1x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell1x3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell1x3.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell1x2
            // 
            this.Cell1x2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell1x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell1x2.Location = new System.Drawing.Point(170, 94);
            this.Cell1x2.MaxLength = 1;
            this.Cell1x2.Name = "Cell1x2";
            this.Cell1x2.ReadOnly = true;
            this.Cell1x2.Size = new System.Drawing.Size(32, 32);
            this.Cell1x2.TabIndex = 7;
            this.Cell1x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell1x2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell1x2.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell1x1
            // 
            this.Cell1x1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell1x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell1x1.Location = new System.Drawing.Point(138, 94);
            this.Cell1x1.MaxLength = 1;
            this.Cell1x1.Name = "Cell1x1";
            this.Cell1x1.ReadOnly = true;
            this.Cell1x1.Size = new System.Drawing.Size(32, 32);
            this.Cell1x1.TabIndex = 6;
            this.Cell1x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell1x1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell1x1.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell1x0
            // 
            this.Cell1x0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell1x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell1x0.Location = new System.Drawing.Point(106, 94);
            this.Cell1x0.MaxLength = 1;
            this.Cell1x0.Name = "Cell1x0";
            this.Cell1x0.ReadOnly = true;
            this.Cell1x0.Size = new System.Drawing.Size(32, 32);
            this.Cell1x0.TabIndex = 5;
            this.Cell1x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell1x0.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell1x0.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell3x4
            // 
            this.Cell3x4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell3x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell3x4.Location = new System.Drawing.Point(234, 158);
            this.Cell3x4.MaxLength = 1;
            this.Cell3x4.Name = "Cell3x4";
            this.Cell3x4.ReadOnly = true;
            this.Cell3x4.Size = new System.Drawing.Size(32, 32);
            this.Cell3x4.TabIndex = 19;
            this.Cell3x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell3x4.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell3x4.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell3x3
            // 
            this.Cell3x3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell3x3.Location = new System.Drawing.Point(202, 158);
            this.Cell3x3.MaxLength = 1;
            this.Cell3x3.Name = "Cell3x3";
            this.Cell3x3.ReadOnly = true;
            this.Cell3x3.Size = new System.Drawing.Size(32, 32);
            this.Cell3x3.TabIndex = 18;
            this.Cell3x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell3x3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell3x3.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell3x2
            // 
            this.Cell3x2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell3x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell3x2.Location = new System.Drawing.Point(170, 158);
            this.Cell3x2.MaxLength = 1;
            this.Cell3x2.Name = "Cell3x2";
            this.Cell3x2.ReadOnly = true;
            this.Cell3x2.Size = new System.Drawing.Size(32, 32);
            this.Cell3x2.TabIndex = 17;
            this.Cell3x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell3x2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell3x2.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell3x1
            // 
            this.Cell3x1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell3x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell3x1.Location = new System.Drawing.Point(138, 158);
            this.Cell3x1.MaxLength = 1;
            this.Cell3x1.Name = "Cell3x1";
            this.Cell3x1.ReadOnly = true;
            this.Cell3x1.Size = new System.Drawing.Size(32, 32);
            this.Cell3x1.TabIndex = 16;
            this.Cell3x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell3x1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell3x1.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell3x0
            // 
            this.Cell3x0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell3x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell3x0.Location = new System.Drawing.Point(106, 158);
            this.Cell3x0.MaxLength = 1;
            this.Cell3x0.Name = "Cell3x0";
            this.Cell3x0.ReadOnly = true;
            this.Cell3x0.Size = new System.Drawing.Size(32, 32);
            this.Cell3x0.TabIndex = 15;
            this.Cell3x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell3x0.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell3x0.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell2x4
            // 
            this.Cell2x4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell2x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell2x4.Location = new System.Drawing.Point(234, 126);
            this.Cell2x4.MaxLength = 1;
            this.Cell2x4.Name = "Cell2x4";
            this.Cell2x4.ReadOnly = true;
            this.Cell2x4.Size = new System.Drawing.Size(32, 32);
            this.Cell2x4.TabIndex = 14;
            this.Cell2x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell2x4.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell2x3
            // 
            this.Cell2x3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell2x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell2x3.Location = new System.Drawing.Point(202, 126);
            this.Cell2x3.MaxLength = 1;
            this.Cell2x3.Name = "Cell2x3";
            this.Cell2x3.ReadOnly = true;
            this.Cell2x3.Size = new System.Drawing.Size(32, 32);
            this.Cell2x3.TabIndex = 13;
            this.Cell2x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell2x3.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell2x2
            // 
            this.Cell2x2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell2x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell2x2.Location = new System.Drawing.Point(170, 126);
            this.Cell2x2.MaxLength = 1;
            this.Cell2x2.Name = "Cell2x2";
            this.Cell2x2.ReadOnly = true;
            this.Cell2x2.Size = new System.Drawing.Size(32, 32);
            this.Cell2x2.TabIndex = 12;
            this.Cell2x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell2x2.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell2x1
            // 
            this.Cell2x1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell2x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell2x1.Location = new System.Drawing.Point(138, 126);
            this.Cell2x1.MaxLength = 1;
            this.Cell2x1.Name = "Cell2x1";
            this.Cell2x1.ReadOnly = true;
            this.Cell2x1.Size = new System.Drawing.Size(32, 32);
            this.Cell2x1.TabIndex = 11;
            this.Cell2x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell2x1.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell2x0
            // 
            this.Cell2x0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell2x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell2x0.Location = new System.Drawing.Point(106, 126);
            this.Cell2x0.MaxLength = 1;
            this.Cell2x0.Name = "Cell2x0";
            this.Cell2x0.ReadOnly = true;
            this.Cell2x0.Size = new System.Drawing.Size(32, 32);
            this.Cell2x0.TabIndex = 10;
            this.Cell2x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell2x0.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell4x3
            // 
            this.Cell4x3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell4x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell4x3.Location = new System.Drawing.Point(202, 190);
            this.Cell4x3.MaxLength = 1;
            this.Cell4x3.Name = "Cell4x3";
            this.Cell4x3.ReadOnly = true;
            this.Cell4x3.Size = new System.Drawing.Size(32, 32);
            this.Cell4x3.TabIndex = 23;
            this.Cell4x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell4x3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell4x3.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell4x2
            // 
            this.Cell4x2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell4x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell4x2.Location = new System.Drawing.Point(170, 190);
            this.Cell4x2.MaxLength = 1;
            this.Cell4x2.Name = "Cell4x2";
            this.Cell4x2.ReadOnly = true;
            this.Cell4x2.Size = new System.Drawing.Size(32, 32);
            this.Cell4x2.TabIndex = 22;
            this.Cell4x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell4x2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell4x2.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell4x1
            // 
            this.Cell4x1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell4x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell4x1.Location = new System.Drawing.Point(138, 190);
            this.Cell4x1.MaxLength = 1;
            this.Cell4x1.Name = "Cell4x1";
            this.Cell4x1.ReadOnly = true;
            this.Cell4x1.Size = new System.Drawing.Size(32, 32);
            this.Cell4x1.TabIndex = 21;
            this.Cell4x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell4x1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell4x1.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Cell4x0
            // 
            this.Cell4x0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cell4x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cell4x0.Location = new System.Drawing.Point(106, 190);
            this.Cell4x0.MaxLength = 1;
            this.Cell4x0.Name = "Cell4x0";
            this.Cell4x0.ReadOnly = true;
            this.Cell4x0.Size = new System.Drawing.Size(32, 32);
            this.Cell4x0.TabIndex = 20;
            this.Cell4x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cell4x0.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Cell4x0.Enter += new System.EventHandler(this.cell_sborka);
            // 
            // Word_verification_textbox
            // 
            this.Word_verification_textbox.Location = new System.Drawing.Point(272, 78);
            this.Word_verification_textbox.Multiline = true;
            this.Word_verification_textbox.Name = "Word_verification_textbox";
            this.Word_verification_textbox.Size = new System.Drawing.Size(92, 48);
            this.Word_verification_textbox.TabIndex = 25;
            // 
            // Word_verification_button
            // 
            this.Word_verification_button.Location = new System.Drawing.Point(272, 135);
            this.Word_verification_button.Name = "Word_verification_button";
            this.Word_verification_button.Size = new System.Drawing.Size(92, 23);
            this.Word_verification_button.TabIndex = 26;
            this.Word_verification_button.Text = "Проверить";
            this.Word_verification_button.UseVisualStyleBackColor = true;
            this.Word_verification_button.Click += new System.EventHandler(this.Word_verification_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Время:";
            // 
            // Surrend_button
            // 
            this.Surrend_button.Location = new System.Drawing.Point(272, 199);
            this.Surrend_button.Name = "Surrend_button";
            this.Surrend_button.Size = new System.Drawing.Size(92, 23);
            this.Surrend_button.TabIndex = 29;
            this.Surrend_button.Text = "Сдаться";
            this.Surrend_button.UseVisualStyleBackColor = true;
            this.Surrend_button.Click += new System.EventHandler(this.Surrend_button_Click);
            // 
            // Hint_button
            // 
            this.Hint_button.Location = new System.Drawing.Point(272, 167);
            this.Hint_button.Name = "Hint_button";
            this.Hint_button.Size = new System.Drawing.Size(92, 23);
            this.Hint_button.TabIndex = 30;
            this.Hint_button.Text = "Подсказка";
            this.Hint_button.UseVisualStyleBackColor = true;
            this.Hint_button.Click += new System.EventHandler(this.Hint_button_Click);
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(10, 81);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(90, 37);
            this.Start_button.TabIndex = 31;
            this.Start_button.Text = "Начать";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Player1_label
            // 
            this.Player1_label.AutoSize = true;
            this.Player1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1_label.Location = new System.Drawing.Point(90, 11);
            this.Player1_label.Name = "Player1_label";
            this.Player1_label.Size = new System.Drawing.Size(66, 20);
            this.Player1_label.TabIndex = 32;
            this.Player1_label.Text = "Игрок 1";
            this.Player1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_label.Location = new System.Drawing.Point(164, 11);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(31, 20);
            this.Score_label.TabIndex = 33;
            this.Score_label.Text = "0:0";
            this.Score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2_label
            // 
            this.Player2_label.AutoSize = true;
            this.Player2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2_label.Location = new System.Drawing.Point(212, 11);
            this.Player2_label.Name = "Player2_label";
            this.Player2_label.Size = new System.Drawing.Size(66, 20);
            this.Player2_label.TabIndex = 34;
            this.Player2_label.Text = "Игрок 2";
            this.Player2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerTurn_label
            // 
            this.PlayerTurn_label.AutoSize = true;
            this.PlayerTurn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTurn_label.Location = new System.Drawing.Point(132, 36);
            this.PlayerTurn_label.Name = "PlayerTurn_label";
            this.PlayerTurn_label.Size = new System.Drawing.Size(0, 20);
            this.PlayerTurn_label.TabIndex = 35;
            this.PlayerTurn_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Find_word
            // 
            this.Find_word.AutoSize = true;
            this.Find_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find_word.Location = new System.Drawing.Point(106, 232);
            this.Find_word.MaximumSize = new System.Drawing.Size(160, 20);
            this.Find_word.MinimumSize = new System.Drawing.Size(160, 20);
            this.Find_word.Name = "Find_word";
            this.Find_word.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Find_word.Size = new System.Drawing.Size(160, 20);
            this.Find_word.TabIndex = 69;
            this.Find_word.Text = "Добавьте букву";
            this.Find_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 70;
            this.button1.Text = "Удалить слово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 71;
            this.button2.Text = "Удалить букву";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BALDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 263);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Find_word);
            this.Controls.Add(this.PlayerTurn_label);
            this.Controls.Add(this.Player2_label);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.Player1_label);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Hint_button);
            this.Controls.Add(this.Surrend_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Word_verification_button);
            this.Controls.Add(this.Word_verification_textbox);
            this.Controls.Add(this.Cell4x4);
            this.Controls.Add(this.Cell4x3);
            this.Controls.Add(this.Cell4x2);
            this.Controls.Add(this.Cell4x1);
            this.Controls.Add(this.Cell4x0);
            this.Controls.Add(this.Cell3x4);
            this.Controls.Add(this.Cell3x3);
            this.Controls.Add(this.Cell3x2);
            this.Controls.Add(this.Cell3x1);
            this.Controls.Add(this.Cell3x0);
            this.Controls.Add(this.Cell2x4);
            this.Controls.Add(this.Cell2x3);
            this.Controls.Add(this.Cell2x2);
            this.Controls.Add(this.Cell2x1);
            this.Controls.Add(this.Cell2x0);
            this.Controls.Add(this.Cell1x4);
            this.Controls.Add(this.Cell1x3);
            this.Controls.Add(this.Cell1x2);
            this.Controls.Add(this.Cell1x1);
            this.Controls.Add(this.Cell1x0);
            this.Controls.Add(this.Cell0x4);
            this.Controls.Add(this.Cell0x3);
            this.Controls.Add(this.Cell0x2);
            this.Controls.Add(this.Cell0x1);
            this.Controls.Add(this.Cell0x0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BALDA";
            this.RightToLeftLayout = true;
            this.Text = "BALDA";
            this.Load += new System.EventHandler(this.BALDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cell0x0;
        private System.Windows.Forms.TextBox Cell0x1;
        private System.Windows.Forms.TextBox Cell0x3;
        private System.Windows.Forms.TextBox Cell0x2;
        private System.Windows.Forms.TextBox Cell0x4;
        private System.Windows.Forms.TextBox Cell1x4;
        private System.Windows.Forms.TextBox Cell1x3;
        private System.Windows.Forms.TextBox Cell1x2;
        private System.Windows.Forms.TextBox Cell1x1;
        private System.Windows.Forms.TextBox Cell1x0;
        private System.Windows.Forms.TextBox Cell3x4;
        private System.Windows.Forms.TextBox Cell3x3;
        private System.Windows.Forms.TextBox Cell3x2;
        private System.Windows.Forms.TextBox Cell3x1;
        private System.Windows.Forms.TextBox Cell3x0;
        private System.Windows.Forms.TextBox Cell2x4;
        private System.Windows.Forms.TextBox Cell2x3;
        private System.Windows.Forms.TextBox Cell2x2;
        private System.Windows.Forms.TextBox Cell2x1;
        private System.Windows.Forms.TextBox Cell2x0;
        private System.Windows.Forms.TextBox Cell4x3;
        private System.Windows.Forms.TextBox Cell4x2;
        private System.Windows.Forms.TextBox Cell4x1;
        private System.Windows.Forms.TextBox Cell4x0;
        private System.Windows.Forms.TextBox Word_verification_textbox;
        private System.Windows.Forms.Button Word_verification_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Surrend_button;
        private System.Windows.Forms.Button Hint_button;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label Player1_label;
        private System.Windows.Forms.Label Score_label;
        private System.Windows.Forms.Label Player2_label;
        private System.Windows.Forms.Label PlayerTurn_label;
        private System.Windows.Forms.Label Find_word;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Cell4x4;
    }
}

