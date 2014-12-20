using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FTD2XX_NET;
using System.IO;

namespace ESPLoader
{
    public partial class Form1 : Form
    {

        COMPort comport = new COMPort();
        FTDIPort ftdiport = new FTDIPort();
        InterfacePort port = new InterfacePort();
        ESP8266ProgrammingTool esp = new ESP8266ProgrammingTool();

        List<SourceFile> BinaryFilesToFlash;
        bool COMisOpened;

        public Form1()
        {
            InitializeComponent();

            BinaryFilesToFlash = new List<SourceFile>();
            cboMemoryLocation.SelectedIndex = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            COMisOpened = false;
            esp.StatusChange += StatusChange;
            ((Control)this.tabTCPServer).Enabled = false;

        }

        void StatusChange(object sender, EventArgs e)
        {
            tsStatusLabel.Text = "[PROGRAMMER] " + esp.CurrentStatus;

            if (esp.CurrentStatus == "Finished")
                tsProgrammingProgress.Visible = false;
            else
            {
                tsProgrammingProgress.Visible = true;
                tsProgrammingProgress.Value = (int)esp.PercentComplete;
            }
            
            statusStrip.Refresh();
        }

        private void btnProgrammingInterface_Click(object sender, EventArgs e)
        {
            if(COMisOpened)
            {
                if (port.Close() == 0)
                {
                    tsCOMStatusLabel.Text = port.PortType() + " Port is Closed!";
                    btnProgrammingInterface.Text = "Open";
                    COMisOpened = false;

                    cboPorts.Enabled = true;
                    btnReset.Enabled = false;
                    btnFlash.Enabled = false;
                }
                else
                {
                    tsCOMStatusLabel.Text = port.PortType() + " Error - couldn't close!";
                }
            }
            else
            {
                if (cboPorts.Text.StartsWith("[COM]"))
                {
                    port = new COMPort();
                }
                if (cboPorts.Text.StartsWith("[FTDI]"))
                {
                    port = new FTDIPort();
                }

                if (port.OpenPort(cboPorts.Text, 75000) == 0)
                {
                    esp.SetInterface(ref port);

                    tsCOMStatusLabel.Text = port.PortType() + " Port is Open!";
                    btnProgrammingInterface.Text = "Close";
                    COMisOpened = true;

                    cboPorts.Enabled = false;
                    btnFlash.Enabled = true;
                    
                    if(port.PortType() == "[FTDI]")
                    {
                        btnReset.Enabled = true;
                    }

                    timer1.Enabled = true;
                }
                else
                {
                    tsCOMStatusLabel.Text = port.PortType() + " Error - couldn't open!";
                }

            }

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            esp.Reset();
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            foreach(SourceFile file in BinaryFilesToFlash)
            {
                esp.AddBinaryFile(file);
            }

            esp.Flash();
        }

        private void aboutESPLoaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESPLoader 0.2 by:\r\n\r\nMathijs van den Berg <mathijsvandenberg3@gmail.com>\r\nJonathan Georgino <ESPTools@jonathangeorgino.com>\r\n\r\nhttps://github.com/mathijsvandenberg/esploader/");

        }

        private void cboPorts_DropDown(object sender, EventArgs e)
        {
            cboPorts.Items.Clear();
            //list available COM ports (COMPort.cs)
            foreach (string s in comport.GetPortNames())
            {
                cboPorts.Items.Add("[COM] " + s);
            }

            //list available FTDI ports (FTDIPort.cs)
            foreach (string s in ftdiport.GetPortNames())
            {
                cboPorts.Items.Add("[FTDI] " + s);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            if (txtFilePath.Text == "[Double-Click to Select File]" || txtFilePath.Text == "")
                btnAddFile.Enabled = false;
            else
                btnAddFile.Enabled = true;

        }

        private void txtFilePath_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result;
            string file;

            openFileDialog.Title = "Select .bin file";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "(*.bin)|*.bin|All files (*.*)|*.*";
            result = openFileDialog.ShowDialog();

            if(result != System.Windows.Forms.DialogResult.Cancel)
            {
                file = openFileDialog.FileName;
                try
                {
                    txtFilePath.Text = file;
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot open file " + file);
                    txtFilePath.Text = "[Double-Click to Select File]";
                }
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {

            string hex_number = cboMemoryLocation.Text.ToString();
            hex_number = hex_number.Substring(2);
            Int64 mem_location = Int64.Parse(hex_number, System.Globalization.NumberStyles.HexNumber);

            BinaryFilesToFlash.Add(new SourceFile(txtFilePath.Text, mem_location));

            txtFilePath.Text = "[Double-Click to Select File]";

            UpdateFileListBox();

        }

        private void UpdateFileListBox()
        {
            lstFiles.Items.Clear();

            foreach(SourceFile file in BinaryFilesToFlash)
            {
                lstFiles.Items.Add("0x" + file.MemoryLocation.ToString("X5") + ", " + file.ShortName);
            }

            if (BinaryFilesToFlash.Count() > 0)
                btnClearAllFiles.Enabled = true;
            else
            {
                btnClearAllFiles.Enabled = false;
                btnRemove.Enabled = false;

            }
                
        }

        private void btnClearAllFiles_Click(object sender, EventArgs e)
        {
            BinaryFilesToFlash.Clear();
            UpdateFileListBox();

        }

        private void lstFiles_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedIndex != -1)
                btnRemove.Enabled = true;
            else
                btnRemove.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            BinaryFilesToFlash.RemoveAt(lstFiles.SelectedIndex);
            UpdateFileListBox();
        }
    }
}
