#Bugsnager .NET



-----------------------
##Get it now! using NuGet

```powershell
Install-Package Bugsnager
```

##Examples

```csharp

namespace Bugsnag
{
    public static class BugsnagTracker
    {
        public void Report(Exception exception)
        {
            _bugsnagClient.Notify(exception, Severity.Error, metadata);
        }
    }
}
```

To configure the Bugsnager client:

```csharp
 var config = new BaseStorage("Your api-key")
           {
               AppVersion = ApplicationSettings.Default.AppVersion,
#if !DEBUG
                ReleaseStage = "production",
#else
               ReleaseStage = "development",
#endif
               UserId = "user_device_id (not necessary)"
           };
	_bugsnagClient = new Client(config);

```

Using the client:

```csharp
try
{
    //Routine throws an exception
}
catch (Exception ex)
{
    BugsnagTracker.Report(ex);
}
```

##Resources

- [Bugsnag .Net Client](https://github.com/bugsnag/bugsnag-net)
- [Bugsnag Official Website](https://bugsnag.com/)

##License

Copyright 2015 SPB TV AG

Licensed under the Apache License, Version 2.0 (the ["License"](LICENSE)); you may not use this file except in compliance with the License.

You may obtain a copy of the License at [http://www.apache.org/licenses/LICENSE-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

See the License for the specific language governing permissions and limitations under the License.
