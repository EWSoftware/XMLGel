﻿using System;
using System.Windows.Documents;
using System.Xml.Linq;
using DaveSexton.XmlGel.Maml.Documents.Visitors;

namespace DaveSexton.XmlGel.Maml.Documents
{
	public sealed class WhitePaperDocument : MamlDocument
	{
		public WhitePaperDocument()
			: base(MamlDocumentKind.Whitepaper)
		{
		}

		public WhitePaperDocument(Guid id, int revisionNumber, XDocument document, XElement documentRoot, IMamlMetadata metadata)
			: base(MamlDocumentKind.Whitepaper, id, revisionNumber, document, documentRoot, metadata)
		{
		}

		internal override MamlToFlowDocumentVisitor CreateVisitor(Action uiContainerChanged)
		{
			return new WhitePaperDocumentToFlowDocumentVisitor(this, uiContainerChanged);
		}

		internal override FlowDocumentToMamlVisitor CreateVisitor(FlowDocument document)
		{
			return new FlowDocumentToWhitePaperDocumentVisitor(document, this);
		}
	}
}