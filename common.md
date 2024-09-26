## Original DB
```sh
mysqldump -h 192.168.106.225 -P 3306 -u root -p intranet_home > intranet_home_dump_unedited.sql
```

## Edited DB
Test connection
```sh
mysql -u root -p -h 127.0.0.1 -P 3306
mysql -u root -p -h 127.0.0.1 -P 3306 inranet_home < db_dump/intranet_home_dump_unedited.sql
```

Dump edited database
```sh
mysqldump -h 127.0.0.1 -P 3306 -u root -p intranet_home > intranet_home_dump_edited.sql
```

Dump original database
```sh
mysqldump -h 192.168.106.225 -P 3306 -u root -p intranet_home > intranet_home_dump_unedited.sql
```

```sh
dotnet ef dbcontext scaffold "Server=127.0.0.1;Port=3306;Database=intranet_home;User Id=root;Password=my-secret-pw;" Pomelo.EntityFrameworkCore.MySql --table contact_managemen --output-dir Models --force
```