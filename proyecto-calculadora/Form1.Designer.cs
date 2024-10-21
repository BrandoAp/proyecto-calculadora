namespace proyecto_calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.treeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.ceroButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exponentButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.viewHistorial = new System.Windows.Forms.Button();
            this.expressionTxt = new System.Windows.Forms.TextBox();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.listViewHistorial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oneButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(12, 69);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(105, 51);
            this.oneButton.TabIndex = 1;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.addNum);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.twoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(123, 69);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(104, 51);
            this.twoButton.TabIndex = 2;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.addNum);
            // 
            // treeButton
            // 
            this.treeButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeButton.Location = new System.Drawing.Point(233, 69);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(104, 51);
            this.treeButton.TabIndex = 3;
            this.treeButton.Text = "3";
            this.treeButton.UseVisualStyleBackColor = false;
            this.treeButton.Click += new System.EventHandler(this.addNum);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fourButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(12, 126);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(106, 51);
            this.fourButton.TabIndex = 4;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.addNum);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fiveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(123, 126);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(104, 51);
            this.fiveButton.TabIndex = 5;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.addNum);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sixButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(233, 126);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(104, 51);
            this.sixButton.TabIndex = 6;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.addNum);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sevenButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(12, 183);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(106, 51);
            this.sevenButton.TabIndex = 7;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.addNum);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eightButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(123, 183);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(104, 51);
            this.eightButton.TabIndex = 8;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.addNum);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nineButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(233, 183);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(104, 51);
            this.nineButton.TabIndex = 9;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.addNum);
            // 
            // ceroButton
            // 
            this.ceroButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ceroButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceroButton.Location = new System.Drawing.Point(123, 240);
            this.ceroButton.Name = "ceroButton";
            this.ceroButton.Size = new System.Drawing.Size(104, 51);
            this.ceroButton.TabIndex = 10;
            this.ceroButton.Text = "0";
            this.ceroButton.UseVisualStyleBackColor = false;
            this.ceroButton.Click += new System.EventHandler(this.addNum);
            // 
            // sumButton
            // 
            this.sumButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sumButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.Location = new System.Drawing.Point(343, 69);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(104, 51);
            this.sumButton.TabIndex = 11;
            this.sumButton.Tag = "+";
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = false;
            this.sumButton.Click += new System.EventHandler(this.clickOp);
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.Location = new System.Drawing.Point(343, 126);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(104, 51);
            this.minButton.TabIndex = 12;
            this.minButton.Tag = "-";
            this.minButton.Text = "-";
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.clickOp);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.plusButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(343, 183);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(104, 51);
            this.plusButton.TabIndex = 13;
            this.plusButton.Tag = "x";
            this.plusButton.Text = "x";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.clickOp);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.divButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divButton.Location = new System.Drawing.Point(343, 240);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(104, 51);
            this.divButton.TabIndex = 14;
            this.divButton.Tag = "/";
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.clickOp);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clearButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(12, 240);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 51);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exponentButton
            // 
            this.exponentButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.exponentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponentButton.Location = new System.Drawing.Point(233, 240);
            this.exponentButton.Name = "exponentButton";
            this.exponentButton.Size = new System.Drawing.Size(104, 51);
            this.exponentButton.TabIndex = 16;
            this.exponentButton.Tag = "²";
            this.exponentButton.Text = "x²";
            this.exponentButton.UseVisualStyleBackColor = false;
            this.exponentButton.Click += new System.EventHandler(this.clickOp);
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.equalsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(12, 297);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(325, 39);
            this.equalsButton.TabIndex = 17;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sqrtButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtButton.ForeColor = System.Drawing.Color.Black;
            this.sqrtButton.Location = new System.Drawing.Point(343, 297);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(104, 38);
            this.sqrtButton.TabIndex = 19;
            this.sqrtButton.Tag = "√";
            this.sqrtButton.Text = "√ ";
            this.sqrtButton.UseVisualStyleBackColor = false;
            this.sqrtButton.Click += new System.EventHandler(this.clickOp);
            // 
            // viewHistorial
            // 
            this.viewHistorial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.viewHistorial.Location = new System.Drawing.Point(453, 12);
            this.viewHistorial.Name = "viewHistorial";
            this.viewHistorial.Size = new System.Drawing.Size(373, 49);
            this.viewHistorial.TabIndex = 22;
            this.viewHistorial.Text = "Historial de Operaciones";
            this.viewHistorial.UseVisualStyleBackColor = false;
            this.viewHistorial.Click += new System.EventHandler(this.viewHistorial_Click);
            // 
            // expressionTxt
            // 
            this.expressionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionTxt.Location = new System.Drawing.Point(12, 12);
            this.expressionTxt.MaxLength = 19;
            this.expressionTxt.Multiline = true;
            this.expressionTxt.Name = "expressionTxt";
            this.expressionTxt.ReadOnly = true;
            this.expressionTxt.Size = new System.Drawing.Size(325, 49);
            this.expressionTxt.TabIndex = 24;
            this.expressionTxt.Text = "0";
            this.expressionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultTxt
            // 
            this.resultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxt.Location = new System.Drawing.Point(343, 12);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.Size = new System.Drawing.Size(104, 49);
            this.resultTxt.TabIndex = 25;
            this.resultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listViewHistorial
            // 
            this.listViewHistorial.FormattingEnabled = true;
            this.listViewHistorial.Location = new System.Drawing.Point(454, 69);
            this.listViewHistorial.Name = "listViewHistorial";
            this.listViewHistorial.Size = new System.Drawing.Size(372, 264);
            this.listViewHistorial.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 346);
            this.Controls.Add(this.listViewHistorial);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.expressionTxt);
            this.Controls.Add(this.viewHistorial);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.exponentButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.ceroButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.treeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button treeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button ceroButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exponentButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button viewHistorial;
        private System.Windows.Forms.TextBox expressionTxt;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.ListBox listViewHistorial;
    }
}

