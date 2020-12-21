
namespace SteamTracker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.gamesGrid = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.gamesListResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likelihoodToPlay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latestUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storePageLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gamesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesListResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRefresh.Location = new System.Drawing.Point(12, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 42);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // gamesGrid
            // 
            this.gamesGrid.AllowUserToAddRows = false;
            this.gamesGrid.AllowUserToDeleteRows = false;
            this.gamesGrid.AllowUserToResizeColumns = false;
            this.gamesGrid.AllowUserToResizeRows = false;
            this.gamesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gamesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gamesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appid,
            this.icon,
            this.name,
            this.likelihoodToPlay,
            this.notes,
            this.latestUpdated,
            this.storePageLink});
            this.gamesGrid.Location = new System.Drawing.Point(12, 86);
            this.gamesGrid.MultiSelect = false;
            this.gamesGrid.Name = "gamesGrid";
            this.gamesGrid.Size = new System.Drawing.Size(1430, 505);
            this.gamesGrid.TabIndex = 1;
            this.gamesGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gamesGrid_CellEndEdit);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(862, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 42);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Data";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(299, 57);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 60);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(281, 20);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // gamesListResponseBindingSource
            // 
            this.gamesListResponseBindingSource.DataSource = typeof(SteamTracker.dtos.GamesListResponse);
            // 
            // appid
            // 
            this.appid.DataPropertyName = "appid";
            this.appid.HeaderText = "ID";
            this.appid.Name = "appid";
            this.appid.ReadOnly = true;
            this.appid.Visible = false;
            this.appid.Width = 43;
            // 
            // icon
            // 
            this.icon.HeaderText = "Icon";
            this.icon.Name = "icon";
            this.icon.ReadOnly = true;
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.icon.Width = 53;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 60;
            // 
            // likelihoodToPlay
            // 
            this.likelihoodToPlay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.likelihoodToPlay.DataPropertyName = "likelihoodToPlay";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N1";
            this.likelihoodToPlay.DefaultCellStyle = dataGridViewCellStyle1;
            this.likelihoodToPlay.HeaderText = "Likelihood to play";
            this.likelihoodToPlay.MaxInputLength = 3;
            this.likelihoodToPlay.MinimumWidth = 150;
            this.likelihoodToPlay.Name = "likelihoodToPlay";
            this.likelihoodToPlay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.likelihoodToPlay.Width = 150;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "Notes";
            this.notes.MinimumWidth = 350;
            this.notes.Name = "notes";
            this.notes.Width = 350;
            // 
            // latestUpdated
            // 
            this.latestUpdated.DataPropertyName = "latestUpdated";
            this.latestUpdated.HeaderText = "Latest updated";
            this.latestUpdated.MinimumWidth = 150;
            this.latestUpdated.Name = "latestUpdated";
            this.latestUpdated.ReadOnly = true;
            this.latestUpdated.Width = 150;
            // 
            // storePageLink
            // 
            this.storePageLink.DataPropertyName = "storePageLink";
            this.storePageLink.HeaderText = "Store page link";
            this.storePageLink.MinimumWidth = 200;
            this.storePageLink.Name = "storePageLink";
            this.storePageLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storePageLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.storePageLink.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1454, 603);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.gamesGrid);
            this.Controls.Add(this.buttonRefresh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesListResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView gamesGrid;
        private System.Windows.Forms.BindingSource gamesListResponseBindingSource;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn appid;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn likelihoodToPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn latestUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn storePageLink;
    }
}

