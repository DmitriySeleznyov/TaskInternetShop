using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Contracts.DataContracts
{
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int IDProduct { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(150, ErrorMessage = "Must be between 10 and 150 characters", MinimumLength = 10)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Count is required")]
        public int Count { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 999999, ErrorMessage = "Price not correct")]
        public double Price { get; set; }

        public string AdditionalInfo { get; set; }

        [Required(ErrorMessage = "Guarantee is required")]
        [Range(1, 120, ErrorMessage = "Guarantee not correct")]
        public int Guarantee { get; set; }

        [Required(ErrorMessage = "Materials is required")]
        public string Materials { get; set; }

        [Required(ErrorMessage = "Length is required")]
        public int Length { get; set; }

        [Required(ErrorMessage = "Width is required")]
        public int Width { get; set; }

        [Required(ErrorMessage = "Weight is required")]
        public int Weight { get; set; }

        public string Color { get; set; }

        public string Equipment { get; set; }

        [Required(ErrorMessage = "Manufacturer is required")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }

        [Required(ErrorMessage = "ManufacturerCountry is required")]
        public string ManufacturerCountry { get; set; }

        public byte[] Image { get; set; }
        //связи
        public Basket Baskets { get; set; }
        public Order Orders { get; set; }
    }
}
