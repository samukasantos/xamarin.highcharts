﻿
using Xamarin.HighCharts.Domain.Entities;
using Xamarin.HighCharts.InfraStructure.UnitWork;

namespace Xamarin.HighCharts.ViewModels.Base.Interfaces
{
    public interface IUserRepositoryService
    {
        IUserRepository Repository { get; }
        IUnitWork UnitWork         { get; }
    }
}
