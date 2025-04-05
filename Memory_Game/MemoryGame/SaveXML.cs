using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace MemoryGame
{
	public class SaveXML
	{
		public static void SavedData(Info obj, String filename)
		{
			XmlSerializer sr = new XmlSerializer(obj.GetType());
			using (TextWriter tw = new StreamWriter(filename))
			{
				sr.Serialize(tw, obj);
			}
		}

		// Add a method for loading the saved game state
		public static Info LoadedData(string fileName)
		{
			using (FileStream fs = new FileStream(fileName, FileMode.Open))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(Info));
				return (Info)serializer.Deserialize(fs);
			}
		}

	}

}
