using System;
using System.Collections.Generic;
using System.IO;

namespace BubbleShooter
{
    public class ScoreEntry
    {
        public string Name;
        public int Score;
        public string Difficulty;
        public string Date;
    }

    // Doc/ghi bang thanh tich vao file bubble_scores.txt
    // Moi dong: ten|diem|do kho|ngay
    public static class ScoreManager
    {
        private static string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bubble_scores.txt");

        // Sap xep giam dan theo diem
        private static int CompareScore(ScoreEntry a, ScoreEntry b)
        {
            return b.Score.CompareTo(a.Score);
        }

        public static List<ScoreEntry> Load()
        {
            List<ScoreEntry> list = new List<ScoreEntry>();
            try
            {
                if (File.Exists(FilePath))
                {
                    string[] lines = File.ReadAllLines(FilePath);
                    foreach (string line in lines)
                    {
                        string[] p = line.Split('|');
                        int score;
                        if (p.Length == 4 && int.TryParse(p[1], out score))
                        {
                            ScoreEntry s = new ScoreEntry();
                            s.Name = p[0];
                            s.Score = score;
                            s.Difficulty = p[2];
                            s.Date = p[3];
                            list.Add(s);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // neu doc file loi thi tra ve danh sach rong
            }

            list.Sort(CompareScore);
            if (list.Count > 10)
                list.RemoveRange(10, list.Count - 10);
            return list;
        }

        public static void Save(ScoreEntry entry)
        {
            try
            {
                List<ScoreEntry> list = Load();
                list.Add(entry);
                list.Sort(CompareScore);
                if (list.Count > 10)
                    list.RemoveRange(10, list.Count - 10);

                List<string> lines = new List<string>();
                foreach (ScoreEntry s in list)
                    lines.Add(s.Name.Replace("|", "") + "|" + s.Score + "|" + s.Difficulty + "|" + s.Date);
                File.WriteAllLines(FilePath, lines);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Khong luu duoc thanh tich: " + ex.Message);
            }
        }

        public static int HighScore()
        {
            List<ScoreEntry> list = Load();
            if (list.Count == 0) return 0;
            return list[0].Score;
        }
    }
}
