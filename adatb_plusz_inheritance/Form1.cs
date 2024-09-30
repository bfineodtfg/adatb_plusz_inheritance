using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatb_plusz_inheritance
{
    public partial class Form1 : Form
    {
        databaseHandler db;
        public Form1()
        {
            InitializeComponent();
            db = new databaseHandler();
            db.ReadAll();
        }
    }
}
