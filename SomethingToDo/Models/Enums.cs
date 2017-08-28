using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SomethingToDo.Models
{
    public enum CategoryEnum
    {
        Sports = 1
    }

    public enum SubCategoryEnum
    {
        Soccer = 1,
        Volleyball,
        Tennis,
        Running,
        Basketball,
        Baseball,
        Softball,
        UltimateFrisbee,
        Golf
    }

    public enum EventTypeEnum
    {
        Public = 1,
        Private
    }
}