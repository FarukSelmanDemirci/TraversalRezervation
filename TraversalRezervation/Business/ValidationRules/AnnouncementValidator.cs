﻿using DTO.DTOs.AnnouncementDTOs;
using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please fill in the title field");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Please fill in the content field");

            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Please enter at least 5 characters");
            RuleFor(x => x.Content).MinimumLength(25).WithMessage("Please enter at least 25 characters");

            RuleFor(x => x.Title).MaximumLength(25).WithMessage("Please enter up to 25 characters");
            RuleFor(x => x.Content).MinimumLength(500).WithMessage("Please enter up to 500 characters");

        }
    }
}
