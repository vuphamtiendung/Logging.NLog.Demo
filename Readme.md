# This is code demo introduce about logging with NLog.
# I using class library and one project backend API .Net Core to demo

# Step One: run extension in package manage console at LoggingService library
    install-package nlog.extensions.logging
# Step Two:
    Create a file 'nlog.config' in backend API with the content below:

    <?xml version="1.0" encoding="utf-8"?>
    <nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
        xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
        autoReload="true"
        internalLogLevel="Trace"
        internalLogFile="your_path_to_file_log\logfile.txt">

        <targets>
            <target name="logfile" xsi:type="File"
                    fileName="your_path_to_file_log/${shortdate}_logfile"
                    layout="${logdate} ${level: uppercase=true} ${message}"/>
        </targets>
        <rules>
            <logger name="*" minlevel="Trace" writeTo="file"></logger>
        </rules>
    </nlog>
    
# Step Three: config in file Programs.cs, call current file to nlog.config
    LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));