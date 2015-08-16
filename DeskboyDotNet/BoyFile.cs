using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskboyDotNet
{
	class BoyRecord
	{
		public Dictionary<String, String> dict = new Dictionary<string, string>();
		public String first;
		public List<String> body;
	}
	class BoyFile
	{
		String[] allLines = null;
		List<BoyRecord> list = new List<BoyRecord>();
		public List<BoyRecord> records
		{
			get
			{
				return list;
			}
		}
		public String filename
		{
			get
			{
				return filename;
			}

			set
			{
			}
		}
		public void readAllLines()
		{
			bool inRecord = false;
			bool inBody = false;
			BoyRecord record = null;
			List<String> body = new List<string>();
			allLines = System.IO.File.ReadAllLines(filename);
			foreach(String line in allLines)
			{
				if(line.Length > 0 && line[0] != '#')
				{
					if(!inRecord)
					{
						record = new BoyRecord();
					}
					else if(record != null)
					{
						if(!inBody)
						{
							int idx = line.IndexOf(":");
							if(idx == -1)
							{
								record.first = line;
								inBody = true;
							}
							else
							{
								record.dict.Add( line.Substring(0, idx),line.Substring(idx+1));
							}
						}
						else
						{
							body.Add(line);
						}
					}
				}
				else if(line.Length > 0 && line[0] == '#')
				{
					if(inRecord)
					{
						inRecord = false;
						record.body = body;
						list.Add(record);
						record = null;
					}
				}
			}
		}
	}
}
