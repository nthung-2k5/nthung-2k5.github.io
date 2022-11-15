namespace OmoriDialogueParser.Model.MessageTextPayloads
{
	interface IPayload
	{
		public string RawText { get; set; }
		public string ToHtml();
	}
}
