using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netPlayground.Models
{
	public class AppointmentModel
		
	{
		[Key]

		public int ID { get; set;  }

		[MaxLength(150), Column(TypeName = "nvarchar(150)")] //Declare the key or restrictions above the variable
		public string Title { get; set; } = "Title"; //Here we are setting an initial value

        [MaxLength(300), Column(TypeName = "nvarchar(300)")]
        public string Description { get; set; } = "Description";

		public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

