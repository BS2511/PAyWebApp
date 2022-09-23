using System;
using System.Collections.Generic;
using System.Text;

namespace PayWebApp.Services
{
    public interface INationalInsuranceContributionService
    {

        decimal NIContribution(decimal totalAmount);

    }
}
