﻿namespace Aiursoft.AiurObserver
{
    public static class FeaturesExtensions
    {
        public static FilteredObservable<T> Filter<T>(this IAsyncObservable<T> source, Func<T, bool> predicate)
        {
            return new FilteredObservable<T>(source, predicate);
        }

        public static MappedObservable<T1, T2> Map<T1, T2>(this IAsyncObservable<T1> source, Func<T1, T2> mapper)
        {
            return new MappedObservable<T1, T2>(source, mapper);
        }

        public static ThrottledObservable<T> Throttle<T>(this IAsyncObservable<T> source, TimeSpan throttleTime)
        {
            return new ThrottledObservable<T>(source, throttleTime);
        }
        
        public static RepeatableObservable<T> Repeat<T>(this IAsyncObservable<T> source, int times)
        {
            return new RepeatableObservable<T>(source, times);
        }
        
        public static SampleObservable<T> Sample<T>(this IAsyncObservable<T> source, int every)
        {
            return new SampleObservable<T>(source, every);
        }
        
        public static AggregateObservable<T> Aggregate<T>(this IAsyncObservable<T> source, int every)
        {
            return new AggregateObservable<T>(source, every);
        }
    }
}