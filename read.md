MySql Connectivity With C# Code
EntityFrameWork


FollowSteps:

1.Install MySql
2.Install WorkBench
3.Intstall vstool mysql
4.Install library nugetManager -> mysqlentity




Issue
MySQL - Entity : The value for column 'IsPrimaryKey' in table 'TableDetails' is DBNull

Solution:

Entity Framework (version 6.1.3) and MySQL Server (>= 5.7.6)

One way to resolve the issue is,

1. Open Services (services.msc) and restart MySQL57 service.
2. Execute the following commands in MySQL.
   use <<database name>>;
   set global optimizer_switch='derived_merge=OFF';
3. Update the .edmx