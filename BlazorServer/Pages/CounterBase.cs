﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        protected string opis = "Current count is : ";

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
