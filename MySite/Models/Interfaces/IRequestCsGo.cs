using System;
using MySite.Models.CsStatistics;

namespace MySite.Models.Interfaces
{
    public interface IRequestCsGo
    {
        DateTime NextRequest { get; set; }
        AllStatistics GetData();
    }
}