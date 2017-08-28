﻿using System.Windows.Documents;
using System.Xml.Linq;
using DaveSexton.XmlGel.Maml.Documents.Visitors;

namespace DaveSexton.XmlGel.Maml.Documents
{
	/* platformNoteType (developerReference.xsd)
	 * 
	 * Sequence:
	 *	- platforms (MamlPlatforms)
	 *	- content (MamlContent)
	 */
	internal sealed class MamlPlatformNote : MamlNode
	{
		public MamlPlatformNote(XElement element)
			: base(element)
		{
		}

		public override TextElement Accept(MamlToFlowDocumentVisitor visitor, out TextElement contentContainer)
		{
			return visitor.Visit(this, out contentContainer);
		}
	}
}