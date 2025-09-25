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
using VLeague.src.helper;
using VLeague.src.model;

namespace VLeague.src.menu
{
    public partial class FrmSubstitution : Form
    {
        public FrmSubstitution()
        {
            InitializeComponent();
            ButtonHelper.InitializeButtons(this);
        }

        private void FrmSubstitution_Load(object sender, EventArgs e)
        {
            try
            {

                // Gọi hàm để lấy dữ liệu từ bảng THONGKE
                DBConfig.doGetAllStatistics();

                fillAllcbb();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu, vui lòng LOAD DATA ở DATA IMPORT", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePlayerNumber(ComboBox comboBox, TextBox textBox, Player[] players)
        {
            int selectedIndex = comboBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < players.Length)
            {
                Player selectedPlayer = players[selectedIndex];

                // Cập nhật TextBox
                textBox.Text = selectedPlayer.Number;

                // Lưu toàn bộ Player object vào Tag của ComboBox
                comboBox.Tag = selectedPlayer;
            }
        }

        //Event chọn player, lấy số áo (Number) của các Cbb LineUp
        private void cbbHomeLineUp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbHomeLineUp1, numHomeLine1, TeamInfor.PlayersHome);
            // cách dùng Tag để lấy Player object
            string shortName = (cbbHomeLineUp1.Tag as Player)?.ShortName;
        }
        private void cbbHomeLineUp2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbHomeLineUp2, numHomeLine2, TeamInfor.PlayersHome);
        }
        private void cbbHomeLineUp3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbHomeLineUp3, numHomeLine3, TeamInfor.PlayersHome);
        }
        private void cbbAwayLineUp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbAwayLineUp1, numAwayLine1, TeamInfor.PlayersAway);
        }
        private void cbbAwayLineUp2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbAwayLineUp2, numAwayLine2, TeamInfor.PlayersAway);
        }
        private void cbbAwayLineUp3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbAwayLineUp3, numAwayLine3, TeamInfor.PlayersAway);
        }
        //Event chọn player, lấy số áo (Number) của các Cbb Sub
        private void cbbHomeSub1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbHomeSub1, numHomeSub1, TeamInfor.PlayersHome);
        }
        private void cbbHomeSub2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbHomeSub2, numHomeSub2, TeamInfor.PlayersHome);
        }
        private void cbbHomeSub3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbHomeSub3, numHomeSub3, TeamInfor.PlayersHome);
        }
        private void cbbAwaySub1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbAwaySub1, numAwaySub1, TeamInfor.PlayersAway);
        }
        private void cbbAwaySub2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbAwaySub2, numAwaySub2, TeamInfor.PlayersAway);
        }
        private void cbbAwaySub3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePlayerNumber(cbbAwaySub3, numAwaySub3, TeamInfor.PlayersAway);
        }

        private void stopAll_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Stop(FrmSetting.layerTSL);
        }
        private void fillAllcbb()
        {
            //Fill combobox Line Up
            FrmInMatchClock.FillCbbPlayer(cbbHomeLineUp1, TeamInfor.PlayersHome);
            FrmInMatchClock.FillCbbPlayer(cbbHomeLineUp2, TeamInfor.PlayersHome);
            FrmInMatchClock.FillCbbPlayer(cbbHomeLineUp3, TeamInfor.PlayersHome);
            FrmInMatchClock.FillCbbPlayer(cbbAwayLineUp1, TeamInfor.PlayersAway);
            FrmInMatchClock.FillCbbPlayer(cbbAwayLineUp2, TeamInfor.PlayersAway);
            FrmInMatchClock.FillCbbPlayer(cbbAwayLineUp3, TeamInfor.PlayersAway);
            //Fill combobox Sub
            FrmInMatchClock.FillCbbPlayer(cbbHomeSub1, TeamInfor.PlayersHome);
            FrmInMatchClock.FillCbbPlayer(cbbHomeSub2, TeamInfor.PlayersHome);
            FrmInMatchClock.FillCbbPlayer(cbbHomeSub3, TeamInfor.PlayersHome);
            FrmInMatchClock.FillCbbPlayer(cbbAwaySub1, TeamInfor.PlayersAway);
            FrmInMatchClock.FillCbbPlayer(cbbAwaySub2, TeamInfor.PlayersAway);
            FrmInMatchClock.FillCbbPlayer(cbbAwaySub3, TeamInfor.PlayersAway);
            //Fill combobox Static
            DBConfig.matchingMatchDetailCombobox(cbbStatic1);
            DBConfig.matchingMatchDetailCombobox(cbbStatic2);
            DBConfig.matchingMatchDetailCombobox(cbbStatic3);

            cbbStatic1.SelectedIndex = 0;
            cbbStatic2.SelectedIndex = 1;
            cbbStatic3.SelectedIndex = 2;
        }

        private void ClearAllInputs(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).Text = string.Empty;
                }
                else if (c.Controls.Count > 0)
                {
                    ClearAllInputs(c);
                }
            }
        }
        private bool ValidatePlayerSelection(params ComboBox[] combos)
        {
            foreach (var combo in combos)
            {
                if (string.IsNullOrWhiteSpace(combo.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void clearCbb_Click(object sender, EventArgs e)
        {
            ClearAllInputs(this);
        }

        private void numHomeLine1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbHomeLineUp1, numHomeLine1);
            }
        }

        private void numHomeLine2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbHomeLineUp2, numHomeLine2);
            }
        }

        private void numHomeLine3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbHomeLineUp3, numHomeLine3);
            }
        }

        private void numHomeSub1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbHomeSub1, numHomeSub1);
            }
        }

        private void numHomeSub2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbHomeSub2, numHomeSub2);
            }
        }

        private void numHomeSub3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbHomeSub3, numHomeSub3);
            }
        }

        private void numAwayLine1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbAwayLineUp1, numAwayLine1);
            }
        }

        private void numAwayLine2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbAwayLineUp2, numAwayLine2);
            }
        }

        private void numAwayLine3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbAwayLineUp3, numAwayLine3);
            }
        }

        private void numAwaySub1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbAwaySub1, numAwaySub1);
            }
        }

        private void numAwaySub2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbAwaySub2, numAwaySub2);
            }
        }

        private void numAwaySub3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmInMatchClock.SelectPlayerByNumber(cbbAwaySub3, numAwaySub3);
            }
        }

        private void btnHomeOut1_Click(object sender, EventArgs e)
        {
            if (!ValidatePlayerSelection(cbbHomeLineUp1, cbbHomeSub1))
            {
                MessageBox.Show("Chưa chọn đủ cầu thủ ra - vào sân");
                return;
            }
            string lineName = (cbbHomeLineUp1.Tag as Player)?.ShortName;
            string subName = (cbbHomeSub1.Tag as Player)?.ShortName;
            string lineNum = (cbbHomeLineUp1.Tag as Player)?.Number;
            string subNum = (cbbHomeSub1.Tag as Player)?.Number;
            string lineIMG = (cbbHomeLineUp1.Tag as Player)?.Sub;
            string subIMG = (cbbHomeSub1.Tag as Player)?.Sub;

            FrmKarismaMenu.FrmSetting.swapOnePlayer(lineName, subName, lineNum, subNum,
                lineIMG, subIMG, TeamInfor.homeLogo);
        }

        private void btnHomeOut2_Click(object sender, EventArgs e)
        {
            if (!ValidatePlayerSelection(cbbHomeLineUp1, cbbHomeSub1, cbbHomeLineUp2, cbbHomeSub2))
            {
                MessageBox.Show("Chưa chọn đủ cầu thủ ra - vào sân");
                return;
            }
            string lineName = (cbbHomeLineUp1.Tag as Player)?.ShortName;
            string subName = (cbbHomeSub1.Tag as Player)?.ShortName;
            string lineNum = (cbbHomeLineUp1.Tag as Player)?.Number;
            string subNum = (cbbHomeSub1.Tag as Player)?.Number;
            string lineIMG = (cbbHomeLineUp1.Tag as Player)?.Sub;
            string subIMG = (cbbHomeSub1.Tag as Player)?.Sub;
            string lineName2 = (cbbHomeLineUp2.Tag as Player)?.ShortName;
            string subName2 = (cbbHomeSub2.Tag as Player)?.ShortName;
            string lineNum2 = (cbbHomeLineUp2.Tag as Player)?.Number;
            string subNum2 = (cbbHomeSub2.Tag as Player)?.Number;
            string lineIMG2 = (cbbHomeLineUp2.Tag as Player)?.Sub;
            string subIMG2 = (cbbHomeSub2.Tag as Player)?.Sub;
            FrmKarismaMenu.FrmSetting.swapTwoPlayer(lineName, subName, lineNum, subNum,
                lineIMG, subIMG, lineName2, subName2, lineNum2, subNum2,
                lineIMG2, subIMG2, TeamInfor.homeLogo);

        }

        private void btnHomeOut3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbHomeLineUp1.Text) || string.IsNullOrWhiteSpace(cbbHomeSub1.Text) ||
                string.IsNullOrWhiteSpace(cbbHomeLineUp2.Text) || string.IsNullOrWhiteSpace(cbbHomeSub2.Text) ||
                string.IsNullOrWhiteSpace(cbbHomeLineUp3.Text) || string.IsNullOrWhiteSpace(cbbHomeSub3.Text))
            {
                MessageBox.Show("Chưa chọn đủ cầu thủ ra - vào sân");
                return;
            }
            string lineName = (cbbHomeLineUp1.Tag as Player)?.ShortName;
            string subName = (cbbHomeSub1.Tag as Player)?.ShortName;
            string lineNum = (cbbHomeLineUp1.Tag as Player)?.Number;
            string subNum = (cbbHomeSub1.Tag as Player)?.Number;
            string lineIMG = (cbbHomeLineUp1.Tag as Player)?.Sub;
            string subIMG = (cbbHomeSub1.Tag as Player)?.Sub;
            string lineName2 = (cbbHomeLineUp2.Tag as Player)?.ShortName;
            string subName2 = (cbbHomeSub2.Tag as Player)?.ShortName;
            string lineNum2 = (cbbHomeLineUp2.Tag as Player)?.Number;
            string subNum2 = (cbbHomeSub2.Tag as Player)?.Number;
            string lineIMG2 = (cbbHomeLineUp2.Tag as Player)?.Sub;
            string subIMG2 = (cbbHomeSub2.Tag as Player)?.Sub;
            string lineName3 = (cbbHomeLineUp3.Tag as Player)?.ShortName;
            string subName3 = (cbbHomeSub3.Tag as Player)?.ShortName;
            string lineNum3 = (cbbHomeLineUp3.Tag as Player)?.Number;
            string subNum3 = (cbbHomeSub3.Tag as Player)?.Number;
            string lineIMG3 = (cbbHomeLineUp3.Tag as Player)?.Sub;
            string subIMG3 = (cbbHomeSub3.Tag as Player)?.Sub;
            FrmKarismaMenu.FrmSetting.swapThreePlayer(lineName, subName, lineNum, subNum,
                lineIMG, subIMG, lineName2, subName2, lineNum2, subNum2,
                lineIMG2, subIMG2, lineName3, subName3, lineNum3, subNum3,
                lineIMG3, subIMG3, TeamInfor.homeLogo);
        }

        private void btnHomeIn1_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Play(FrmSetting.layerTSL);
        }

        private void btnHomeIn2_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Play(FrmSetting.layerTSL);
        }

        private void btnHomeIn3_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Play(FrmSetting.layerTSL);
        }

        private void btnAwayOut1_Click(object sender, EventArgs e)
        {
            //write code here
            if (!ValidatePlayerSelection(cbbAwayLineUp1, cbbAwaySub1))
            {
                MessageBox.Show("Chưa chọn đủ cầu thủ ra - vào sân");
                return;
            }
            string lineName = (cbbAwayLineUp1.Tag as Player)?.ShortName;
            string subName = (cbbAwaySub1.Tag as Player)?.ShortName;
            string lineNum = (cbbAwayLineUp1.Tag as Player)?.Number;
            string subNum = (cbbAwaySub1.Tag as Player)?.Number;
            string lineIMG = (cbbAwayLineUp1.Tag as Player)?.Sub;
            string subIMG = (cbbAwaySub1.Tag as Player)?.Sub;
            FrmKarismaMenu.FrmSetting.swapOnePlayer(lineName, subName, lineNum, subNum,
                lineIMG, subIMG, TeamInfor.awayLogo);
        }

        private void btnAwayOut2_Click(object sender, EventArgs e)
        {
            if (!ValidatePlayerSelection(cbbAwayLineUp1, cbbAwaySub1, cbbAwayLineUp2, cbbAwaySub2))
            {
                MessageBox.Show("Chưa chọn đủ cầu thủ ra - vào sân");
                return;
            }
            string lineName = (cbbAwayLineUp1.Tag as Player)?.ShortName;
            string subName = (cbbAwaySub1.Tag as Player)?.ShortName;
            string lineNum = (cbbAwayLineUp1.Tag as Player)?.Number;
            string subNum = (cbbAwaySub1.Tag as Player)?.Number;
            string lineIMG = (cbbAwayLineUp1.Tag as Player)?.Sub;
            string subIMG = (cbbAwaySub1.Tag as Player)?.Sub;
            string lineName2 = (cbbAwayLineUp2.Tag as Player)?.ShortName;
            string subName2 = (cbbAwaySub2.Tag as Player)?.ShortName;
            string lineNum2 = (cbbAwayLineUp2.Tag as Player)?.Number;
            string subNum2 = (cbbAwaySub2.Tag as Player)?.Number;
            string lineIMG2 = (cbbAwayLineUp2.Tag as Player)?.Sub;
            string subIMG2 = (cbbAwaySub2.Tag as Player)?.Sub;
            FrmKarismaMenu.FrmSetting.swapTwoPlayer(lineName, subName, lineNum, subNum,
                lineIMG, subIMG, lineName2, subName2, lineNum2, subNum2,
                lineIMG2, subIMG2, TeamInfor.awayLogo);
        }
        private void btnAwayOut3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbAwayLineUp1.Text) || string.IsNullOrWhiteSpace(cbbAwaySub1.Text) ||
                string.IsNullOrWhiteSpace(cbbAwayLineUp2.Text) || string.IsNullOrWhiteSpace(cbbAwaySub2.Text) ||
                string.IsNullOrWhiteSpace(cbbAwayLineUp3.Text) || string.IsNullOrWhiteSpace(cbbAwaySub3.Text))
            {
                MessageBox.Show("Chưa chọn đủ cầu thủ ra - vào sân");
                return;
            }
            string lineName = (cbbAwayLineUp1.Tag as Player)?.ShortName;
            string subName = (cbbAwaySub1.Tag as Player)?.ShortName;
            string lineNum = (cbbAwayLineUp1.Tag as Player)?.Number;
            string subNum = (cbbAwaySub1.Tag as Player)?.Number;
            string lineIMG = (cbbAwayLineUp1.Tag as Player)?.Sub;
            string subIMG = (cbbAwaySub1.Tag as Player)?.Sub;
            string lineName2 = (cbbAwayLineUp2.Tag as Player)?.ShortName;
            string subName2 = (cbbAwaySub2.Tag as Player)?.ShortName;
            string lineNum2 = (cbbAwayLineUp2.Tag as Player)?.Number;
            string subNum2 = (cbbAwaySub2.Tag as Player)?.Number;
            string lineIMG2 = (cbbAwayLineUp2.Tag as Player)?.Sub;
            string subIMG2 = (cbbAwaySub2.Tag as Player)?.Sub;
            string lineName3 = (cbbAwayLineUp3.Tag as Player)?.ShortName;
            string subName3 = (cbbAwaySub3.Tag as Player)?.ShortName;
            string lineNum3 = (cbbAwayLineUp3.Tag as Player)?.Number;
            string subNum3 = (cbbAwaySub3.Tag as Player)?.Number;
            string lineIMG3 = (cbbAwayLineUp3.Tag as Player)?.Sub;
            string subIMG3 = (cbbAwaySub3.Tag as Player)?.Sub;
            FrmKarismaMenu.FrmSetting.swapThreePlayer(lineName, subName, lineNum, subNum,
                lineIMG, subIMG, lineName2, subName2, lineNum2, subNum2,
                lineIMG2, subIMG2, lineName3, subName3, lineNum3, subNum3,
                lineIMG3, subIMG3, TeamInfor.awayLogo);
        }
        private void btnAwayIn1_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Play(FrmSetting.layerTSL);
        }
        private void btnAwayIn2_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Play(FrmSetting.layerTSL);
        }
        private void btnAwayIn3_Click(object sender, EventArgs e)
        {
            FrmKarismaMenu.FrmSetting.Play(FrmSetting.layerTSL);
        }

        private void btnStats1_Click(object sender, EventArgs e)
        {
            //FrmKarismaMenu.FrmSetting.loadStatistic
        }

        private void UpdateTextBoxFromComboBox(ComboBox comboBox, TextBox homeTextBox, TextBox awayTextBox)
        {
            foreach (DataRow row in DBConfig.statistics.Rows)
            {
                if (row["Tieude"].ToString() == comboBox.Text)
                {
                    homeTextBox.Text = row["ChiSo1"].ToString();
                    awayTextBox.Text = row["ChiSo2"].ToString();
                    break; // Dừng vòng lặp khi tìm thấy kết quả
                }
            }
        }

        private void cbbStatic1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxFromComboBox(cbbStatic1, home1, away1);
        }

        private void cbbStatic2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxFromComboBox(cbbStatic2, home2, away2);
        }

        private void cbbStatic3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxFromComboBox(cbbStatic3, home3, away3);
        }
    } 
}
