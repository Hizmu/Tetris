using System;
using System.Data;
using System.Data.SqlClient;

namespace Tetris
{
    class Score
    {
        Tetris tetris;
        public int score { get; private set; }

        public Score(Tetris tetris) { this.tetris = tetris; }
        public void PushScore()
        {
            string Nickname = Tetris.Nickname;
            string cmd = null;
            string queryString = "SELECT Nickname FROM dbo.ScoreTetris;";

            cmd = $@"INSERT INTO dbo.Student VALUES ";
            using (SqlConnection connection = new SqlConnection(Setting.conn_Score))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader sqlData = sqlCommand.ExecuteReader();
                while(sqlData.Read())
                {
                    IDataRecord dataRecord = (IDataRecord)sqlData[0];
                    if (dataRecord.ToString() == Nickname)
                    {
                        cmd = $@"UPDATE dbo.ScoreTetris SET
                        Score = '{score}'
                        WHERE Nickname = {Nickname}";
                    }
                }

                connection.Close();
            }
        }

        public static Score operator +(Score score,int num)
        {
            score.score += num;
            return score;
        }
        public static Score operator ++ (Score score)
        {
            score.score += 100;
            return score;
        }
        public void ShowScore()
        {
            tetris.dgvScore.Visible = true;
            tetris.btCloseScore.Visible = true;
        }
        public void HideScore()
        {
            tetris.dgvScore.Visible = false;
            tetris.btCloseScore.Visible = false;
        }
    }
}
