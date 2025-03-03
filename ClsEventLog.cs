using System;
using System.Diagnostics;


internal class ClsEventLog
{
    static string Sourcename = "DVLDProject";
    public static void HandleEventLog(string message)
    {
        if (!EventLog.SourceExists(Sourcename))
        {
            EventLog.CreateEventSource(Sourcename, "Application");
        }
        try
        {
            EventLog.WriteEntry(Sourcename, message, EventLogEntryType.Information);

        }
        catch
        {
            EventLog.WriteEntry(Sourcename, "Event Unhandled", EventLogEntryType.Warning);
        }
    }
}

