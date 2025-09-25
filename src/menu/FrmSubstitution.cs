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
            string subIMG = (cbbHomeSub1.Tag as Player)?.Lineup;

            FrmKarismaMenu.FrmSetting.swapOnePlayer(cbbHomeLineUp1.Text,cbbHomeSub1.Text, 
                TeamInfor.homeHomeItem, TeamInfor.homeAwayItem);
        }

        private void btnHomeOut2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbHomeLineUp1.Text) || string.IsNullOrWhiteSpace(cbbHomeSub1.Text) ||
    string.IsNullOrWhiteSpace(cbbHomeLineUp2.Text) || string.IsNullOrWhiteSpace(cbbHomeSub2.Text))
            {
                MessageBox.Show("Chưa chọn đủ cầu thủ ra - vào sân");
                return;
            }

            FrmKarismaMenu.FrmSetting.swapTwoPlayer(cbbHomeLineUp1.Text, cbbHomeSub1.Text,
                cbbHomeLineUp2.Text, cbbHomeSub2.Text, TeamInfor.homeHomeItem, TeamInfor.homeAwayItem);
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
            FrmKarismaMenu.FrmSetting.swapThreePlayer(cbbHomeLineUp1.Text, cbbHomeSub1.Text,
    cbbHomeLineUp2.Text, cbbHomeSub2.Text, cbbHomeLineUp3.Text, cbbHomeSub3.Text,
TeamInfor.homeHomeItem, TeamInfor.homeAwayItem);
        }
    }
}
