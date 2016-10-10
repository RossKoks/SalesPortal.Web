Sales Portal Api

|    CI    |      Status   |
|----------|:-------------:|
| AppVeyor(Windows): |  [![Build status](https://ci.appveyor.com/api/projects/status/vkky4pvl9n22kucp?svg=true)](https://ci.appveyor.com/project/dominikus1993/salesportal-web) |
| CircleCI(Linux): |[![CircleCI](https://circleci.com/gh/RossKoks/SalesPortal.Web.svg?style=svg)](https://circleci.com/gh/RossKoks/SalesPortal.Web) |

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

#### If would you like use watch tool
1. dotnet restore
2. dotnet build
3. dotnet watch run
