using System.Collections.Generic;
using System.Xml.Serialization;

namespace Contrib.ImportExport.InternalSchema.Tag {

	[XmlRoot("tags")]
	public class Tags {
		
		[XmlElement("tag")]
		public List<Tag> TagList { get; set; }

        public Tags() {
			TagList = new List<Tag>();
		}
	}
}