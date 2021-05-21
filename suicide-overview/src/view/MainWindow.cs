using suicide_overview.src.model;
using suicide_overview.src.view;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace suicide_overview
{
    public partial class MainWindow : Form
    {
        private MasterClass mc;

        public MainWindow()
        {
            InitializeComponent();

            mc = new MasterClass();

            BringToFront();
          
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizedButton_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ViewColumnsReports_Click(object sender, System.EventArgs e)
        {
            mainPane.Controls.Clear();
            RecordsViewer cr = new RecordsViewer(mc);
            mainPane.Controls.Add(cr);
        }

        private void ViewGraphs_Click(object sender, System.EventArgs e)
        {
            mainPane.Controls.Clear();
            Graphs br = new Graphs(mc);
            mainPane.Controls.Add(br);
        }

        private void RiskSimulator_Click(object sender, System.EventArgs e)
        {
            mainPane.Controls.Clear();
            SimulatorWindow sw = new SimulatorWindow(mc);
            mainPane.Controls.Add(sw);
        }

        private void TittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}