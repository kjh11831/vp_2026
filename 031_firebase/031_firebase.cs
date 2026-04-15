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

            if (client != null)
            {
                MessageBox.Show("Client 객체 생성!");
            }

            try
            {
                var r = client.Set("test", "OK");
                MessageBox.Show("연결 성공!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("연결 실패!\n" + ex.Message);
            }
        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = txt_id.Text.Trim(),
                IdN = txt_id_number.Text.Trim(),
                Name = txt_name.Text.Trim(),
                Phone = txt_phone_number.Text.Trim()
            };

            SetResponse response = await
                client.SetAsync("Phonebook/" + data.Id, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data Inserted : Id = " + result.Id);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_id_number.Text = "";
            txt_name.Text = string.Empty;
            txt_phone_number.Text = string.Empty;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}