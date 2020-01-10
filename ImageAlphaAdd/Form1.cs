using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using TGASharpLib;

namespace ImageAlphaAdd
{
    public partial class frmImageAlphaAdder : Form
    {
        bool expandedWindow = false;
        Bitmap baseImage;
        Bitmap alphaImage;
        TGA T;
        int counter = 0;

        public frmImageAlphaAdder()
        {
            InitializeComponent();
        }

        private void frmImageAlphaAdder_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#FF21252B");
            loadUserInput();
            if (chkSaveElsewhere.Checked)
            {
                btnOutputDir.Text = "Output Directory";
                btnOutputDir.Enabled = true;
                txtOutputDir.Enabled = true;

            }
            else
            {
                btnOutputDir.Text = "Saving In Same Place";
                btnOutputDir.Enabled = false;
                txtOutputDir.Enabled = false;
            }
        }

        private void frmImageAlphaAdder_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveUserInput();
        }

        private void btnSteamLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561198376332678");
        }

        private void btnGithubLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DefyTheRush");
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            if (expandedWindow == false)
            {
                tmrExpandWindow.Start();
            }
            else
            {
                tmrRetractWindow.Start();
            }
        }
        
        private void btnBaseImage_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog baseImageBrowser = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse supported image file",
                RestoreDirectory = true,
            };
            
            baseImageBrowser.IsFolderPicker = false;
            baseImageBrowser.Filters.Add(new CommonFileDialogFilter("PNG Files", "*.png"));
            baseImageBrowser.Filters.Add(new CommonFileDialogFilter("JPG Files", "*.jpg"));
            baseImageBrowser.Filters.Add(new CommonFileDialogFilter("TIF Files", "*.tif"));
            baseImageBrowser.Filters.Add(new CommonFileDialogFilter("TIFF Files", "*.tiff"));
            baseImageBrowser.InitialDirectory = txtBaseImageLocation.Text;
            if (baseImageBrowser.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtBaseImageLocation.Text = baseImageBrowser.FileName;
                baseImage = new Bitmap(txtBaseImageLocation.Text);
            }
        }

        private void btnAlpha_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog alphaImageBrowser = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse supported image file",
                RestoreDirectory = true,
            };

            alphaImageBrowser.IsFolderPicker = false;
            alphaImageBrowser.Filters.Add(new CommonFileDialogFilter("PNG Files", "*.png"));
            alphaImageBrowser.Filters.Add(new CommonFileDialogFilter("JPG Files", "*.jpg"));
            alphaImageBrowser.Filters.Add(new CommonFileDialogFilter("TIF Files", "*.tif"));
            alphaImageBrowser.Filters.Add(new CommonFileDialogFilter("TIFF Files", "*.tiff"));
            alphaImageBrowser.InitialDirectory = txtBaseImageLocation.Text;
            if (alphaImageBrowser.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtAlphaImageLocation.Text = alphaImageBrowser.FileName;
                alphaImage = new Bitmap(txtAlphaImageLocation.Text);
            }
        }
        
        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog outputFolderBrowser = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse output folder",
                RestoreDirectory = true,
            };

            outputFolderBrowser.IsFolderPicker = true;
            if (outputFolderBrowser.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtOutputDir.Text = outputFolderBrowser.FileName + "\\";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            bool invalidImageType = false;
            if (txtBaseImageLocation.Text.Equals("") || baseImage == null) {
                invalidImageType = true;
                lblProgramTitle.Text = " Need Base Image!";
                tmrLabelSwitchPrompt.Start();
            }
            else if (txtAlphaImageLocation.Text.Equals("") || alphaImage == null)
            {
                invalidImageType = true;
                lblProgramTitle.Text = "Need Alpha Image!";
                tmrLabelSwitchPrompt.Start();
            }

            if (invalidImageType == true)
            {

            }
            else
            {
                try
                {
                    if (radTextures.Checked)
                    {
                        Bitmap newResult = new Bitmap(baseImage.Width, baseImage.Height, PixelFormat.Format32bppArgb);
                        for (int i = 0; i < baseImage.Width; i++)
                        {
                            for (int j = 0; j < baseImage.Height; j++)
                            {
                                Color newColor = Color.FromArgb(alphaImage.GetPixel(i, j).R, baseImage.GetPixel(i, j));
                                newResult.SetPixel(i, j, newColor);
                            }
                        }

                        T = (TGA)newResult;
                        if (chkSaveElsewhere.Checked)
                        {
                            String outputDir = txtOutputDir.Text.Substring(0, txtOutputDir.Text.LastIndexOf("\\"));
                            String fileName = txtBaseImageLocation.Text.Substring(txtBaseImageLocation.Text.LastIndexOf("\\"));
                            T.Save(outputDir + fileName.Substring(0, fileName.LastIndexOf(".")) + ".tga");
                        }
                        else
                        {
                            T.Save(txtBaseImageLocation.Text.Substring(0, txtBaseImageLocation.Text.LastIndexOf(".")) + ".tga");
                        }
                        lblProgramTitle.Text = "The Image Is Done!";
                        tmrLabelSwitchPrompt.Start();
                    }
                }
                catch (Exception)
                {
                    lblProgramTitle.Text = "Incorrect Parameters!";
                    tmrLabelSwitchPrompt.Start();
                }
            }
        }

        private void tmrErrorMessage_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                tmrLabelSwitchPrompt.Stop();
                counter = 0;
                lblProgramTitle.Text = "Image Alpha Adder";
            }
        }
        
        private void tmrExpandWindow_Tick(object sender, EventArgs e)
        {
            this.Width += 5;
            if (this.Width == 836)
            {
                tmrExpandWindow.Stop();
                expandedWindow = true;
            }

        }

        private void tmrRetractWindow_Tick(object sender, EventArgs e)
        {
            this.Width -= 5;
            if (this.Width == 601)
            {
                tmrRetractWindow.Stop();
                expandedWindow = false;
            }
        }
        
        private void chkSaveElsewhere_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveElsewhere.Checked)
            {
                btnOutputDir.Text = "Output Directory";
                btnOutputDir.Enabled = true;
                txtOutputDir.Enabled = true;

            }
            else
            {
                btnOutputDir.Text = "Saving In Same Place";
                btnOutputDir.Enabled = false;
                txtOutputDir.Enabled = false;
            }
        }
        
        private void saveUserInput()
        {
            ImageAlphaAdd.Properties.Settings.Default.BaseImageLocation = txtBaseImageLocation.Text;
            ImageAlphaAdd.Properties.Settings.Default.AlphaImageLocation = txtAlphaImageLocation.Text;
            ImageAlphaAdd.Properties.Settings.Default.OutputDirectoryLocation = txtOutputDir.Text; ;
            if (radTextures.Checked)
            {
                ImageAlphaAdd.Properties.Settings.Default.ProgramOptionChoice = 1;
            }
            else if (radHUDIcon.Checked)
            {
                ImageAlphaAdd.Properties.Settings.Default.ProgramOptionChoice = 2;
            }
            if (chkSaveElsewhere.Checked)
            {
                ImageAlphaAdd.Properties.Settings.Default.SaveElsewhereChoice = 1;
            }
            else
            {
                ImageAlphaAdd.Properties.Settings.Default.SaveElsewhereChoice = 2;
            }
            ImageAlphaAdd.Properties.Settings.Default.Save();
        }

        private void loadUserInput()
        {
            txtBaseImageLocation.Text = ImageAlphaAdd.Properties.Settings.Default.BaseImageLocation;
            txtAlphaImageLocation.Text = ImageAlphaAdd.Properties.Settings.Default.AlphaImageLocation;
            txtOutputDir.Text = ImageAlphaAdd.Properties.Settings.Default.OutputDirectoryLocation;
            if (ImageAlphaAdd.Properties.Settings.Default.ProgramOptionChoice == 1)
            {
                radTextures.Checked = true;
            }
            else if (ImageAlphaAdd.Properties.Settings.Default.ProgramOptionChoice == 2)
            {
                radHUDIcon.Checked = true;
            }
            if (ImageAlphaAdd.Properties.Settings.Default.SaveElsewhereChoice == 1)
            {
                chkSaveElsewhere.Checked = true;
            }
            else
            {
                chkSaveElsewhere.Checked = false;
            }
            if (txtBaseImageLocation.Text.Equals("") || txtAlphaImageLocation.Text.Equals(""))
            {

            }
            else
            {
                baseImage = new Bitmap(txtBaseImageLocation.Text);
                alphaImage = new Bitmap(txtAlphaImageLocation.Text);
            }
        }
    }
}
