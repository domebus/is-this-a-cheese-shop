using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace CheesyApi.Models
{
    public class Cheese
    {
		public int Id { get; set; }

		public string Name { get; set; }
		
        public decimal PricePerKilogram { get; set; }
    
        [Browsable(false), Column("Color")]
        public int Argb
        {
            get { return fColor.ToArgb(); }
            set { fColor = Color.FromArgb(value); }
        }
        private Color fColor;
        
        [NotMapped]
        public Color Color
        {
            get { return fColor; }
            set { fColor = value; }
        }
    }
}
