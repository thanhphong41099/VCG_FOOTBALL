using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using VLeague.src.helper;
using VLeague.src.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VLeague.src.menu
{
    public partial class FrmDataImport : Form
    {
        public static string homeCode, homeTactical, homeTenDai, homeTenNgan, homeHLV, homeLogo, homeHomeItem, homeAwayItem, homeGoalItem;

        public static string awayCode, awayTactical, awayTenDai, awayTenNgan, awayHLV, awayLogo, awayHomeItem, awayAwayItem, awayGoalItem;

        private ColorDialog colorDialog;

        private static string workingPath = "WORKINGFOLDER";

        private static string key = "CONNECT";

        private static string PATH = AppConfig.ConfigReader.ReadString(key, workingPath);

        string HomeLineup = "Lineup1";
        string HomeSub = "Sub1";
        string AwayLineup = "Lineup2";
        string AwaySub = "Sub2";


        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private DataGridViewRow rowToMove;
        private int previousRowIndex = -1;
        private bool isDragging = false;

        public FrmDataImport()
        {
            InitializeComponent();
            colorDialog = new ColorDialog();
            loadDgvAllTeam();
        }

        private void FrmDataImport_Load(object sender, EventArgs e)
        {
            try
            {
                DBConfig.Listteams();
                foreach (DataRow dt in DBConfig.teams.Tables[0].Rows)
                {
                    cbbHomeTeam.Items.Add(dt["TenDai"].ToString());
                    cbbAwayTeam.Items.Add(dt["TenDai"].ToString());
                }
                DBConfig.matchingTacticalCombobox(cbbAwayTactic);
                DBConfig.matchingTacticalCombobox(cbbHomeTactic);

                ComboboxDefault();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu: " + ex.Message + ", kiểm tra đường dẫn Setup", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ComboboxDefault()
        {
            cbbHomeTeam.SelectedIndex = 0;
            cbbAwayTeam.SelectedIndex = 1;
            cbbHomeTactic.SelectedIndex = 1;
            cbbAwayTactic.SelectedIndex = 1;
            cbbShirtHome.SelectedIndex = 0;
            cbbShirtAway.SelectedIndex = 1;

        }
        private void cbbHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thay đổi: Lưu TenDai thay vì TenNgan
            TeamInfor.homeTenDai = homeTenDai = label8.Text = cbbHomeTeam.Text;
            LoadTeamInfoHome();
        }

        private void cbbAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thay đổi: Lưu TenDai thay vì TenNgan  
            TeamInfor.awayTenDai = awayTenDai = label9.Text = cbbAwayTeam.Text;
            LoadTeamInfoAway();
        }

        private void LoadTeamInfoHome()
        {
            // Thay đổi: Tìm kiếm theo TenDai thay vì TenNgan
            TeamInfor.homeCode = homeCode = DBConfig.doGetTeamID(TeamInfor.homeTenDai, "TenDai", "MaDoi");

            // Lấy TenNgan từ homeCode (nếu cần)
            TeamInfor.homeTenNgan = homeTenNgan = DBConfig.doGetStringTeamID(homeCode, "TenNgan");

            // Các dòng khác giữ nguyên
            TeamInfor.homeTenDai = homeTenDai = DBConfig.doGetStringTeamID(homeCode, "TenDai");
            TeamInfor.homeHLV =homeHLV = DBConfig.doGetStringTeamID(homeCode, "HLV");
            TeamInfor.homeLogo = homeLogo = DBConfig.doGetStringTeamID(homeCode, "Logo");
            picHomeLogo.Image = Image.FromFile(homeLogo);
            TeamInfor.homeHomeItem = homeHomeItem = DBConfig.doGetStringTeamID(homeCode, "HOME_ITEM");
            TeamInfor.homeAwayItem = homeAwayItem = DBConfig.doGetStringTeamID(homeCode, "AWAY_ITEM");
            TeamInfor.homeGoalItem = homeGoalItem = DBConfig.doGetStringTeamID(homeCode, "GOAL_ITEM");
        }

        private void LoadTeamInfoAway()
        {
            // Thay đổi: Tìm kiếm theo TenDai thay vì TenNgan
            TeamInfor.awayCode = awayCode = DBConfig.doGetTeamID(TeamInfor.awayTenDai, "TenDai", "MaDoi");

            // Lấy TenNgan từ awayCode (nếu cần)
            TeamInfor.awayTenNgan = awayTenNgan = DBConfig.doGetStringTeamID(awayCode, "TenNgan");

            // Các dòng khác giữ nguyên
            TeamInfor.awayTenDai = awayTenDai = DBConfig.doGetStringTeamID(awayCode, "TenDai");
            TeamInfor.awayHLV = awayHLV = DBConfig.doGetStringTeamID(awayCode, "HLV");
            TeamInfor.awayLogo = awayLogo = DBConfig.doGetStringTeamID(awayCode, "Logo");
            picAwayLogo.Image = Image.FromFile(awayLogo);
            TeamInfor.awayHomeItem = awayHomeItem = DBConfig.doGetStringTeamID(awayCode, "HOME_ITEM");
            TeamInfor.awayAwayItem = awayAwayItem = DBConfig.doGetStringTeamID(awayCode, "AWAY_ITEM");
            TeamInfor.awayGoalItem = awayGoalItem = DBConfig.doGetStringTeamID(awayCode, "GOAL_ITEM");
        }


        private Color ConvertStringToColor(string rgbString)
        {
            // Tách chuỗi "R,G,B" thành các phần tử
            var rgbValues = rgbString.Split(',');

            // Kiểm tra xem có đủ 3 giá trị R, G, B hay không
            if (rgbValues.Length == 3)
            {
                // Chuyển đổi các chuỗi thành số nguyên
                int r = Convert.ToInt32(rgbValues[0]);
                int g = Convert.ToInt32(rgbValues[1]);
                int b = Convert.ToInt32(rgbValues[2]);

                // Tạo đối tượng Color từ các giá trị R, G, B
                return Color.FromArgb(r, g, b);
            }
            return Color.DarkGray;
        }
        private void loadDgvAllTeam()
        {
            DBConfig.doGetAllTeams();
        }

        private void dgvHomePlayer_CellValueChanged()
        {

            foreach (DataGridViewRow row in dgvHomePlayer.Rows)
            {
                if (row.IsNewRow) continue;
                int ID = Convert.ToInt32(row.Cells["ID"].Value);
                string name = row.Cells["Name"].Value.ToString();
                int stt = Convert.ToInt32(row.Cells["STT"].Value);
                int soao = Convert.ToInt32(row.Cells["Jersey #"].Value);
                string tenao = row.Cells["Jersey Name"].Value.ToString();

                int play = row.Cells["PLAY"].Value != null && int.TryParse(row.Cells["PLAY"].Value.ToString(), out int parsedPlay) ? parsedPlay : 0;

                string pos = row.Cells["Position"].Value.ToString();
                string card = row.Cells["Card"].Value.ToString();
                string image = row.Cells["IMAGE"].Value.ToString();
                string path = row.Cells["PATH"].Value.ToString();

                DBConfig.updatePlayersTeam(ID,TeamInfor.homeCode, name, stt, soao, tenao, play, pos, card, image, path);
            }
        }
        private void dgvAwayPlayer_CellValueChanged()
        {

            foreach (DataGridViewRow row in dgvAwayPlayer.Rows)
            {
                if (row.IsNewRow) continue;
                int ID = Convert.ToInt32(row.Cells["ID"].Value);
                string name = row.Cells["Name"].Value.ToString();
                int stt = Convert.ToInt32(row.Cells["STT"].Value);
                int soao = Convert.ToInt32(row.Cells["Jersey #"].Value);
                string tenao = row.Cells["Jersey Name"].Value.ToString();

                int play = row.Cells["PLAY"].Value != null && int.TryParse(row.Cells["PLAY"].Value.ToString(), out int parsedPlay) ? parsedPlay : 0;

                string pos = row.Cells["Position"].Value.ToString();
                string card = row.Cells["Card"].Value.ToString();
                string image = row.Cells["IMAGE"].Value.ToString();
                string path = row.Cells["PATH"].Value.ToString();

                DBConfig.updatePlayersTeam(ID, TeamInfor.awayCode, name, stt, soao, tenao, play, pos, card, image, path);
            }
        }

        private void Player_HomeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Player_HomeColor.BackColor = colorDialog.Color;
            }
        }

        private void Player_AwayColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Player_AwayColor.BackColor = colorDialog.Color;
            }
        }

        private void upMatchID_Click(object sender, EventArgs e)
        {
            DBConfig.doGetInfoTournaments();
            MessageBox.Show("Đã cập nhật dữ liệu Match ID");
        }

        private void upWeather_Click(object sender, EventArgs e)
        {
            DBConfig.doGetInfoWeather();
            MessageBox.Show("Đã cập nhật dữ liệu thời tiết");
        }

        private void upBXH_Click(object sender, EventArgs e)
        {
            DBConfig.doGetSoccerRanking();
            MessageBox.Show("Đã cập nhật dữ liệu Bảng xếp hạng");
        }

        private void upVar_Click(object sender, EventArgs e)
        {
            DBConfig.doGetInforeferee();
            MessageBox.Show("Đã cập nhật dữ liệu trọng tài Var");
        }

        private void upReferee_Click(object sender, EventArgs e)
        {
            DBConfig.doGetInforeferee();
            MessageBox.Show("Đã cập nhật dữ liệu Trọng tài chính");
        }

        private void upStatic_Click(object sender, EventArgs e)
        {
            DBConfig.doGetAllStatistics();
            MessageBox.Show("Đã cập nhật dữ liệu Thống kê");
        }

        private void upHomeLineup_Click(object sender, EventArgs e)
        {
            savePlayerHomeLineSub();
            MessageBox.Show("Đã cập nhật dữ liệu Ra sân đội nhà");
        }

        private void btnAddHomePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newRow = dgvHomePlayer.Rows[dgvHomePlayer.Rows.Count - 2]; // -2 để bỏ qua hàng trống cuối cùng

                int ID = newRow.Cells["ID"].Value != null && int.TryParse(newRow.Cells["ID"].Value.ToString(), out int parsedID) ? parsedID : 0;
                string name = newRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                int stt = newRow.Cells["STT"].Value != null ? Convert.ToInt32(newRow.Cells["STT"].Value) : 0;
                int soao = newRow.Cells["Jersey #"].Value != null ? Convert.ToInt32(newRow.Cells["Jersey #"].Value) : 0;
                string tenao = newRow.Cells["Jersey Name"].Value?.ToString() ?? string.Empty;
                int play = newRow.Cells["PLAY"].Value != null && int.TryParse(newRow.Cells["PLAY"].Value.ToString(), out int parsedPlay) ? parsedPlay : 0;
                string pos = newRow.Cells["Position"].Value?.ToString() ?? string.Empty;
                string card = newRow.Cells["Card"].Value?.ToString() ?? string.Empty;
                string image = newRow.Cells["IMAGE"].Value?.ToString() ?? string.Empty;
                string path = newRow.Cells["PATH"].Value?.ToString() ?? string.Empty;

                if (ID == 0)
                {
                    Random rand = new Random();
                    ID = rand.Next(500, 9999);
                }
                    DBConfig.insertPlayer(ID, TeamInfor.homeCode, name, stt, soao, tenao, play, pos, card, image, path);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm cầu thủ mới: " + ex.Message);
            }
        }

        private void btnAddAwayPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newRow = dgvAwayPlayer.Rows[dgvAwayPlayer.Rows.Count - 2]; // -2 để bỏ qua hàng trống cuối cùng

                int ID = newRow.Cells["ID"].Value != null && int.TryParse(newRow.Cells["ID"].Value.ToString(), out int parsedID) ? parsedID : 0;
                string name = newRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                int stt = newRow.Cells["STT"].Value != null ? Convert.ToInt32(newRow.Cells["STT"].Value) : 0;
                int soao = newRow.Cells["Jersey #"].Value != null ? Convert.ToInt32(newRow.Cells["Jersey #"].Value) : 0;
                string tenao = newRow.Cells["Jersey Name"].Value?.ToString() ?? string.Empty;
                int play = newRow.Cells["PLAY"].Value != null && int.TryParse(newRow.Cells["PLAY"].Value.ToString(), out int parsedPlay) ? parsedPlay : 0;
                string pos = newRow.Cells["Position"].Value?.ToString() ?? string.Empty;
                string card = newRow.Cells["Card"].Value?.ToString() ?? string.Empty;
                string image = newRow.Cells["IMAGE"].Value?.ToString() ?? string.Empty;
                string path = newRow.Cells["PATH"].Value?.ToString() ?? string.Empty;

                if (ID == 0)
                {
                    Random rand = new Random();
                    ID = rand.Next(500, 9999);
                }
                DBConfig.insertPlayer(ID, TeamInfor.awayCode, name, stt, soao, tenao, play, pos, card, image, path);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm cầu thủ mới: " + ex.Message);
            }
        }

        #region Kéo thả chuột để hoán đổi vị trí 2 cầu thủ dgvHomePlayer/dgvAwayPlayer
        private void dgvHomePlayer_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(dgvHomePlayer, e);
        }

        private void dgvAwayPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(dgvAwayPlayer, e);
        }

        private void HandleMouseDown(DataGridView dataGridView, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
                    dataGridView.CurrentCell = dataGridView.Rows[hitTestInfo.RowIndex].Cells[0];
                }
            }
            DataGridView.HitTestInfo hit = dataGridView.HitTest(e.X, e.Y);

            // Bỏ qua các dòng trống hoặc dòng không hợp lệ
            if (hit.RowIndex >= 0 && hit.RowIndex != dataGridView.NewRowIndex)
            {
                rowIndexFromMouseDown = hit.RowIndex;
                rowToMove = dataGridView.Rows[rowIndexFromMouseDown];
                isDragging = false; // Đặt cờ isDragging thành false khi nhấn chuột xuống
            }
        }

        private void dgvHomePlayer_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMouseMove(dgvHomePlayer, e);
        }

        private void dgvAwayPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMouseMove(dgvAwayPlayer, e);
        }

        private void HandleMouseMove(DataGridView dataGridView, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && rowToMove != null)
            {
                rowIndexOfItemUnderMouseToDrop = dataGridView.HitTest(e.X, e.Y).RowIndex;

                if (rowIndexOfItemUnderMouseToDrop >= 0 && rowIndexOfItemUnderMouseToDrop != dataGridView.NewRowIndex)
                {
                    // Đặt cờ isDragging thành true khi có di chuyển chuột
                    isDragging = true;
                    // Khôi phục màu của hàng trước đó (nếu có)
                    if (previousRowIndex >= 0 && previousRowIndex < dataGridView.Rows.Count)
                    {
                        var previousRow = dataGridView.Rows[previousRowIndex];
                        previousRow.DefaultCellStyle.BackColor = Color.White;
                    }
                    var targetRow = dataGridView.Rows[rowIndexOfItemUnderMouseToDrop];
                    targetRow.DefaultCellStyle.BackColor = Color.LightBlue;

                    previousRowIndex = rowIndexOfItemUnderMouseToDrop;
                }
            }
        }

        private void dgvHomePlayer_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseUp(dgvHomePlayer, e);
        }

        private void dgvAwayPlayer_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseUp(dgvAwayPlayer, e);
        }

        private void HandleMouseUp(DataGridView dataGridView, MouseEventArgs e)
        {
            if (isDragging && rowToMove != null)
            {
                ResetAllRowColors(dataGridView);

                if (rowIndexOfItemUnderMouseToDrop >= 0 &&
                    rowIndexOfItemUnderMouseToDrop != dataGridView.NewRowIndex && rowIndexFromMouseDown != rowIndexOfItemUnderMouseToDrop)
                {
                    // Lấy dữ liệu từ hàng được kéo
                    DataGridViewRow newRow = (DataGridViewRow)rowToMove.Clone();
                    for (int i = 0; i < rowToMove.Cells.Count; i++)
                    {
                        newRow.Cells[i].Value = rowToMove.Cells[i].Value;
                    }

                    // Xóa hàng cũ
                    dataGridView.Rows.RemoveAt(rowIndexFromMouseDown);

                    // Chèn hàng vào vị trí mới
                    dataGridView.Rows.Insert(rowIndexOfItemUnderMouseToDrop, newRow);

                    // Cập nhật lại số thứ tự (STT)
                    UpdateSTTColumn(dataGridView);

                    // Chọn hàng mới
                    dataGridView.ClearSelection();
                    newRow.Selected = true;
                    dataGridView.CurrentCell = newRow.Cells[0];
                }

                // Đặt lại các biến sau khi hoàn thành thao tác
                rowToMove = null;
                previousRowIndex = -1;
            }

            isDragging = false;
        }

        private void cbbShirtHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbShirtHome.SelectedIndex)
            {
                case 0:
                    HomeLineup = "Lineup1";
                    HomeSub = "Sub1";
                    break;
                case 1:
                    HomeLineup = "Lineup2";
                    HomeSub = "Sub2";
                    break;
                case 2:
                    HomeLineup = "Lineup3";
                    HomeSub = "Sub3";
                    break;
                default:
                    // Xử lý trường hợp không mong đợi
                    HomeLineup = "Lineup1";
                    HomeSub = "Sub1";
                    break;
            }
        }

        private void cbbShirtAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbShirtAway.SelectedIndex)
            {
                case 0:
                    AwayLineup = "Lineup1";
                    AwaySub = "Sub1";
                    break;
                case 1:
                    AwayLineup = "Lineup2";
                    AwaySub = "Sub2";
                    break;
                case 2:
                    AwayLineup = "Lineup3";
                    AwaySub = "Sub3";
                    break;
                default:
                    // Xử lý trường hợp không mong đợi
                    AwayLineup = "Lineup1";
                    AwaySub = "Sub1";
                    break;
            }
        }

        private void btnSaveTeam_Click(object sender, EventArgs e)
        {
            if (cbbHomeTeam.Text.Equals("") || cbbAwayTeam.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn đội bóng");
                FrmKarismaMenu.FrmSetting.OnLogMessage("Chưa chọn đội");
                labelStatus.Text = "Chưa chọn đội bóng";
                return;
            }
            if (cbbHomeTactic.Text.Equals("") || cbbAwayTactic.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn đội hình");
                FrmKarismaMenu.FrmSetting.OnLogMessage("Chưa chọn đội hình");
                labelStatus.Text = "Chưa chọn đội hình";
                return;
            }
            if (cbbShirtHome.Text.Equals("") || cbbShirtAway.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn áo thi đấu");
                FrmKarismaMenu.FrmSetting.OnLogMessage("Chưa chọn áo thi đấu");
                labelStatus.Text = "Chưa chọn áo thi đấu";
                return;
            }
            LoadTeamInfoHome();
            LoadTeamInfoAway();
            FrmKarismaMenu.closeTabwithFrmDataImport();
            savePlayerHomeLineSub();
            savePlayerAwayLineSub();
            savePlayersHome();
            savePlayersAway();
            TeamInfor.UpdateData(homeCode, homeTactical, homeTenDai, homeTenNgan, homeHLV, homeLogo,
            awayCode, awayTactical, awayTenDai, awayTenNgan, awayHLV, awayLogo,
         Player_HomeColor.BackColor, Player_AwayColor.BackColor, homeHomeItem, homeAwayItem, awayHomeItem, awayAwayItem,
         homeGoalItem, awayGoalItem);

            labelStatus.Text = "OK!";
            labelTimeUpdated.Text = DateTime.Now.ToString("hh:mm:ss tt");
            MessageBox.Show("Thiết lập thành công!");
        }

        private void ResetAllRowColors(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void UpdateSTTColumn(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].IsNewRow) continue; // Bỏ qua hàng mới

                dataGridView.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        #endregion

        private void SortDataGridViewByPlayColumn(DataGridView dataGridView)
        {
            var rows = dataGridView.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .OrderBy(row => {
                    int value;
                    return int.TryParse(row.Cells["PLAY"].Value?.ToString(), out value) ? value : int.MaxValue;
                })
                .ToList();

            dataGridView.Rows.Clear();
            foreach (var row in rows)
            {
                dataGridView.Rows.Add(row);
            }
        }
        private void btnSaveHomePlayer_Click(object sender, EventArgs e)
        {
            //dgvHomePlayer_CellValueChanged();
            savePlayerHomeLineSub();
            savePlayersHome();

            MessageBox.Show("Đã lưu danh sách cầu thủ: ĐỘI NHÀ");
        }

        private void btnSaveAwayPlayer_Click(object sender, EventArgs e)
        {
            //dgvAwayPlayer_CellValueChanged();
            savePlayerAwayLineSub();
            savePlayersAway();

            MessageBox.Show("Đã lưu danh sách cầu thủ: ĐỘI KHÁCH");
        }

        private void btnSortHomePlayer_Click(object sender, EventArgs e)
        {
            SortDataGridViewByPlayColumn(dgvHomePlayer);
            UpdateSTTColumn(dgvHomePlayer);
            MessageBox.Show("Sắp xếp đội hình ra sân: ĐỘI NHÀ");
        }

        private void btnSortAwayPlayer_Click(object sender, EventArgs e)
        {
            SortDataGridViewByPlayColumn(dgvAwayPlayer);
            UpdateSTTColumn(dgvAwayPlayer);
            MessageBox.Show("Sắp xếp đội hình ra sân: ĐỘI KHÁCH");
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (cbbHomeTeam.Text.Equals("") || cbbAwayTeam.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn đội bóng");
                FrmKarismaMenu.FrmSetting.OnLogMessage("Chưa chọn đội");
                labelStatus.Text = "Chưa chọn đội bóng";
                return;
            }
            if (cbbHomeTactic.Text.Equals("") || cbbAwayTactic.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn đội hình");
                FrmKarismaMenu.FrmSetting.OnLogMessage("Chưa chọn đội hình");
                labelStatus.Text = "Chưa chọn đội hình";
                return;
            }
            if (cbbShirtHome.Text.Equals("") || cbbShirtAway.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn áo thi đấu");
                FrmKarismaMenu.FrmSetting.OnLogMessage("Chưa chọn áo thi đấu");
                labelStatus.Text = "Chưa chọn áo thi đấu";
                return;
            }
            LoadTeamInfoHome();
            LoadTeamInfoAway();
            FrmKarismaMenu.closeTabwithFrmDataImport();
            LoadHomePlayerGrid();
            LoadAwayPlayerGrid();
            savePlayerHomeLineSub();
            savePlayerAwayLineSub();
            savePlayersHome();
            savePlayersAway();
            TeamInfor.UpdateData(homeCode, homeTactical, homeTenDai, homeTenNgan, homeHLV, homeLogo,
            awayCode, awayTactical, awayTenDai, awayTenNgan, awayHLV, awayLogo,
         Player_HomeColor.BackColor, Player_AwayColor.BackColor, homeHomeItem, homeAwayItem, awayHomeItem, awayAwayItem,
         homeGoalItem, awayGoalItem);

            labelStatus.Text = "OK!";
            labelTimeUpdated.Text = DateTime.Now.ToString("hh:mm:ss tt");
            MessageBox.Show("Thiết lập thành công!");
        }

        public void LoadHomePlayerGrid()
        {
            // Tạo cột DataGridView trước khi thêm dữ liệu
            if (dgvHomePlayer.Columns.Count == 0)
            {
                dgvHomePlayer.Columns.Add("STT", "STT");
                dgvHomePlayer.Columns.Add("Name", "Tên cầu thủ");
                dgvHomePlayer.Columns.Add("Jersey #", "Số áo");
                dgvHomePlayer.Columns.Add("Jersey Name", "Tên áo");
                dgvHomePlayer.Columns.Add("PLAY", "Ra sân");
                dgvHomePlayer.Columns.Add("Position", "Vị trí");
                dgvHomePlayer.Columns.Add("Lineup1", "Ra sân 1");
                dgvHomePlayer.Columns.Add("Sub1", "Dự bị 1");
                dgvHomePlayer.Columns.Add("Lineup2", "Ra sân 2");
                dgvHomePlayer.Columns.Add("Sub2", "Dự bị 2");
                dgvHomePlayer.Columns.Add("Lineup3", "Ra sân 3");
                dgvHomePlayer.Columns.Add("Sub3", "Dự bị 3");

            }
            dgvHomePlayer.Columns[0].Width = 40;
            dgvHomePlayer.Columns[1].Width = 200;
            dgvHomePlayer.Columns[2].Width = 70;
            dgvHomePlayer.Columns[3].Width = 120;
            DataGridViewCompare.Load_Players(TeamInfor.homeTenNgan, dgvHomePlayer);
            // Sắp xếp DataGridView của đội hình theo cột STT thứ tự tăng dần
            dgvHomePlayer.Sort(dgvHomePlayer.Columns["STT"], ListSortDirection.Ascending);
        }
        public void LoadAwayPlayerGrid()
        {
            // Tạo cột DataGridView trước khi thêm dữ liệu
            if (dgvAwayPlayer.Columns.Count == 0)
            {
                dgvAwayPlayer.Columns.Add("STT", "STT");
                dgvAwayPlayer.Columns.Add("Name", "Tên cầu thủ");
                dgvAwayPlayer.Columns.Add("Jersey #", "Số áo");
                dgvAwayPlayer.Columns.Add("Jersey Name", "Tên áo");
                dgvAwayPlayer.Columns.Add("PLAY", "Ra sân");
                dgvAwayPlayer.Columns.Add("Position", "Vị trí");
                dgvAwayPlayer.Columns.Add("Lineup1", "Ra sân 1");
                dgvAwayPlayer.Columns.Add("Sub1", "Dự bị 1");
                dgvAwayPlayer.Columns.Add("Lineup2", "Ra sân 2");
                dgvAwayPlayer.Columns.Add("Sub2", "Dự bị 2");
                dgvAwayPlayer.Columns.Add("Lineup3", "Ra sân 3");
                dgvAwayPlayer.Columns.Add("Sub3", "Dự bị 3");
            }
            dgvAwayPlayer.Columns[0].Width = 40;
            dgvAwayPlayer.Columns[1].Width = 200;
            dgvAwayPlayer.Columns[2].Width = 70;
            dgvAwayPlayer.Columns[3].Width = 120;
            DataGridViewCompare.Load_Players(TeamInfor.awayTenNgan, dgvAwayPlayer);
            // Sắp xếp DataGridView của đội hình theo cột STT thứ tự tăng dần
            dgvAwayPlayer.Sort(dgvAwayPlayer.Columns["STT"], ListSortDirection.Ascending);
        }
        public void savePlayersHome()
        {
            Player[] teamPlayers = new Player[21]; // Khởi tạo mảng 21 phần tử

            for (int i = 0; i < 21; i++)
            {
                if (dgvHomePlayer.Rows[i].IsNewRow) continue; // Bỏ qua hàng mới

                Player player = new Player
                {
                    Name = dgvHomePlayer.Rows[i].Cells["Name"].Value.ToString(),
                    ShortName = dgvHomePlayer.Rows[i].Cells["Jersey Name"].Value.ToString(),
                    Number = dgvHomePlayer.Rows[i].Cells["Jersey #"].Value.ToString(),
                    Lineup = dgvHomePlayer.Rows[i].Cells[HomeLineup].Value.ToString(),
                    Sub = dgvHomePlayer.Rows[i].Cells[HomeSub].Value.ToString(),
                };

                teamPlayers[i] = player;
            }
            TeamInfor.PlayersHome = teamPlayers;
        }
        public void savePlayersAway()
        {
            Player[] teamPlayers = new Player[21]; // Khởi tạo mảng 21 phần tử

            for (int i = 0; i < 21; i++)
            {
                if (dgvAwayPlayer.Rows[i].IsNewRow) continue; // Bỏ qua hàng mới

                Player player = new Player
                {
                    Name = dgvAwayPlayer.Rows[i].Cells["Name"].Value.ToString(),
                    ShortName = dgvAwayPlayer.Rows[i].Cells["Jersey Name"].Value.ToString(),
                    Number = dgvAwayPlayer.Rows[i].Cells["Jersey #"].Value.ToString(),
                    Lineup = dgvAwayPlayer.Rows[i].Cells[AwayLineup].Value.ToString(),
                    Sub = dgvAwayPlayer.Rows[i].Cells[AwaySub].Value.ToString(),
                };

                teamPlayers[i] = player;
            }
            TeamInfor.PlayersAway = teamPlayers;
        }
        //Load DS thi đấu và dự bị đội nhà
        public void savePlayerHomeLineSub()
        {
            Player[] playersLineup = new Player[11];
            Player[] playersSub = new Player[10];
            for (int i = 0; i < 11; i++)
            {
                Player player = new Player();
                player.Name = dgvHomePlayer.Rows[i].Cells["Name"].Value.ToString();
                player.ShortName = dgvHomePlayer.Rows[i].Cells["Jersey #"].Value.ToString() +
                    " " + dgvHomePlayer.Rows[i].Cells["Jersey Name"].Value.ToString();
                player.Number = dgvHomePlayer.Rows[i].Cells["Jersey #"].Value.ToString();
                player.Lineup = dgvHomePlayer.Rows[i].Cells[HomeLineup].Value.ToString();
                player.Sub = dgvHomePlayer.Rows[i].Cells[HomeSub].Value.ToString();
                playersLineup[i] = player;
            }
            for (int i = 11; i < 21; i++)
            {
                Player player = new Player();
                player.Name = dgvHomePlayer.Rows[i].Cells["Name"].Value.ToString();
                player.ShortName = dgvHomePlayer.Rows[i].Cells["Jersey #"].Value.ToString() +
                    " " + dgvHomePlayer.Rows[i].Cells["Jersey Name"].Value.ToString();
                player.Number = dgvHomePlayer.Rows[i].Cells["Jersey #"].Value.ToString();
                player.Lineup = dgvHomePlayer.Rows[i].Cells[HomeLineup].Value.ToString();
                player.Sub = dgvHomePlayer.Rows[i].Cells[HomeSub].Value.ToString();
                playersSub[i - 11] = player;
            }
            TeamInfor.PlayersHomeLineup = playersLineup;
            TeamInfor.PlayersHomeSub = playersSub;
        }
        //Load DS thi đấu và dự bị đội khách
        public void savePlayerAwayLineSub()
        {
            Player[] playersLineup = new Player[11];
            Player[] playersSub = new Player[10];
            for (int i = 0; i < 11; i++)
            {
                Player player = new Player();
                player.Name = dgvAwayPlayer.Rows[i].Cells["Name"].Value.ToString();
                player.ShortName = dgvAwayPlayer.Rows[i].Cells["Jersey #"].Value.ToString() +
                    " " + dgvAwayPlayer.Rows[i].Cells["Jersey Name"].Value.ToString();
                player.Number = dgvAwayPlayer.Rows[i].Cells["Jersey #"].Value.ToString();
                player.Lineup = dgvAwayPlayer.Rows[i].Cells[AwayLineup].Value.ToString();
                player.Sub = dgvAwayPlayer.Rows[i].Cells[AwaySub].Value.ToString();
                playersLineup[i] = player;
            }
            for (int i = 11; i < 21; i++)
            {
                Player player = new Player();
                player.Name = dgvAwayPlayer.Rows[i].Cells["Name"].Value.ToString();
                player.ShortName = dgvAwayPlayer.Rows[i].Cells["Jersey #"].Value.ToString() +
                    " " + dgvAwayPlayer.Rows[i].Cells["Jersey Name"].Value.ToString();
                player.Number = dgvAwayPlayer.Rows[i].Cells["Jersey #"].Value.ToString();
                player.Lineup = dgvAwayPlayer.Rows[i].Cells[AwayLineup].Value.ToString();
                player.Sub = dgvAwayPlayer.Rows[i].Cells[AwaySub].Value.ToString();
                playersSub[i - 11] = player;
            }
            TeamInfor.PlayersAwayLineup = playersLineup;
            TeamInfor.PlayersAwaySub = playersSub;
        }

        private void cbbHomeTactic_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamInfor.homeTactical = homeTactical = cbbHomeTactic.Text;
        }
        private void cbbAwayTactic_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamInfor.awayTactical = awayTactical = cbbAwayTactic.Text;
        }

    }
}
