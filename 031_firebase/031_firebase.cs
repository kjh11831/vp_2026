using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _031_firebase
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "4U66UCy4DahlPiNm2wmQGYX54qLwhRBYOVIXaLKG",
            BasePath = "https://phonebook-fe88b-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();

            client = new FireSharp.FirebaseClient(config);

            if (client != null )
            {
                MessageBox.Show("Connection 성공!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
