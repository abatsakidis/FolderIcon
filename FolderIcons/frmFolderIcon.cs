using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace FolderIcons
{
	/// <summary>
	/// Summary description for frmFolderIcon.
	/// </summary>
	public class frmFolderIcon : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox grpMain;
		private System.Windows.Forms.TextBox txtIconPath;
		private System.Windows.Forms.Button btnBrowseIcon;
		private System.Windows.Forms.Button btnBrowseFolder;
		private System.Windows.Forms.TextBox txtFolderPath;
		private System.Windows.Forms.Button btnCreateIcon;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
		private System.Windows.Forms.OpenFileDialog FileBrowser;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblIconPath;
        private System.Windows.Forms.Label lblInfoTip;
        private System.Windows.Forms.TextBox txtInfoTip;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmFolderIcon()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolderIcon));
            this.btnClose = new System.Windows.Forms.Button();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblInfoTip = new System.Windows.Forms.Label();
            this.txtInfoTip = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblIconPath = new System.Windows.Forms.Label();
            this.txtIconPath = new System.Windows.Forms.TextBox();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnCreateIcon = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(365, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.lblInfoTip);
            this.grpMain.Controls.Add(this.txtInfoTip);
            this.grpMain.Controls.Add(this.lblFolder);
            this.grpMain.Controls.Add(this.lblIconPath);
            this.grpMain.Controls.Add(this.txtIconPath);
            this.grpMain.Controls.Add(this.btnBrowseIcon);
            this.grpMain.Controls.Add(this.btnBrowseFolder);
            this.grpMain.Controls.Add(this.txtFolderPath);
            this.grpMain.Location = new System.Drawing.Point(10, 14);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(480, 175);
            this.grpMain.TabIndex = 7;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Folder and icon paths";
            // 
            // lblInfoTip
            // 
            this.lblInfoTip.Location = new System.Drawing.Point(17, 115);
            this.lblInfoTip.Name = "lblInfoTip";
            this.lblInfoTip.Size = new System.Drawing.Size(187, 17);
            this.lblInfoTip.TabIndex = 13;
            this.lblInfoTip.Text = "Folder Description:";
            // 
            // txtInfoTip
            // 
            this.txtInfoTip.Location = new System.Drawing.Point(17, 134);
            this.txtInfoTip.Name = "txtInfoTip";
            this.txtInfoTip.Size = new System.Drawing.Size(317, 22);
            this.txtInfoTip.TabIndex = 12;
            // 
            // lblFolder
            // 
            this.lblFolder.Location = new System.Drawing.Point(17, 23);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(187, 16);
            this.lblFolder.TabIndex = 11;
            this.lblFolder.Text = "Folder path:";
            // 
            // lblIconPath
            // 
            this.lblIconPath.Location = new System.Drawing.Point(17, 69);
            this.lblIconPath.Name = "lblIconPath";
            this.lblIconPath.Size = new System.Drawing.Size(187, 16);
            this.lblIconPath.TabIndex = 10;
            this.lblIconPath.Text = "Icon path:";
            // 
            // txtIconPath
            // 
            this.txtIconPath.Location = new System.Drawing.Point(17, 88);
            this.txtIconPath.Name = "txtIconPath";
            this.txtIconPath.Size = new System.Drawing.Size(317, 22);
            this.txtIconPath.TabIndex = 9;
            // 
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowseIcon.Location = new System.Drawing.Point(343, 85);
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.Size = new System.Drawing.Size(123, 28);
            this.btnBrowseIcon.TabIndex = 8;
            this.btnBrowseIcon.Text = "Browse Icon...";
            this.btnBrowseIcon.Click += new System.EventHandler(this.btnBrowseIcon_Click);
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowseFolder.Location = new System.Drawing.Point(343, 39);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(123, 27);
            this.btnBrowseFolder.TabIndex = 7;
            this.btnBrowseFolder.Text = "Browse Folder...";
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(17, 42);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(317, 22);
            this.txtFolderPath.TabIndex = 6;
            // 
            // btnCreateIcon
            // 
            this.btnCreateIcon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateIcon.Location = new System.Drawing.Point(233, 205);
            this.btnCreateIcon.Name = "btnCreateIcon";
            this.btnCreateIcon.Size = new System.Drawing.Size(122, 28);
            this.btnCreateIcon.TabIndex = 8;
            this.btnCreateIcon.Text = "Create Icon";
            this.btnCreateIcon.Click += new System.EventHandler(this.btnCreateIcon_Click);
            // 
            // frmFolderIcon
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(502, 255);
            this.Controls.Add(this.btnCreateIcon);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolderIcon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Folder Icon";
            this.Load += new System.EventHandler(this.frmFolderIcon_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmFolderIcon());
		}

		private void frmFolderIcon_Load(object sender, System.EventArgs e)
		{
			txtFolderPath.Text = Application.StartupPath;
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnBrowseFolder_Click(object sender, System.EventArgs e)
		{
			
			FolderBrowser.SelectedPath = txtFolderPath.Text;
			FolderBrowser.Description = "Select folder:";
			DialogResult result = FolderBrowser.ShowDialog();
			if( result == DialogResult.OK )
			{
				txtFolderPath.Text = FolderBrowser.SelectedPath;
			}
			
		}

		private void btnBrowseIcon_Click(object sender, System.EventArgs e)
		{

			// If there's a value in the folder path text box then default to it.
			if (txtFolderPath.Text.Length > 0)
			{
				FileBrowser.InitialDirectory = txtFolderPath.Text;
			}
			
			// if there's a file in the icon path then default to it, otherwise default to null.
			if (txtIconPath.Text.Length > 0)
			{
				FileBrowser.FileName = txtIconPath.Text;
			}
			else
			{
				FileBrowser.FileName = null;
			}
			
			// Display the openFile dialog.
			FileBrowser.Filter = "Icon files (*.ico)|*.ico|All files (*.*)|*.*";
			FileBrowser.FilterIndex = 1;
			FileBrowser.RestoreDirectory = false;
			DialogResult result = FileBrowser.ShowDialog();

			// OK button was pressed.
			if(result == DialogResult.OK) 
			{
				txtIconPath.Text = FileBrowser.FileName;
			}
		}

		private void btnCreateIcon_Click(object sender, System.EventArgs e)
		{
            if ( txtFolderPath.Text.Length > 0 )
            {
                if ( File.Exists( txtIconPath.Text ) )
                {
                    FolderIcon myFolderIcon = new FolderIcon(txtFolderPath.Text);
                    myFolderIcon.CreateFolderIcon(txtIconPath.Text, txtInfoTip.Text);
                    myFolderIcon = null;
                    MessageBox.Show ("Icon assigned to folder.", 
                                    "Icon Assigned", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                }            
                else
                {
                    MessageBox.Show ("Please enter or browse to a valid icon file.", 
                                    "No Icon Selected", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show ("Please enter or browse to a valid folder.", 
                                 "No Folder Selected", 
                                 MessageBoxButtons.OK, 
                                 MessageBoxIcon.Exclamation);
            }
		}

	}
}
