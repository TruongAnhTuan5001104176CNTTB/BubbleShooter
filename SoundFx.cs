using System;
using System.Collections.Generic;
using System.IO;
using System.Media;

namespace BubbleShooter
{
    // Âm thanh của game: tự tạo sóng âm (sin) rồi ghi thành file WAV trong bộ nhớ,
    // phát bằng SoundPlayer. Không cần file .wav bên ngoài.
    public static class SoundFx
    {
        private const int Rate = 22050; // số mẫu mỗi giây
        private static Dictionary<string, SoundPlayer> players = new Dictionary<string, SoundPlayer>();

        static SoundFx()
        {
            try
            {
                // mỗi nốt: { tần số đầu (Hz), tần số cuối (Hz), thời gian (ms) }
                Add("shoot", new double[] { 450, 950, 90 });
                Add("pop", new double[] { 900, 350, 70 }, new double[] { 700, 250, 90 });
                Add("fall", new double[] { 700, 500, 70 }, new double[] { 500, 350, 70 }, new double[] { 350, 180, 120 });
                Add("drop", new double[] { 180, 70, 180 });
                Add("level", new double[] { 523, 523, 90 }, new double[] { 659, 659, 90 },
                             new double[] { 784, 784, 90 }, new double[] { 1047, 1047, 220 });
                Add("over", new double[] { 392, 392, 180 }, new double[] { 330, 330, 180 },
                            new double[] { 262, 262, 180 }, new double[] { 196, 150, 400 });
                Add("click", new double[] { 800, 800, 40 });
            }
            catch (Exception)
            {
                // không tạo được âm thanh thì game vẫn chạy, chỉ là im lặng
            }
        }

        private static void Add(string name, params double[][] notes)
        {
            SoundPlayer p = new SoundPlayer(new MemoryStream(BuildWav(notes)));
            p.Load();
            players[name] = p;
        }

        // Ghép các nốt thành một đoạn WAV (16-bit, mono)
        private static byte[] BuildWav(double[][] notes)
        {
            List<short> samples = new List<short>();
            double phase = 0;
            foreach (double[] n in notes)
            {
                int count = (int)(Rate * n[2] / 1000);
                for (int i = 0; i < count; i++)
                {
                    double t = (double)i / count;               // 0 -> 1 trong nốt
                    double freq = n[0] + (n[1] - n[0]) * t;     // tần số trượt từ đầu tới cuối
                    phase += 2 * Math.PI * freq / Rate;

                    // vào nhanh, tắt dần cho tiếng "tạch" gọn, không bị chói
                    double env = Math.Min(1.0, i / (Rate * 0.004)) * Math.Pow(1 - t, 1.5);
                    // sóng sin + một chút họa âm bậc 2 cho tiếng đầy hơn
                    double v = (Math.Sin(phase) + 0.35 * Math.Sin(2 * phase)) / 1.35;
                    samples.Add((short)(v * env * 0.6 * short.MaxValue));
                }
            }

            MemoryStream ms = new MemoryStream();
            BinaryWriter w = new BinaryWriter(ms);
            int dataLen = samples.Count * 2;
            w.Write(new char[] { 'R', 'I', 'F', 'F' });
            w.Write(36 + dataLen);
            w.Write(new char[] { 'W', 'A', 'V', 'E' });
            w.Write(new char[] { 'f', 'm', 't', ' ' });
            w.Write(16);                // kích thước khối fmt
            w.Write((short)1);          // PCM
            w.Write((short)1);          // 1 kênh
            w.Write(Rate);
            w.Write(Rate * 2);          // byte mỗi giây
            w.Write((short)2);          // byte mỗi mẫu
            w.Write((short)16);         // bit mỗi mẫu
            w.Write(new char[] { 'd', 'a', 't', 'a' });
            w.Write(dataLen);
            foreach (short s in samples) w.Write(s);
            w.Flush();
            return ms.ToArray();
        }

        public static void Play(string name)
        {
            try
            {
                SoundPlayer p;
                if (players.TryGetValue(name, out p)) p.Play();
            }
            catch (Exception)
            {
                // máy không có thiết bị âm thanh -> bỏ qua
            }
        }
    }
}
