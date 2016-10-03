Sales Portal Api

|    CI    |      Status   |
|----------|:-------------:|
| AppVeyor(Windows): |  [![Build status](https://ci.appveyor.com/api/projects/status/vkky4pvl9n22kucp?svg=true)](https://ci.appveyor.com/project/dominikus1993/salesportal-web) |

## How to Run
#### If you use Docker:
1. dotnet restore
2. dotnet build
3. dotnet publish
4. docker  build -t salesportal/app:latest
5. docker run -it -p 5000:5000 salesportal/app

#### If you use Kestrel
1. dotnet restore
2. dotnet build
3. dotnet run
