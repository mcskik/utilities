﻿using ProfileData.DataLayer.Profile;

namespace Same8.DataLayer.Profile
{
    public interface IProfileManager
    {
        ProfileCache ProfileCache { get; set; }
        ApplicationProfile ApplicationProfile { get; set; }
        SystemProfile SystemProfile { get; set; }
        UserSettings UserSettings { get; set; }
        DiffUserSettings DiffUserSettings { get; set; }
    }
}