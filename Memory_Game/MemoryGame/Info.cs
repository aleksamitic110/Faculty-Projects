using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Xml.Serialization;

namespace MemoryGame
{
	[Serializable]
	public class Info
	{
		public int Redovi { get; set; }
		public int Kolone { get; set; }
		public string TimeSpanString
		{
			get => MyTimeSpan.ToString();           // e.g. "00:02:35"
			set => MyTimeSpan = TimeSpan.Parse(value);
		}

		[XmlIgnore]
		public TimeSpan MyTimeSpan { get; set; }

		public bool PoljeGenerisano { get; set; }
		public bool StartGame { get; set; }
		public int BrojParova { get; set; }
		public bool JelJeDozvoljenClick { get; set; }

		// Save indexes of images and matched states, not the PictureBox objects themselves.
		public List<String> BoxImageTags { get; set; }
		public List<bool> BoxMatchedStates { get; set; }
	}


}
