namespace OmoriDialogueParser.Model
{
	class Message
	{
		public PayloadList Text { get; set; }
		public int? Position { get; set; }
		public int? Background { get; set; }
		public string Faceset { get; set; }
		public int? Faceindex { get; set; }

		public override string ToString() => Text.ToHtml();
	}
}
