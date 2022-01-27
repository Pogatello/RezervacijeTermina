using System.ComponentModel.DataAnnotations;

namespace ZavrsniRad.RezervacijeTermina.Data.Models
{
	public class AttachmentLogo
	{
		#region Properties

		[Key]
		public long Id { get; private set; }

		[Required]
		public string Caption { get; private set; }

		[Required]
		public string Content { get; private set; }

		#endregion

		#region Constructors

		public AttachmentLogo(string caption, string content)
		{
			Caption = caption;
			Content = content;
		}

		#endregion
	}
}