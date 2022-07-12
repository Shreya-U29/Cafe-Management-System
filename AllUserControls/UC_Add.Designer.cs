namespace CaFe.AllUserControls
{
    partial class UC_Add
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categorybox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.itemnamebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pricebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addbutton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // categorybox
            // 
            this.categorybox.BackColor = System.Drawing.Color.Transparent;
            this.categorybox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categorybox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorybox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorybox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorybox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybox.ForeColor = System.Drawing.Color.Black;
            this.categorybox.ItemHeight = 30;
            this.categorybox.Items.AddRange(new object[] {
            "Coffee",
            "Teas",
            "Drinks",
            "Pastries",
            "HotDogs",
            "Soups & Salads"});
            this.categorybox.Location = new System.Drawing.Point(280, 221);
            this.categorybox.Name = "categorybox";
            this.categorybox.Size = new System.Drawing.Size(378, 36);
            this.categorybox.TabIndex = 4;
            // 
            // itemnamebox
            // 
            this.itemnamebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemnamebox.DefaultText = "";
            this.itemnamebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemnamebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemnamebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemnamebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemnamebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemnamebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnamebox.ForeColor = System.Drawing.Color.Black;
            this.itemnamebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemnamebox.Location = new System.Drawing.Point(280, 366);
            this.itemnamebox.Name = "itemnamebox";
            this.itemnamebox.PasswordChar = '\0';
            this.itemnamebox.PlaceholderText = "";
            this.itemnamebox.SelectedText = "";
            this.itemnamebox.Size = new System.Drawing.Size(378, 42);
            this.itemnamebox.TabIndex = 5;
            this.itemnamebox.Leave += new System.EventHandler(this.itemnamebox_Leave);
            // 
            // pricebox
            // 
            this.pricebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pricebox.DefaultText = "";
            this.pricebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pricebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pricebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebox.ForeColor = System.Drawing.Color.Black;
            this.pricebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricebox.Location = new System.Drawing.Point(280, 514);
            this.pricebox.Name = "pricebox";
            this.pricebox.PasswordChar = '\0';
            this.pricebox.PlaceholderText = "";
            this.pricebox.SelectedText = "";
            this.pricebox.Size = new System.Drawing.Size(378, 42);
            this.pricebox.TabIndex = 6;
            // 
            // addbutton
            // 
            this.addbutton.AutoRoundedCorners = true;
            this.addbutton.BorderRadius = 28;
            this.addbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbutton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addbutton.FillColor2 = System.Drawing.Color.Black;
            this.addbutton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(373, 611);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(190, 58);
            this.addbutton.TabIndex = 7;
            this.addbutton.Text = "Add";
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.SaddleBrown;
            this.guna2Shapes1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Location = new System.Drawing.Point(-79, -62);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(1098, 892);
            this.guna2Shapes1.TabIndex = 8;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.itemnamebox);
            this.Controls.Add(this.categorybox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "UC_Add";
            this.Size = new System.Drawing.Size(943, 768);
            this.Leave += new System.EventHandler(this.UC_Add_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox categorybox;
        private Guna.UI2.WinForms.Guna2TextBox itemnamebox;
        private Guna.UI2.WinForms.Guna2TextBox pricebox;
        private Guna.UI2.WinForms.Guna2GradientButton addbutton;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
