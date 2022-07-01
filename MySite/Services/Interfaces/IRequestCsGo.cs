using System;
using MySite.Models.CsStatistics;

namespace MySite.Services.Interfaces
{
    public interface IRequestCsGo
    {
        DateTime NextRequest { get; set; }
        AllStatistics GetData();
    }
}