using System;
using System.IO;
using System.Text;

namespace StudyCS
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				// ファイルを読み取り形式で開く
				StreamReader file = new StreamReader(@"C:\Users\acfoa\Downloads\programing\School_C-_Object\StudyCS\StudyCS\testkekka.csv", Encoding.UTF8);
				string line = null;
				while ((line = file.ReadLine()) != null)    // 1行ずつ読み込む
				{
					int Sum = 0;
					int ave = 0;
					string[] tango = line.Split(',');       // カンマで区切って配列に格納
					foreach(string s in tango)
                    {
						int n;
						if(int.TryParse(s,out n))
                        {
							Sum += int.Parse(s);

						}
						ave = Sum / tango.Length;
												
					}
                    if (ave != 0)
                    {
						Console.WriteLine(tango[0] + ":平均点" + ave+"点");

					}
				}
				file.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);       // エラーメッセージを表示
			}

		}
    }
}
