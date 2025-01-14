namespace leanExtraWebApp.StateStore
{
    public class TorontoOnlineStorage : Oberserver
    {
        private int _numServersOnline;
        public int GetNumberServersOnline()
        {
            return _numServersOnline;
        }
        public void SetNumbersServerOnline(int number)
        {
            _numServersOnline = number;
            base.BroadcastStateChange();
        }
    }
}