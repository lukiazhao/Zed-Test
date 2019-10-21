# Zed Studies

A small project composed of backend Web API Service (ASP.NET Core 2.1) and frontend (VueJS 3.0).

## Getting Started


### Prerequisites

```
nodejs, npm, (Visual Studio)
```

### Installing 

### Run Backend
1. clone repo or download zipped project
```
git clone https://github.com/lukiazhao/Zed-Test.git
```
2. open terminal/cmd and get into the project folder
```
$ dotnet run --project ./Zed-dotnet/Zed-dotnet/Zed-dotnet.csproj 
```
OR
double-click Zed-dotnet.sln and open solution in Visual studio. 
Build and run Zed-dotnet.

### Run Test
Open Zed-dotnet.sln in visual studio
Open Test Explorer
To run all the tests in a solution, choose the Run All icon.

### Run Frontend
4. get into zed-vue-3.0 folder 
``` 
npm install
npm run serve
```
5. open browser with url :  ```http://localhost:8080/ ```
6. Click 'Study' in the navigation bar to view the study table

### Discussion: Model design
7. The study model can be broken down into models as `study` has many properties.
For instance: 
````
Study  
  |---- Patient
  |---- Origanization
  |---- ...
````
