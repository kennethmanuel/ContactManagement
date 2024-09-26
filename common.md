## Original DB
```sh
mysqldump -h 192.168.106.225 -P 3306 -u root -p intranet_home > intranet_home_dump_unedited.sql
```

## Edited DB
Test connection
```sh
mysql -u root -p -h 127.0.0.1 -P 3306
```

Dump edited database
```sh
mysqldump -h 127.0.0.1 -P 3306 -u root -p intranet_home > intranet_home_dump_edited.sql
```

Dump original database
```sh
mysqldump -h 192.168.106.225 -P 3306 -u root -p intranet_home > intranet_home_dump_unedited.sql
```