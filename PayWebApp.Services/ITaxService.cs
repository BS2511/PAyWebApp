using System;
using System.Collections.Generic;
using System.Text;

namespace PayWebApp.Services
{
    public interface ITaxService
    {

        decimal TaxAmount(decimal totalAmount);

    }
}
