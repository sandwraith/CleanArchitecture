﻿using System.Collections.Generic;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}