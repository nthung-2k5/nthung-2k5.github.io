namespace OmoriDialogueParser.Model.MessageTextPayloads
{
	class DecreaseTextSizePayload: IPayload
	{
		public string RawText { get; set; }
		public string ToHtml() => string.Empty;
	}
}
