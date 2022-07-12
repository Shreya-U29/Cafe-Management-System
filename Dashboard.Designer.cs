namespace CaFe
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exitbutton = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.logoutbutton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.removebutton = new Guna.UI2.WinForms.Guna2Button();
            this.updatebutton = new Guna.UI2.WinForms.Guna2Button();
            this.additembutton = new Guna.UI2.WinForms.Guna2Button();
            this.placeorderbutton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Update1 = new CaFe.AllUserControls.UC_Update();
            this.uC_Remove1 = new CaFe.AllUserControls.UC_Remove();
            this.uC_Place1 = new CaFe.AllUserControls.UC_Place();
            this.uC_Add1 = new CaFe.AllUserControls.UC_Add();
            this.uC_Welcome1 = new CaFe.AllUserControls.UC_Welcome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.Exitbutton);
            this.panel1.Controls.Add(this.logoutbutton);
            this.panel1.Controls.Add(this.removebutton);
            this.panel1.Controls.Add(this.updatebutton);
            this.panel1.Controls.Add(this.additembutton);
            this.panel1.Controls.Add(this.placeorderbutton);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(15, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 769);
            this.panel1.TabIndex = 0;
            // 
            // Exitbutton
            // 
            this.guna2Transition1.SetDecoration(this.Exitbutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Exitbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exitbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exitbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exitbutton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exitbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exitbutton.FillColor = System.Drawing.Color.Black;
            this.Exitbutton.FillColor2 = System.Drawing.Color.Aqua;
            this.Exitbutton.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Location = new System.Drawing.Point(5, 9);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exitbutton.Size = new System.Drawing.Size(58, 54);
            this.Exitbutton.TabIndex = 5;
            this.Exitbutton.Text = "X";
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.AutoRoundedCorners = true;
            this.logoutbutton.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.logoutbutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logoutbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbutton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutbutton.FillColor = System.Drawing.Color.Black;
            this.logoutbutton.FillColor2 = System.Drawing.Color.Cyan;
            this.logoutbutton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.logoutbutton.ForeColor = System.Drawing.Color.White;
            this.logoutbutton.Location = new System.Drawing.Point(79, 695);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(138, 45);
            this.logoutbutton.TabIndex = 4;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // removebutton
            // 
            this.removebutton.AutoRoundedCorners = true;
            this.removebutton.BorderRadius = 27;
            this.guna2Transition1.SetDecoration(this.removebutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.removebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removebutton.FillColor = System.Drawing.Color.PeachPuff;
            this.removebutton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.removebutton.ForeColor = System.Drawing.Color.Black;
            this.removebutton.Location = new System.Drawing.Point(-30, 427);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(281, 56);
            this.removebutton.TabIndex = 3;
            this.removebutton.Text = "Remove Items";
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.AutoRoundedCorners = true;
            this.updatebutton.BorderRadius = 27;
            this.guna2Transition1.SetDecoration(this.updatebutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updatebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updatebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updatebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updatebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updatebutton.FillColor = System.Drawing.Color.PeachPuff;
            this.updatebutton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.updatebutton.ForeColor = System.Drawing.Color.Black;
            this.updatebutton.Location = new System.Drawing.Point(-30, 353);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(281, 56);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "Update Items";
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // additembutton
            // 
            this.additembutton.AutoRoundedCorners = true;
            this.additembutton.BorderRadius = 27;
            this.guna2Transition1.SetDecoration(this.additembutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.additembutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.additembutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.additembutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.additembutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.additembutton.FillColor = System.Drawing.Color.PeachPuff;
            this.additembutton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.additembutton.ForeColor = System.Drawing.Color.Black;
            this.additembutton.Location = new System.Drawing.Point(-30, 275);
            this.additembutton.Name = "additembutton";
            this.additembutton.Size = new System.Drawing.Size(281, 56);
            this.additembutton.TabIndex = 1;
            this.additembutton.Text = "Add Items";
            this.additembutton.Click += new System.EventHandler(this.additembutton_Click);
            // 
            // placeorderbutton
            // 
            this.placeorderbutton.AutoRoundedCorners = true;
            this.placeorderbutton.BorderRadius = 27;
            this.guna2Transition1.SetDecoration(this.placeorderbutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.placeorderbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.placeorderbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.placeorderbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.placeorderbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.placeorderbutton.FillColor = System.Drawing.Color.PeachPuff;
            this.placeorderbutton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorderbutton.ForeColor = System.Drawing.Color.Black;
            this.placeorderbutton.Location = new System.Drawing.Point(-30, 198);
            this.placeorderbutton.Name = "placeorderbutton";
            this.placeorderbutton.Size = new System.Drawing.Size(281, 56);
            this.placeorderbutton.TabIndex = 0;
            this.placeorderbutton.Text = "Place Order";
            this.placeorderbutton.Click += new System.EventHandler(this.placeorderbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Update1);
            this.panel2.Controls.Add(this.uC_Remove1);
            this.panel2.Controls.Add(this.uC_Place1);
            this.panel2.Controls.Add(this.uC_Add1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(318, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 768);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // uC_Update1
            // 
            this.uC_Update1.BackColor = System.Drawing.Color.FloralWhite;
            this.guna2Transition1.SetDecoration(this.uC_Update1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Update1.Location = new System.Drawing.Point(0, 3);
            this.uC_Update1.Name = "uC_Update1";
            this.uC_Update1.Size = new System.Drawing.Size(943, 768);
            this.uC_Update1.TabIndex = 4;
            // 
            // uC_Remove1
            // 
            this.uC_Remove1.BackColor = System.Drawing.Color.FloralWhite;
            this.guna2Transition1.SetDecoration(this.uC_Remove1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Remove1.Location = new System.Drawing.Point(-3, 0);
            this.uC_Remove1.Name = "uC_Remove1";
            this.uC_Remove1.Size = new System.Drawing.Size(943, 768);
            this.uC_Remove1.TabIndex = 3;
            // 
            // uC_Place1
            // 
            this.uC_Place1.BackColor = System.Drawing.Color.LavenderBlush;
            this.guna2Transition1.SetDecoration(this.uC_Place1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Place1.Location = new System.Drawing.Point(0, 0);
            this.uC_Place1.Name = "uC_Place1";
            this.uC_Place1.Size = new System.Drawing.Size(943, 768);
            this.uC_Place1.TabIndex = 2;
            // 
            // uC_Add1
            // 
            this.uC_Add1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Transition1.SetDecoration(this.uC_Add1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Add1.Location = new System.Drawing.Point(-3, 1);
            this.uC_Add1.Name = "uC_Add1";
            this.uC_Add1.Size = new System.Drawing.Size(943, 768);
            this.uC_Add1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(0, 1);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(943, 768);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1285, 802);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button placeorderbutton;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton Exitbutton;
        private Guna.UI2.WinForms.Guna2GradientButton logoutbutton;
        private Guna.UI2.WinForms.Guna2Button removebutton;
        private Guna.UI2.WinForms.Guna2Button updatebutton;
        private Guna.UI2.WinForms.Guna2Button additembutton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserControls.UC_Add uC_Add1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_Place uC_Place1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_Remove uC_Remove1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.UC_Update uC_Update1;
    }
}