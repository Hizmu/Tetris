using System;
using System.Data;
using System.Data.SqlClient;

namespace Tetris
{
    class Score
    {
        private Tetris tetris;
        public int score { get; private set; }

        public Score(Tetris tetris) { this.tetris = tetris; }
        public void PushScore()
        {
            string Nickname = Tetris.Nickname;
            string cmd = null;
            string queryString = "SELECT * FROM dbo.ScoreTetris;";
            cmd = $@"INSERT INTO dbo.ScoreTetris VALUES('{Nickname}','{score}') ";
            try
            {
                using (SqlConnection connection = new SqlConnection(Setting.conn_Score))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlData = sqlCommand.ExecuteReader();
                    while (sqlData.Read())
                    {

                        if ((string)sqlData.GetValue(0) == Nickname)
                        {

                            if ((int)sqlData.GetValue(1) >= score)
                            {
                                sqlData.Close();
                                return;
                            }
                            sqlData.Close();
                            cmd = $@"UPDATE dbo.ScoreTetris SET
                        Score = '{score}'
                        WHERE Nickname = '{Nickname}'";
                            sqlCommand = new SqlCommand(cmd, connection);
                            sqlCommand.ExecuteNonQuery();
                            return;
                        }
                    }
                    sqlData.Close();
                    sqlCommand = new SqlCommand(cmd, connection);
                    sqlCommand.ExecuteNonQuery();

                }
            }
            catch(Exception)
            {
                return;
            }
        }
        public void Clear()
        {
            score = 0;
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
            tetris.btCloseScore.BringToFront();
        }
        public void HideScore()
        {
            tetris.dgvScore.Visible = false;
            tetris.btCloseScore.Visible = false;
        }
    }
}
