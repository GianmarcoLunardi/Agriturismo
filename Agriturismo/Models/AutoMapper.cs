using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Agriturismo.Models;
using AutoMapper;

namespace AutoMapper
{
    public class AutoMapper : Profile 
    {
        public AutoMapper()
        {
            
            CreateMap<Appartament, AppartamentVM>().ReverseMap();

        }
    }


    public class AppartamentVM
    {
        public int Id { get; set; }
        [Required]
        [StringLengthRange(MaximumLength = 15, ErrorMessage = "Must be >10 characters.")]
        public string Name { get; set; }

        public string? Description_It { get; set; }
        public string? Description_Us { get; set; }

        public int DoubleBed { get; set; }
        [DefaultValue(0)]
        public int ExtraBed { get; set; }
        [DefaultValue(0)]
        public int SofàBed { get; set; }
    }




}
