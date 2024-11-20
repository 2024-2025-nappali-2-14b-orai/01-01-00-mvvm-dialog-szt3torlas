﻿using CommunityToolkit.Mvvm.ComponentModel;
using StudentProject.Models;
using System.Collections.Generic;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student = new Student();

        [ObservableProperty]
        ///private List<string> _educationLevels = new EducationLevels().AllEducationLevels;
        private List<string> _educationLevels = new List<string> {"érettségi", "szakmai érettségi", "szakmai vizsga"};

        public StudentViewModel()
        {
            _student = new Student();
        }
    }
}
