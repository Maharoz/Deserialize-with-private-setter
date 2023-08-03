using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSetterExample
{
	public class SampleModel
	{
		public int userId { get; set; }
		public int id { get; set; }
		public string title { get;private set; }
		public bool completed { get; set; }
	}
}
