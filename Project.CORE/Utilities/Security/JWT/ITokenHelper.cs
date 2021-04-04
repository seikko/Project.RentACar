using Project.CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.CORE.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
