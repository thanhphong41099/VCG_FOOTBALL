using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace VLeague.src.helper
{
    internal class DataGridViewCompare
    {

        //Funtional use control one DataGridView for all players of team
        public static void Load_Players(string teamCode , DataGridView dataGrid)
        {
            try
            {
                DBConfig.doGetPlayersTeam(teamCode);
                dataGrid.Rows.Clear();
                foreach (DataRow dr in DBConfig.playersTeam.Rows)
                {
                    dataGrid.Rows.Add(dr["STT"], dr["Name"].ToString(), dr["Jersey #"].ToString(), dr["Jersey Name"].ToString(),dr["PLAY"].ToString(), 
                        dr["Position"].ToString(), dr["Lineup1"].ToString(), dr["Sub1"].ToString(),
                        dr["Lineup2"].ToString(), dr["Sub2"].ToString(), dr["Lineup3"].ToString(), dr["Sub3"].ToString());
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
                Handler.handlerError("Load_Players", ex);
            }
        }

        public static void makeColorRanking(DataGridView dgv) 
        {
            int j = dgv.RowCount;
            for (int i = 0; i < j; i++)
            {
                if (i % 2 == 0)
                {
                    //dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
