using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.WebAPI.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
