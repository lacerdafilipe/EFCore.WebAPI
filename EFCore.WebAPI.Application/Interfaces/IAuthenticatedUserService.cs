using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.WebAPI.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
