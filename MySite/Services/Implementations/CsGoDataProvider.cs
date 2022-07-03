using System;
using System.Threading;
using System.Threading.Tasks;
using MySite.Models.CsStatistics;

namespace MySite.Services.Implementations
{
    public class CsGoDataProvider : ICsGoDataProvider
    {
        private DateTime _nextRequest;
        private AllStatistics _currentCsGoData;

        private readonly ICsGoStatisticsFetcher _csGoStatsFetcher;
        private readonly ReaderWriterLockSlim _lock = new();

        public CsGoDataProvider(ICsGoStatisticsFetcher csGoStatsFetcher)
        {
            _csGoStatsFetcher = csGoStatsFetcher;
        }

        public async Task<AllStatistics> GetData()
        {
            _lock.EnterReadLock();
            try
            {
                if (DateTime.Now <= _nextRequest)
                    return _currentCsGoData;
            }
            finally
            {
                _lock.ExitReadLock();
            }

            _lock.EnterWriteLock();
            try
            {
                _nextRequest = DateTime.Now.AddHours(1);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
            return _currentCsGoData = await _csGoStatsFetcher.GetAllStatistics();
        }
    }
}