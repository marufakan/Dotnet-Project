# Dotnet-Project
Dotnet-Project

# Technologies
 - C#
 - ASP.Net core
 - swagger
 - EFCore
 - Docker
 - <a href="https://www.google.com/url?sa=j&url=https%3A%2F%2Fgithub.com%2Fmicrosoftarchive%2Fredis%2Freleases%2Fdownload%2Fwin-3.0.504%2FRedis-x64-3.0.504.msi&uct=1651087369&usg=mBchHQ85uiOsVAJUELgvm09f-kk.&source=meet">Redis</a>
 - PostreSQL
 - js
 - Ajax
 - jQuery
 - bootstrap
 - TCMB API : <a href="https://www.tcmb.gov.tr/kurlar/today.xml" >url1</a> - <a href="https://www.tcmb.gov.tr/kurlar/202208/08082022.xml" >url2</a>

# Project
 | Project|
| ------------ |
|<img src="https://github.com/marufakan/Dotnet-Project/blob/main/img/project.png" >|

 | BussinessApi |
| ------------ |
|<img src="https://github.com/marufakan/Dotnet-Project/blob/main/img/bussinessApi.png" >|

 | Currency Web Site |
| ------------ |
|<img src="https://github.com/marufakan/Dotnet-Project/blob/main/img/website1.png" >|

 | Currency Web Site |
| ------------ |
|<img src="https://github.com/marufakan/Dotnet-Project/blob/main/img/website2.png" >|

# Introduction

1.1. Data API
- The API saves the information on the link below in the database.
- https://www.tcmb.gov.tr/kurlar/today.xml
- Date Range must be last 2 months
- Database must be PostreSQL or mySQL
- Data Layer must be EFCore
- The API must be use swagger
- The API must be ASP.Net core
- Programming language must be C#

1.2. Bussiness API
- The API fetches the requested exchange rate from the cache.
- Cache source must be the database
- The cache must not use in memory
- The API must be use swagger
- The API must be ASP.Net core
- Programming language must be C#

1.3. Currency Web Site
- Web Interface must be ASP.Net Core MVC
- When clicking the search button, the webpage retrieves data from the Business API and
generate chart.
- Web page must be call the Business API with Ajax and use jQuery Framework.
- Chart must be generate using by d3js framework.
- Web page must be use bootstrap framework

1.4. Environment
- Environment must be run on Docker. And it should be run with docker-compose.
- Data API
- Bussiness API
- Database Server
- Cache Server
- Currency Web Site


