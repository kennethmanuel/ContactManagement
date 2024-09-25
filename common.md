Test connection
```sh
mysql -u root -p -h 127.0.0.1 -P 3306
```

Dump file
```sh
mysqldump -h 127.0.0.1 -P 3306 -u root -p intranet_home > intranet_home_dump.sql
```