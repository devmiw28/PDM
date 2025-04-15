﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class SessionManager
{
    public static int UserId { get; set; }
    public static string Email { get; set; }
    public static string Role { get; set; }
    public static bool IsVerified { get; set; }

    public static void ClearSession()
    {
        UserId = 0;
        Email = string.Empty;
        Role = string.Empty;
        IsVerified = false;
    }
}

