namespace Order_Management_System
{
    partial class Form_Order
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
            label1 = new Label();
            btn_Exit = new Button();
            btn_Order = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 24);
            label1.Name = "label1";
            label1.Size = new Size(737, 116);
            label1.TabIndex = 0;
            label1.Text = "Order Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.OrangeRed;
            btn_Exit.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(229, 198);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(166, 91);
            btn_Exit.TabIndex = 1;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Order
            // 
            btn_Order.BackColor = Color.OrangeRed;
            btn_Order.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Order.Location = new Point(433, 198);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(176, 91);
            btn_Order.TabIndex = 2;
            btn_Order.Text = "ORDER";
            btn_Order.UseVisualStyleBackColor = false;
            btn_Order.Click += btn_Order_Click;
            // 
            // Form_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Order);
            Controls.Add(btn_Exit);
            Controls.Add(label1);
            Name = "Form_Order";
            Text = "OrderForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_Exit;
        private Button btn_Order;
    }
}
