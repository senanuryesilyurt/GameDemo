using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameDemo.Abstract
{
    public interface IValidationService
    {
        bool Validation(Gamer gamer);
    }
}
