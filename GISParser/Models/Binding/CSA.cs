namespace GISParser.Models.Binding
{
	#region Library Imports

	using System.ComponentModel.DataAnnotations;
	using System.Data.Entity.Spatial;
	using Base;
	using Microsoft.SqlServer.Types;

	#endregion

	public class CSA : BaseModel
	{
		public short? CSAFP { get; set; }
		public short? GEOID { get; set; }

		[MaxLength(58, ErrorMessage = "{0}'s length must be {1} characters or less")]
		public string NAME { get; set; }

		[MaxLength(62, ErrorMessage = "{0}'s length must be {1} characters or less")]
		public string NAMELSAD { get; set; }

		[MaxLength(2, ErrorMessage = "{0}'s length must be {1} characters or less")]
		public string LSAD { get; set; }

		[MaxLength(5, ErrorMessage = "{0}'s length must be {1} characters or less")]
		public string MTFCC { get; set; }

		public long? ALAND { get; set; }
		public long? AWATER { get; set; }
		public float INTPTLAT { get; set; }
		public float INTPTLON { get; set; }
		public DbGeometry GEOM { get; set; }
	}
}