using System.Threading.Tasks;
using MySite.Models.CsStatistics;

namespace MySite.Services
{
     public interface ICsGoStatisticsFetcher
     {
          Task<AllStatistics> GetAllStatistics();
     }
}