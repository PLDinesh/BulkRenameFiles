using NLog;
using System.IO;
using System.Linq;
namespace BulkRenameFiles
{
    public partial class MainForm : Form
    {
        private static readonly Logger oLogger = LogManager.GetCurrentClassLogger();
        public MainForm()
        {
            oLogger.Info("Application starting up..");
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (FindText.Text.Equals(string.Empty))
            {
                return;
            }
            if (SourceDirectory.Text.Equals(string.Empty))
            {
                return;
            }
            oLogger.Debug("Params-> Path: {0} Find: {1} Replace: {2}", SourceDirectory.Text, FindText.Text, ReplaceText.Text);
            RenameFilesRecusively(SourceDirectory.Text);
        }

        private void RenameFilesRecusively(string Path)
        {
            oLogger.Debug("Currently running for -> {0}", Path);
            DirectoryInfo objDI = new DirectoryInfo(Path);
            if (chkRecursive.Checked)
            {
                foreach (DirectoryInfo di in objDI.GetDirectories())
                {
                    RenameFilesRecusively(di.FullName);
                    if (di.Name.Contains(FindText.Text))
                    {
                        oLogger.Debug("Moving {0} to {1}", di.FullName, di.Name.Replace(FindText.Text, ReplaceText.Text));
                        di.MoveTo(di.Parent + @"\" + di.Name.Replace(FindText.Text, ReplaceText.Text));
                    }
                }
            }

            foreach (FileInfo x in objDI.GetFiles())
            {
                if (x.FullName.Contains(FindText.Text))
                {

                    oLogger.Debug("Rename -> {0} {1}", x.Name, x.Name.Replace(FindText.Text, ReplaceText.Text));
                    if (x.Directory != null)
                    {
                        x.MoveTo(x.DirectoryName + @"\" + x.Name.Replace(FindText.Text, ReplaceText.Text));
                        oLogger.Debug("Moving {0} to {1}", x.Name.Replace(FindText.Text, ReplaceText.Text));
                        if (File.Exists(x.FullName))
                        {
                            oLogger.Debug("Moving {0} to {1}", x.Name.Replace(FindText.Text.Trim(), ReplaceText.Text));
                            x.MoveTo(x.DirectoryName + @"\" + x.Name.Replace(FindText.Text.Trim(), ReplaceText.Text));
                        }
                    }
                }


            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgBrowse.SelectedPath.Equals(string.Empty))
            {

                dlgBrowse.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            dlgBrowse.ShowDialog();
            FindText.Text = dlgBrowse.SelectedPath;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            oLogger.Info("Application begin closing..");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            oLogger.Info("Application graceful shutdown..");
        }
    }
}