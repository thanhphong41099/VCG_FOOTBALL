using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace VLeague.src.menu
{
    public partial class chaychungang : UserControl
    {
        private static string key = "CONNECT NEWS";

        private static string workingPath = "WORKINGFOLDERNEWS";

        private string currentFilePath;
        public chaychungang()
        {
            InitializeComponent();
            dgvChayChuNgang.CellClick += dgvChayChuNgang_CellClick;

        }

        private void chaychungang_Load(object sender, EventArgs e)
        {
            numSpeedNewsFeed.Value = numSpeedChuNgang.Value = DBConfig.doGetIntValue("CHAYCHUNGANG", "speed");
            linkChayChuNgang.Text = AppConfig.ConfigReader.ReadString(key, workingPath) + "\\Data";
            LoadFilesToDataGridView();
        }

        private void btnOpenChayChuNewsFeed_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                linkNewsFeed.Text = openFileDialog.FileName;
                txtChayChuNewsFeed.Text = File.ReadAllText(linkNewsFeed.Text);
            }
        }

        private void btnChayChuNewsFeed_Click(object sender, EventArgs e)
        {
            string scene = DBConfig.doGetStringValue("CHAYCHUNGANG", "data");
            string text = txtChayChuNewsFeed.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                string replacedText = text.Replace(Environment.NewLine, "                              ");

                int speed = (int)numSpeedChuNgang.Value;
                FrmKarismaMenu.FrmSettingNews.loadChayChuNgang(scene, FrmNews.layerChayChuNgang, replacedText, speed);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập văn bản trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCapNhatChayChuNewsFeed_Click(object sender, EventArgs e)
        {
            File.WriteAllText(linkNewsFeed.Text, txtChayChuNewsFeed.Text, Encoding.UTF8);
            MessageBox.Show("Nội dung đã được lưu.");
        }

        private void btnOpenChayChuNgang_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                linkChayChuNgang.Text = openFileDialog.FileName;
                string fileName = Path.GetFileName(openFileDialog.FileName);
                dgvChayChuNgang.Rows.Add(fileName);
            }
        }

        private void btnCapNhatChayChuNgang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                try
                {
                    File.WriteAllText(currentFilePath, txtChayChuNgang.Text);
                    MessageBox.Show("Nội dung đã được lưu.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu tệp: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có tệp nào được chọn để lưu.");
            }
        }

        private void txtChayChuNewsFeed_TextChanged(object sender, EventArgs e)
        {
            int length = txtChayChuNewsFeed.Text.Length;
            txtLengthNewsFeed.Text = length.ToString();
        }

        private void txtChayChuNgang_TextChanged(object sender, EventArgs e)
        {
            int length = txtChayChuNgang.Text.Length;
            txtLength.Text = length.ToString();
        }

        private void LoadFilesToDataGridView()
        {
            try
            {
                string folderPath = linkChayChuNgang.Text;

                if (Directory.Exists(folderPath))
                {
                    string[] files = Directory.GetFiles(folderPath, "*.txt");
                    dgvChayChuNgang.Rows.Clear();
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        dgvChayChuNgang.Rows.Add(fileName);
                    }
                }
                else
                {
                    MessageBox.Show("Thư mục không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void dgvChayChuNgang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string fileName = dgvChayChuNgang.Rows[e.RowIndex].Cells[0].Value.ToString();

                string folderPath = linkChayChuNgang.Text;
                string filePath = Path.Combine(folderPath, fileName);
                currentFilePath = Path.Combine(folderPath, fileName);

                try
                {
                    if (File.Exists(filePath))
                    {
                        txtChayChuNgang.Text = File.ReadAllText(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Tệp không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đọc tệp: " + ex.Message);
                }
            }
        }

        private void btnChayChuNgang_Click(object sender, EventArgs e)
        {
            string scene = DBConfig.doGetStringValue("CHAYCHUNGANG", "data");
            string text = txtChayChuNgang.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                string replacedText = text.Replace(Environment.NewLine, "                    ");

                int speed = (int)numSpeedChuNgang.Value;
                FrmKarismaMenu.FrmSettingNews.loadChayChuNgang(scene, FrmNews.layerChayChuNgang, replacedText, speed);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập văn bản trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNgungChayChuNewsFeed_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerChayChuNgang);
        }

        private void btnNgungChayChuNgang_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSettingNews.StopEff(FrmNews.layerChayChuNgang);
        }
    }
}
