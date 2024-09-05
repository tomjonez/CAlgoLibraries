namespace Utils.Time
{
    public class Time
    {
        private TimeZoneInfo londonTimeZone;
        private TimeZoneInfo newYorkTimeZone;

        public Time()
        {
            londonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            newYorkTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        }

        public TimeSpan GetLondonTime(DateTime serverTime)
        {
            DateTime londonTime = TimeZoneInfo.ConvertTime(serverTime, londonTimeZone);
            return londonTime.TimeOfDay;
        }

        public TimeSpan GetNewYorkTime(DateTime serverTime)
        {
            DateTime newYorkTime = TimeZoneInfo.ConvertTime(serverTime, newYorkTimeZone);
            return newYorkTime.TimeOfDay;
        }

        public bool IsLondonTradingSession(DateTime serverTime)
        {
            TimeSpan currentTimeInLondon = GetLondonTime(serverTime);
            TimeSpan londonStart = new TimeSpan(8, 0, 0);
            TimeSpan londonEnd = new TimeSpan(17, 0, 0);
            return currentTimeInLondon >= londonStart && currentTimeInLondon <= londonEnd;
        }

        public bool IsNewYorkTradingSession(DateTime serverTime)
        {
            TimeSpan currentTimeInNewYork = GetNewYorkTime(serverTime);
            TimeSpan newYorkStart = new TimeSpan(8, 0, 0);
            TimeSpan newYorkEnd = new TimeSpan(17, 0, 0);
            return currentTimeInNewYork >= newYorkStart && currentTimeInNewYork <= newYorkEnd;
        }
    }
}
