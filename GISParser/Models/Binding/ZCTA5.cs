namespace GISParser.Models.Binding
{
	#region Library Imports

	using System.ComponentModel.DataAnnotations;
	using System.Data.Entity.Spatial;
	using Base;
	using Microsoft.SqlServer.Types;

	#endregion

	public class ZCTA5 : BaseModel
	{
		public int? ZCTA5CE10 { get; set; }
		public int? GEOID10 { get; set; }

		[MaxLength(2, ErrorMessage = "{0}'s length must be {1} characters or less")]
		public string CLASSFP10 { get; set; }

		[MaxLength(5, ErrorMessage = "{0}'s length must be {1} characters or less")]
		public string MTFCC10 { get; set; }

		public string FUNCSTAT10 { get; set; }
		public long? ALAND10 { get; set; }
		public long? AWATER10 { get; set; }
		public float INTPTLAT10 { get; set; }
		public float INTPTLON10 { get; set; }
		public DbGeometry GEOM { get; set; }
	}
}