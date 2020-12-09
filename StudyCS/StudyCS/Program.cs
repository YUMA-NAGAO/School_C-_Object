using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace StudyCS
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("hello");
			Seiseki sei = new Seiseki("file.csv");
			double kamokuheikin = Seiseki.KamokuHeikin("国語");
		}

    }

	public class Seiseki
	{
		private Dictionary<int, string> name;
		private Dictionary<int, Dictionary<string, int>> seiseki;

		public  Seiseki(string filename)
        {
			StreamReader sr = new StreamReader(filename);

			name = new Dictionary<int, string>();
			seiseki = new Dictionary<int, Dictionary<string, int>>();

			//一行目の処理
			string line = sr.ReadLine();
			char[] wake = { ' ', ',', '\t', '\n', '\r' };

			List<string> kamokumei = new List<string>();
			string[] youso = line.Split(wake, StringSplitOptions.RemoveEmptyEntries);
			for(int i = 2; i < youso.Length; i++)
            {
				kamokumei.Add(youso[i]);
            }

            while (!sr.EndOfStream)
            {
				line = sr.ReadLine();
				youso = line.Split(wake, StringSplitOptions.RemoveEmptyEntries);
				int syussekibangou = Int32.Parse(youso[0]);
				string StudentName = youso[1];
				name.Add(syussekibangou, StudentName);
				Dictionary<string, int> kojinseiseki = new Dictionary<string, int>();
				for(int i = 2; i < youso.Length; i++)
                {
					kojinseiseki.Add(kamokumei[i - 2], Int32.Parse(youso[i]));

                }



            }

		}
		public static double KamokuHeikin(string kamokumei)
		{
			
			int gakuseisuu = seiseki.Values.Count;
			double sum = 0;

			Console.WriteLine("aa");
		}

	}



}
