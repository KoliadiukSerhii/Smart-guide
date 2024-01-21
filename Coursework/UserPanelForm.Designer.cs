namespace Coursework
{
    partial class UserPanelForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableTitleLabel = new System.Windows.Forms.Label();
            this.establishmentsButton = new System.Windows.Forms.Button();
            this.poiButton = new System.Windows.Forms.Button();
            this.locationsButton = new System.Windows.Forms.Button();
            this.reviewsButton = new System.Windows.Forms.Button();
            this.routesButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            this.hideInfoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Coursework.Properties.Resources.MainPageBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.hideInfoButton);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.tableTitleLabel);
            this.panel1.Controls.Add(this.establishmentsButton);
            this.panel1.Controls.Add(this.poiButton);
            this.panel1.Controls.Add(this.locationsButton);
            this.panel1.Controls.Add(this.reviewsButton);
            this.panel1.Controls.Add(this.routesButton);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 603);
            this.panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(38, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(711, 44);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Press the button to see available information";
            // 
            // tableTitleLabel
            // 
            this.tableTitleLabel.AutoSize = true;
            this.tableTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableTitleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTitleLabel.Location = new System.Drawing.Point(450, 18);
            this.tableTitleLabel.Name = "tableTitleLabel";
            this.tableTitleLabel.Size = new System.Drawing.Size(0, 44);
            this.tableTitleLabel.TabIndex = 7;
            this.tableTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // establishmentsButton
            // 
            this.establishmentsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.establishmentsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.establishmentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.establishmentsButton.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.establishmentsButton.Location = new System.Drawing.Point(381, 463);
            this.establishmentsButton.Name = "establishmentsButton";
            this.establishmentsButton.Size = new System.Drawing.Size(215, 50);
            this.establishmentsButton.TabIndex = 6;
            this.establishmentsButton.Text = "Establishments";
            this.establishmentsButton.UseVisualStyleBackColor = false;
            this.establishmentsButton.Click += new System.EventHandler(this.establishmentsButton_Click);
            // 
            // poiButton
            // 
            this.poiButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.poiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poiButton.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poiButton.Location = new System.Drawing.Point(206, 531);
            this.poiButton.Name = "poiButton";
            this.poiButton.Size = new System.Drawing.Size(165, 50);
            this.poiButton.TabIndex = 5;
            this.poiButton.Text = "Attractions";
            this.poiButton.UseVisualStyleBackColor = false;
            this.poiButton.Click += new System.EventHandler(this.poiButton_Click);
            // 
            // locationsButton
            // 
            this.locationsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.locationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.locationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationsButton.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationsButton.Location = new System.Drawing.Point(206, 463);
            this.locationsButton.Name = "locationsButton";
            this.locationsButton.Size = new System.Drawing.Size(165, 50);
            this.locationsButton.TabIndex = 4;
            this.locationsButton.Text = "Locations";
            this.locationsButton.UseVisualStyleBackColor = false;
            this.locationsButton.Click += new System.EventHandler(this.locationsButton_Click);
            // 
            // reviewsButton
            // 
            this.reviewsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reviewsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reviewsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reviewsButton.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewsButton.Location = new System.Drawing.Point(46, 531);
            this.reviewsButton.Name = "reviewsButton";
            this.reviewsButton.Size = new System.Drawing.Size(150, 50);
            this.reviewsButton.TabIndex = 3;
            this.reviewsButton.Text = "Reviews";
            this.reviewsButton.UseVisualStyleBackColor = false;
            this.reviewsButton.Click += new System.EventHandler(this.reviewsButton_Click);
            // 
            // routesButton
            // 
            this.routesButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.routesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.routesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.routesButton.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routesButton.Location = new System.Drawing.Point(46, 463);
            this.routesButton.Name = "routesButton";
            this.routesButton.Size = new System.Drawing.Size(150, 50);
            this.routesButton.TabIndex = 2;
            this.routesButton.Text = "Routes";
            this.routesButton.UseVisualStyleBackColor = false;
            this.routesButton.Click += new System.EventHandler(this.routesButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(46, 80);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(780, 360);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.Visible = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(732, 553);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(150, 50);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // hideInfoButton
            // 
            this.hideInfoButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hideInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideInfoButton.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideInfoButton.Location = new System.Drawing.Point(381, 531);
            this.hideInfoButton.Name = "hideInfoButton";
            this.hideInfoButton.Size = new System.Drawing.Size(215, 50);
            this.hideInfoButton.TabIndex = 9;
            this.hideInfoButton.Text = "Hide Info";
            this.hideInfoButton.UseVisualStyleBackColor = false;
            this.hideInfoButton.Click += new System.EventHandler(this.hideInfoButton_Click);
            // 
            // UserPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.panel1);
            this.Name = "UserPanelForm";
            this.Text = "UserPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button establishmentsButton;
        private System.Windows.Forms.Button poiButton;
        private System.Windows.Forms.Button locationsButton;
        private System.Windows.Forms.Button reviewsButton;
        private System.Windows.Forms.Button routesButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label tableTitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button hideInfoButton;
    }
}