using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskboyDotNet
{
	abstract class DeskElement
	{
		String Category;
		public String category
		{
			get
			{
				return Category;
			}
			set
			{
				Category = value;
			}
		}
		public virtual void save()
		{

		}
      public virtual void load(BoyRecord record)
		{
			if(record.dict.ContainsKey("cat"))
				category = record.dict["cat"];
		}
	}
	abstract class DeskElements : ISaveAble
	{
		BoyFile File = new BoyFile();
		int Index = -1;
		public abstract void save();
		public abstract void load();
		public void setFileName(String path)
		{
			File.filename = path;
		}
		public int index
		{
			get
			{
				return Index;
			}
		}
		public void reset()
		{
			Index = -1;
		}
		public bool increment()
		{
			if (File.records.Count > 0 && Index < File.records.Count - 1)
			{
				Index++;
				return true;
			}
			return false;
		}
		public BoyFile file
		{
			get
			{
				return File;
			}
		}
	}
}
