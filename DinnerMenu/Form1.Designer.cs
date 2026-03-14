namespace DinnerMenu
{
    partial class DinerSpecialMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SoupButton = new Button();
            SaladButton = new Button();
            FishButton = new Button();
            ExitButton = new Button();
            DinerNameLabel = new Label();
            ButtonsGroupBox = new GroupBox();
            DisplaySpecialLabel = new Label();
            DisplayDinnerLabel = new Label();
            ButtonsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(0, 9);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(144, 76);
            SoupButton.TabIndex = 1;
            SoupButton.Text = "Soup";
            SoupButton.UseVisualStyleBackColor = true;
            SoupButton.Click += SoupButton_Click;
            // 
            // SaladButton
            // 
            SaladButton.Location = new Point(150, 9);
            SaladButton.Name = "SaladButton";
            SaladButton.Size = new Size(144, 76);
            SaladButton.TabIndex = 2;
            SaladButton.Text = "Salad";
            SaladButton.UseVisualStyleBackColor = true;
            SaladButton.Click += SaladButton_Click;
            // 
            // FishButton
            // 
            FishButton.Location = new Point(300, 11);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(144, 76);
            FishButton.TabIndex = 3;
            FishButton.Text = "Fish";
            FishButton.UseVisualStyleBackColor = true;
            FishButton.Click += FishButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(632, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(144, 76);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DinerNameLabel
            // 
            DinerNameLabel.AutoSize = true;
            DinerNameLabel.Font = new Font("Gabriola", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DinerNameLabel.Location = new Point(251, 9);
            DinerNameLabel.Name = "DinerNameLabel";
            DinerNameLabel.Size = new Size(301, 96);
            DinerNameLabel.TabIndex = 4;
            DinerNameLabel.Text = "~Surf The Turf~";
            DinerNameLabel.Click += DinerLabel_Click;
            // 
            // ButtonsGroupBox
            // 
            ButtonsGroupBox.Controls.Add(ExitButton);
            ButtonsGroupBox.Controls.Add(FishButton);
            ButtonsGroupBox.Controls.Add(SaladButton);
            ButtonsGroupBox.Controls.Add(SoupButton);
            ButtonsGroupBox.Location = new Point(12, 357);
            ButtonsGroupBox.Name = "ButtonsGroupBox";
            ButtonsGroupBox.Size = new Size(783, 89);
            ButtonsGroupBox.TabIndex = 0;
            ButtonsGroupBox.TabStop = false;
            // 
            // DisplaySpecialLabel
            // 
            DisplaySpecialLabel.AutoSize = true;
            DisplaySpecialLabel.Font = new Font("Gabriola", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplaySpecialLabel.Location = new Point(268, 85);
            DisplaySpecialLabel.Name = "DisplaySpecialLabel";
            DisplaySpecialLabel.Size = new Size(0, 51);
            DisplaySpecialLabel.TabIndex = 0;
            // 
            // DisplayDinnerLabel
            // 
            DisplayDinnerLabel.AutoSize = true;
            DisplayDinnerLabel.Font = new Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayDinnerLabel.Location = new Point(154, 131);
            DisplayDinnerLabel.Name = "DisplayDinnerLabel";
            DisplayDinnerLabel.Size = new Size(0, 45);
            DisplayDinnerLabel.TabIndex = 5;
            // 
            // DinerSpecialMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayDinnerLabel);
            Controls.Add(DisplaySpecialLabel);
            Controls.Add(ButtonsGroupBox);
            Controls.Add(DinerNameLabel);
            Name = "DinerSpecialMenu";
            Text = "Surf The Turf Diner Special Menu";
            Load += DinerSpecialMenu_Load;
            ButtonsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SoupButton;
        private Button SaladButton;
        private Button FishButton;
        private Button ExitButton;
        private Label DinerNameLabel;
        private GroupBox ButtonsGroupBox;
        private Label DisplaySpecialLabel;
        private Label DisplayDinnerLabel;
    }
}
