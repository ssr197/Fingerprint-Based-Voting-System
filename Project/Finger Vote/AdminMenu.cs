using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Finger_ATM
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void addCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCandidate a = new AddCandidate();
            a.MdiParent = this;
            a.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addElectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddElection a = new AddElection();
            a.MdiParent = this;
            a.Show();
        }

        private void addVotersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVoter a = new AddVoter();
            a.MdiParent = this;
            a.Show();
        }

        private void viewResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewResult a = new ViewResult();
            a.MdiParent = this;
            a.Show();
        }

        private void viewCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCandidate a = new ViewCandidate();
            a.MdiParent = this;
            a.Show();
        }

        private void caculateResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result a = new Result();
            a.MdiParent = this;
            a.Show();
        }
    }
}
