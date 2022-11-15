﻿namespace OmoriDialogueParser.Model.MessageTextPayloads
{
	class IncreaseTextSizePayload: IPayload
	{
		public string RawText { get; set; }
		public string ToHtml() => string.Empty;
	}
}
