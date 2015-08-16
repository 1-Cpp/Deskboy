using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskboyDotNet
{
	class Tasks : DeskElements
	{
		public override void save()
		{
			throw new NotImplementedException();
		}
		public override void load()
		{
			file.readAllLines();

		}
		public void Add(Task task)
		{
			file.records.Add(task.toRecord());
      }
	}
	
	class Task : DeskElement
	{
		String TaskState;
		String TaskName;
		String[] TaskDesc;
		String[] TaskTags;

		public override void load(BoyRecord record)
		{
			base.load(record);
			if (record.dict.ContainsKey("tags"))
			{
				String tags = record.dict["tags"];
				char[] ar = { ',' };
				TaskTags = tags.Split(ar);
			}
			if (record.dict.ContainsKey("state"))
			{
				TaskState = record.dict["state"];
			}
			TaskName = record.first;
			TaskDesc = record.body.ToArray<String>();	
		}
		public BoyRecord toRecord()
		{
			BoyRecord record = new BoyRecord();
			record.first = taskName;
			record.body = new List<String>((IEnumerable<String>)taskDesc);
			record.dict.Add("cat", category);
			record.dict.Add("tags", String.Join(",", taskTags));
			return record;
		}

		public String taskState
		{
			get
			{
				return TaskState;
			}
			set
			{
				TaskState = value;
			}
		}

		public String taskName
		{
			get
			{
				return TaskName;
			}
			set
			{
				TaskName = value;
			}
		}
		public String[] taskDesc
		{
			get
			{
				return TaskDesc;
			}
			set
			{
				TaskDesc = value;
			}
		}
		public String[] taskTags
		{
			get
			{
				return TaskTags;
			}
			set
			{
				TaskTags = value;
			}
		}
		
	}
}
