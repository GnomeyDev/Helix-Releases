namespace HelixClient
{
    partial class Form1
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
            this.airjump = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Combat = new System.Windows.Forms.TabPage();
            this.Movement = new System.Windows.Forms.TabPage();
            this.Player = new System.Windows.Forms.TabPage();
            this.Visuals = new System.Windows.Forms.TabPage();
            this.Misc = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Movement.SuspendLayout();
            this.SuspendLayout();
            // 
            // airjump
            // 
            this.airjump.AccessibleName = "airjump";
            this.airjump.AutoSize = true;
            this.airjump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.airjump.ForeColor = System.Drawing.Color.Red;
            this.airjump.Location = new System.Drawing.Point(6, 6);
            this.airjump.Name = "airjump";
            this.airjump.Size = new System.Drawing.Size(63, 17);
            this.airjump.TabIndex = 0;
            this.airjump.Text = "AirJump";
            this.airjump.UseVisualStyleBackColor = false;
            this.airjump.CheckedChanged += new System.EventHandler(this.airjump_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Combat);
            this.tabControl1.Controls.Add(this.Movement);
            this.tabControl1.Controls.Add(this.Player);
            this.tabControl1.Controls.Add(this.Visuals);
            this.tabControl1.Controls.Add(this.Misc);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 327);
            this.tabControl1.TabIndex = 1;
            // 
            // Combat
            // 
            this.Combat.AccessibleName = "Combat";
            this.Combat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Combat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Combat.Location = new System.Drawing.Point(4, 22);
            this.Combat.Name = "Combat";
            this.Combat.Padding = new System.Windows.Forms.Padding(3);
            this.Combat.Size = new System.Drawing.Size(445, 301);
            this.Combat.TabIndex = 0;
            this.Combat.Text = "Combat";
            // 
            // Movement
            // 
            this.Movement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Movement.Controls.Add(this.airjump);
            this.Movement.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Movement.Location = new System.Drawing.Point(4, 22);
            this.Movement.Name = "Movement";
            this.Movement.Padding = new System.Windows.Forms.Padding(3);
            this.Movement.Size = new System.Drawing.Size(445, 301);
            this.Movement.TabIndex = 1;
            this.Movement.Text = "Movement";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Player.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Player.Location = new System.Drawing.Point(4, 22);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(445, 301);
            this.Player.TabIndex = 2;
            this.Player.Text = "Player";
            // 
            // Visuals
            // 
            this.Visuals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Visuals.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Visuals.Location = new System.Drawing.Point(4, 22);
            this.Visuals.Name = "Visuals";
            this.Visuals.Size = new System.Drawing.Size(445, 301);
            this.Visuals.TabIndex = 3;
            this.Visuals.Text = "Visuals";
            // 
            // Misc
            // 
            this.Misc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Misc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Misc.Location = new System.Drawing.Point(4, 22);
            this.Misc.Name = "Misc";
            this.Misc.Size = new System.Drawing.Size(445, 301);
            this.Misc.TabIndex = 4;
            this.Misc.Text = "Misc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(477, 351);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HelixClient";
            this.tabControl1.ResumeLayout(false);
            this.Movement.ResumeLayout(false);
            this.Movement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox airjump;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Combat;
        private System.Windows.Forms.TabPage Movement;
        private System.Windows.Forms.TabPage Player;
        private System.Windows.Forms.TabPage Visuals;
        private System.Windows.Forms.TabPage Misc;
    }
}

