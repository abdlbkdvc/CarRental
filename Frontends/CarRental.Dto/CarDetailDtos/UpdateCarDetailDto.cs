using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Dto.CarDetailDtos
{
    public class UpdateCarDetailDto
    {
        public int CarDetailID { get; set; }
        public string CarName { get; set; }
        public string GalleryPhoto1 { get; set; }
        public string GalleryPhoto2 { get; set; }
        public string GalleryPhoto3 { get; set; }
        public string GalleryPhoto4 { get; set; }
        public string Description { get; set; }
    }
}
